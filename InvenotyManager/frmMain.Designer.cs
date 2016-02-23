namespace InvenotyManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_receive = new System.Windows.Forms.Button();
            this.button_issue = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(4, 124);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(677, 235);
            this.grid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOTAL ITEMS :";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCount.Location = new System.Drawing.Point(100, 376);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(97, 13);
            this.lblItemsCount.TabIndex = 8;
            this.lblItemsCount.Text = "<lblItemsCount>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TOTAL QTY:";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(449, 376);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(40, 13);
            this.lblTotalQty.TabIndex = 10;
            this.lblTotalQty.Text = "<Qty>";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(622, 376);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalValue.Size = new System.Drawing.Size(53, 13);
            this.lblTotalValue.TabIndex = 12;
            this.lblTotalValue.Text = "<Value>";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL VALUE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 118);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sample Project Developed by Afroz Hussain in C# and SQLite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InvenotyManager.Properties.Resources.ims_icon;
            this.pictureBox1.Location = new System.Drawing.Point(510, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 126);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "INVENTORY MANAGEMENT";
            // 
            // button_receive
            // 
            this.button_receive.Image = global::InvenotyManager.Properties.Resources.Download;
            this.button_receive.Location = new System.Drawing.Point(444, 415);
            this.button_receive.Name = "button_receive";
            this.button_receive.Size = new System.Drawing.Size(75, 57);
            this.button_receive.TabIndex = 15;
            this.button_receive.Text = "Receive";
            this.button_receive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_receive.UseVisualStyleBackColor = true;
            this.button_receive.Click += new System.EventHandler(this.button_receive_Click);
            // 
            // button_issue
            // 
            this.button_issue.Image = global::InvenotyManager.Properties.Resources.Information;
            this.button_issue.Location = new System.Drawing.Point(363, 415);
            this.button_issue.Name = "button_issue";
            this.button_issue.Size = new System.Drawing.Size(75, 57);
            this.button_issue.TabIndex = 14;
            this.button_issue.Text = "Issue";
            this.button_issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_issue.UseVisualStyleBackColor = true;
            this.button_issue.Click += new System.EventHandler(this.button_issue_Click);
            // 
            // button_close
            // 
            this.button_close.Image = global::InvenotyManager.Properties.Resources.Log_Out;
            this.button_close.Location = new System.Drawing.Point(600, 415);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 57);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Image = global::InvenotyManager.Properties.Resources.Redo;
            this.button_refresh.Location = new System.Drawing.Point(252, 415);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 57);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_delete
            // 
            this.button_delete.Image = global::InvenotyManager.Properties.Resources.Delete;
            this.button_delete.Location = new System.Drawing.Point(170, 415);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 57);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Image = global::InvenotyManager.Properties.Resources.Check;
            this.button_edit.Location = new System.Drawing.Point(88, 415);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 57);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Image = global::InvenotyManager.Properties.Resources.Add;
            this.button_add.Location = new System.Drawing.Point(6, 415);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 57);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.button_receive);
            this.Controls.Add(this.button_issue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.grid);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_issue;
        private System.Windows.Forms.Button button_receive;
    }
}

