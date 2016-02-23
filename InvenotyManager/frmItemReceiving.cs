using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InvenotyManager
{
    public partial class frmItemReceiving : Form
    {

        clsManageSqliteDB clsSQLite = new clsManageSqliteDB();

        public string _item_code;
        public string _item_desc;
        public string _item_vendor;
        public string _item_model;
        public string _item_qty;
        public string _item_price;

        public frmItemReceiving()
        {
            InitializeComponent();
        }

        private void frmItemReceiving_Load(object sender, EventArgs e)
        {

            lblRecvValue.Text = string.Empty;

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

        private void txtRecvQty_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRecvQty.Text) || string.IsNullOrEmpty(_item_price)) { lblRecvValue.Text = string.Empty; return; }

            long price = Convert.ToInt64(_item_price);
            long qty = Convert.ToInt64(txtRecvQty.Text);
            long total_value = price * qty;
            lblRecvValue.Text = total_value.ToString("#,###,###"); 

        }

        private void SaveRecord()
        {
            //validate issue qty
            if (string.IsNullOrEmpty(txtRecvQty.Text)) { MessageBox.Show("Provide recv. qty", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtRecvQty.Focus(); return; }


            int recv_qty = Convert.ToInt32(txtRecvQty.Text);
            int stock = Convert.ToInt32(_item_qty.ToString());

            //check recv qty should be non negative and not zero.
            if (recv_qty <= 0 ) { MessageBox.Show("Can't receive -ve or zero Qty. " , "Receive", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            int new_qty = stock + recv_qty;
            string query = "UPDATE inventory SET item_qty = " + new_qty
                + " WHERE item_code=" + _item_code;

            try
            {
                int result = clsSQLite.ExecuteQuery(query);
                MessageBox.Show("Total " + recv_qty + " qty has been received successfully", "Receiving", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { MessageBox.Show("Error in SaveRecord():\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_save_Click(object sender, EventArgs e)
        {            
            SaveRecord();
            this.DialogResult = DialogResult.OK;
        }
    }
}