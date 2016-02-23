using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InvenotyManager
{
    public partial class frmIssueItem : Form
    {
        clsManageSqliteDB clsSQLite = new clsManageSqliteDB();

        public string _item_code;
        public string _item_desc;
        public string _item_vendor;
        public string _item_model;
        public string _item_qty;
        public string _item_price;
                

        public frmIssueItem()
        {
            InitializeComponent();
        }

        private void frmIssueItem_Load(object sender, EventArgs e)
        {

            lblIssueValue.Text = string.Empty;

            lblCode.Text = _item_code;
            lblDesc.Text = _item_desc;
            lblModel.Text = _item_model;
            lblStockQty.Text = _item_qty;
            lblVendor.Text = _item_vendor;
            lblPrice.Text = _item_price;

            if (string.IsNullOrEmpty(_item_qty))
                _item_qty = "0";

            if (string.IsNullOrEmpty(_item_price))
                _item_price = "0";


        }

        private void txtIssueQty_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIssueQty.Text) || string.IsNullOrEmpty(_item_price)) { lblIssueValue.Text = string.Empty; return; } 

            long price = Convert.ToInt64(_item_price);
            long qty = Convert.ToInt64(txtIssueQty.Text);
            long total_value = price * qty;
            lblIssueValue.Text = total_value.ToString("#,###,###"); 
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void SaveRecord() 
        {
            //validate issue qty
            if (string.IsNullOrEmpty(txtIssueQty.Text)) { MessageBox.Show("Provide issue qty", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtIssueQty.Focus(); return; }
            
           
            int  issue_qty = Convert.ToInt32(txtIssueQty.Text);
            int stock = Convert.ToInt32(_item_qty);
            
            //check issue qty's availability
            if (issue_qty > stock) { MessageBox.Show("Can't Issue item Qty. " + issue_qty + " that is more than current stock.", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            int new_qty = stock - issue_qty;
            string query = "UPDATE inventory SET item_qty = " + new_qty 
                + " WHERE item_code=" + _item_code;

            try
            {
                int result = clsSQLite.ExecuteQuery(query);
                MessageBox.Show("Total " + issue_qty + " qty has been issued successfully", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { MessageBox.Show("Error in SaveRecord():\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveRecord();
            this.DialogResult = DialogResult.OK;
        }
    }
}