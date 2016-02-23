using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite; 

namespace InvenotyManager
{
    public partial class frmInventoryItem : Form
    {
        //Adding Class ref.
        clsManageSqliteDB clsSQLite = new clsManageSqliteDB();
        
        //public properties
        public Boolean _isNewItem; 
        public string _item_code;
        public string _item_desc;
        public string _item_vendor;
        public string _item_model;
        public string _item_qty;
        public string _item_price;
                

        public frmInventoryItem()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void UpdateInventoryItem() 
        {


            //validate item description before inserting
            if (string.IsNullOrEmpty(txtDesc.Text)) { MessageBox.Show("Please provide Item Desc", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDesc.Focus(); return; }

            //validate item vendor before inserting
            if (string.IsNullOrEmpty(txtVendor.Text)) { MessageBox.Show("Please provide Item Vendor", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtVendor.Focus(); return; }


            string query = string.Empty;

            query = "UPDATE inventory SET "             
            + " item_desc = " + "'" + txtDesc.Text + "',"
            + " item_vendor = " + "'" + txtVendor.Text + "',"
            + " item_model = " +  "'" + txtModel.Text + "',"            
            + " item_price = " + "'" + txtPrice.Text + "'"
            + " WHERE item_code = " + txtCode.Text;
                        

            try
            {
                int result = clsSQLite.ExecuteQuery(query);
                MessageBox.Show(result + " item(s) successfully updated");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Saving Data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void AddNewInventoryItem() 
        {

            string query = string.Empty;

            //validate item description before inserting
            if (string.IsNullOrEmpty(txtDesc.Text)) { MessageBox.Show("Please provide Item Desc", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtDesc.Focus(); return; }
            
            //validate item vendor before inserting
            if (string.IsNullOrEmpty(txtVendor.Text)) { MessageBox.Show("Please provide Item Vendor", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtVendor.Focus(); return; }

            try
            {            
            
            
            query = "INSERT INTO inventory (item_desc, item_vendor, item_price, item_model) "
            + "VALUES ("            
            + "'" + txtDesc.Text + "',"
            + "'" + txtVendor.Text + "',"
            + "'" + txtPrice.Text + "',"
            + "'" + txtModel.Text + "'"            
            + " )";

                int result = clsSQLite.ExecuteQuery(query);
                MessageBox.Show(result + " item(s) successfully added");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Saving Data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            if (_isNewItem)
            {
                AddNewInventoryItem();
            }
            else
            {
                UpdateInventoryItem(); 
            }

        }

        private void frmInventoryItem_Load(object sender, EventArgs e)
        {
            if (_isNewItem == false)
            {
                txtCode.Text = _item_code;
                txtDesc.Text = _item_desc;
                txtModel.Text = _item_model;
                txtPrice.Text = _item_price;
                txtVendor.Text = _item_vendor;
            }
            else
            {
                //read next item code number from database                       
                string query = "SELECT MAX(item_code) FROM inventory";
                int Max_Item_Code = Convert.ToInt32( clsSQLite.GetScalarValue(query));
                int Next_Item_Code = Max_Item_Code + 1;
                txtCode.Text = Next_Item_Code.ToString();
            }

            txtCode.Enabled = false;           


        }
    }
}