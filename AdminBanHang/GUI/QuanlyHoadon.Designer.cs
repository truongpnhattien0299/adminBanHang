namespace AdminBanHang.GUI
{
    partial class QuanlyHoadon
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
            this.listViewInvoice = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewInvoiceDetail = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.txtMadon = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewInvoice
            // 
            this.listViewInvoice.HideSelection = false;
            this.listViewInvoice.Location = new System.Drawing.Point(6, 19);
            this.listViewInvoice.Name = "listViewInvoice";
            this.listViewInvoice.Size = new System.Drawing.Size(543, 382);
            this.listViewInvoice.TabIndex = 0;
            this.listViewInvoice.UseCompatibleStateImageBehavior = false;
            this.listViewInvoice.Click += new System.EventHandler(this.listview_Invoice_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewInvoice);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewInvoiceDetail);
            this.groupBox2.Location = new System.Drawing.Point(573, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // listViewInvoiceDetail
            // 
            this.listViewInvoiceDetail.HideSelection = false;
            this.listViewInvoiceDetail.Location = new System.Drawing.Point(6, 19);
            this.listViewInvoiceDetail.Name = "listViewInvoiceDetail";
            this.listViewInvoiceDetail.Size = new System.Drawing.Size(401, 413);
            this.listViewInvoiceDetail.TabIndex = 0;
            this.listViewInvoiceDetail.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxStatus);
            this.groupBox3.Controls.Add(this.txtNameCus);
            this.groupBox3.Controls.Add(this.txtMadon);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nâng cao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tình trạng đơn hàng";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đang giao hàng",
            "Đã Thanh toán",
            "Hủy"});
            this.comboBoxStatus.Location = new System.Drawing.Point(7, 51);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(114, 21);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(256, 52);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(112, 20);
            this.txtNameCus.TabIndex = 1;
            // 
            // txtMadon
            // 
            this.txtMadon.Location = new System.Drawing.Point(127, 52);
            this.txtMadon.Name = "txtMadon";
            this.txtMadon.Size = new System.Drawing.Size(123, 20);
            this.txtMadon.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(456, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 21);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStatus);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtThanhtien);
            this.groupBox4.Location = new System.Drawing.Point(573, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 64);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(29, 22);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(96, 29);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Đổi trạng thái";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thành tiền";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhtien.Location = new System.Drawing.Point(245, 22);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(157, 29);
            this.txtThanhtien.TabIndex = 0;
            // 
            // QuanlyHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanlyHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewInvoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewInvoiceDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMadon;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Button btnReset;
    }
}