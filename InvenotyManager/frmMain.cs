using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace InvenotyManager
{
    public partial class frmMain : Form
    {
        clsManageSqliteDB clsSQLite = new clsManageSqliteDB();

        public frmMain()
        {
            InitializeComponent();
        }

        private void RefreshData() 
        {

            try
            {
                string query = "SELECT * FROM inventory";
                DataTable dTable = clsSQLite.GetDataTable(query);
                grid.DataSource = dTable;

                //show total number of records
                lblItemsCount.Text = dTable.Rows.Count.ToString();
                
                //compute and show total items qty
                string  Total_Qty = dTable.Compute("SUM(item_Qty)", "").ToString();
                lblTotalQty.Text = Total_Qty.ToString();

                //compute and show total items value
                long  Total_Value = Convert.ToInt64( dTable.Compute("SUM(item_price)", "").ToString()) ;
                lblTotalValue.Text = string.Format("{0:#,###,###}", Total_Value);


            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error in RefreshData():\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

        }


        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {             

            this.MaximizeBox = false;
            lblItemsCount.Text = "0";
            lblTotalQty.Text = "0";
            lblTotalValue.Text = "0";
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

            RefreshData();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            frmInventoryItem frmItem = new frmInventoryItem();
            frmItem._isNewItem = true;
            frmItem.ShowDialog();

        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            if (grid.Rows.Count == 0 )
            {
                MessageBox.Show("No item to edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            frmInventoryItem frmItem = new frmInventoryItem();
            frmItem._isNewItem = false;
            frmItem._item_code = grid.SelectedRows[0].Cells["item_code"].Value.ToString();
            frmItem._item_desc = grid.SelectedRows[0].Cells["item_desc"].Value.ToString();
            frmItem._item_vendor = grid.SelectedRows[0].Cells["item_vendor"].Value.ToString();
            frmItem._item_model = grid.SelectedRows[0].Cells["item_model"].Value.ToString();
            frmItem._item_qty = grid.SelectedRows[0].Cells["item_qty"].Value.ToString();
            frmItem._item_price = grid.SelectedRows[0].Cells["item_price"].Value.ToString(); 
                      
            frmItem.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //check that either there are invenotory items in grid list, if not then return without doing any task.
            if (grid.Rows.Count == 0) { MessageBox.Show("No item in list to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
          
            //delete selected inventory item, and before deleting ask for delete confirmation by message box
            if (MessageBox.Show("Delete Selected Item, are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                //read item_code from grid control and store it into selected_item_code string variable
                string selected_item_code = grid.SelectedRows[0].Cells["item_code"].Value.ToString();
                //make query to delete with selected item_code taking from variable
                string query = "DELETE FROM inventory WHERE item_code = " + selected_item_code ;
                //execute query
                clsSQLite.ExecuteQuery(query);
                MessageBox.Show("Deleted Sucessfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            

        }

        private void button_issue_Click(object sender, EventArgs e)
        {


            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("No item to issue", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            frmIssueItem frmIssue = new frmIssueItem();

            frmIssue._item_code = grid.SelectedRows[0].Cells["item_code"].Value.ToString();
            frmIssue._item_desc = grid.SelectedRows[0].Cells["item_desc"].Value.ToString();
            frmIssue._item_vendor = grid.SelectedRows[0].Cells["item_vendor"].Value.ToString();
            frmIssue._item_model = grid.SelectedRows[0].Cells["item_model"].Value.ToString();
            frmIssue._item_qty = grid.SelectedRows[0].Cells["item_qty"].Value.ToString();
            frmIssue._item_price = grid.SelectedRows[0].Cells["item_price"].Value.ToString();

            frmIssue.ShowDialog();


        }

        private void button_receive_Click(object sender, EventArgs e)
        {
            
            if (grid.Rows.Count == 0)
            {
                MessageBox.Show("Please select item to receive", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            frmItemReceiving frmRecv = new frmItemReceiving();

            frmRecv._item_code = grid.SelectedRows[0].Cells["item_code"].Value.ToString();
            frmRecv._item_desc = grid.SelectedRows[0].Cells["item_desc"].Value.ToString();
            frmRecv._item_vendor = grid.SelectedRows[0].Cells["item_vendor"].Value.ToString();
            frmRecv._item_model = grid.SelectedRows[0].Cells["item_model"].Value.ToString();
            frmRecv._item_qty = grid.SelectedRows[0].Cells["item_qty"].Value.ToString();
            frmRecv._item_price = grid.SelectedRows[0].Cells["item_price"].Value.ToString();

            frmRecv.ShowDialog();

        }
    }
}