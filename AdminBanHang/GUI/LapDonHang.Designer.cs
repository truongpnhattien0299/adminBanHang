namespace AdminBanHang.GUI
{
    partial class LapDonHang
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
            this.listViewData = new System.Windows.Forms.ListView();
            this.listViewSelect = new System.Windows.Forms.ListView();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnGiamSl = new System.Windows.Forms.Button();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.btnKhach = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.btnResetProduct = new System.Windows.Forms.Button();
            this.groupBoxCombo = new System.Windows.Forms.GroupBox();
            this.btnResetCombo = new System.Windows.Forms.Button();
            this.btnSearchCombo = new System.Windows.Forms.Button();
            this.txtSeachCombo = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBoxProduct.SuspendLayout();
            this.groupBoxCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(12, 167);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(639, 416);
            this.listViewData.TabIndex = 0;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.Click += new System.EventHandler(this.Listview_click);
            // 
            // listViewSelect
            // 
            this.listViewSelect.HideSelection = false;
            this.listViewSelect.Location = new System.Drawing.Point(704, 167);
            this.listViewSelect.Name = "listViewSelect";
            this.listViewSelect.Size = new System.Drawing.Size(413, 342);
            this.listViewSelect.TabIndex = 0;
            this.listViewSelect.UseCompatibleStateImageBehavior = false;
            this.listViewSelect.Click += new System.EventHandler(this.listView_select_click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(12, 12);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(89, 49);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(107, 12);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(89, 49);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(657, 273);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(41, 36);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = ">>";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnGiamSl
            // 
            this.btnGiamSl.Location = new System.Drawing.Point(657, 315);
            this.btnGiamSl.Name = "btnGiamSl";
            this.btnGiamSl.Size = new System.Drawing.Size(41, 36);
            this.btnGiamSl.TabIndex = 1;
            this.btnGiamSl.Text = "<<";
            this.btnGiamSl.UseVisualStyleBackColor = true;
            this.btnGiamSl.Click += new System.EventHandler(this.btnGiamSl_Click);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtThanhtien.Location = new System.Drawing.Point(934, 519);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(183, 29);
            this.txtThanhtien.TabIndex = 2;
            // 
            // btnKhach
            // 
            this.btnKhach.Location = new System.Drawing.Point(704, 519);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Size = new System.Drawing.Size(224, 64);
            this.btnKhach.TabIndex = 1;
            this.btnKhach.Text = "Thông tin Khách hàng";
            this.btnKhach.UseVisualStyleBackColor = true;
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(934, 554);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm Đơn hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(6, 37);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(161, 36);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBrand.TabIndex = 3;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(317, 38);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(100, 20);
            this.txtSearchProduct.TabIndex = 4;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(437, 36);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 5;
            this.btnSearchProduct.Text = "Tìm";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.comboBoxType);
            this.groupBoxProduct.Controls.Add(this.btnResetProduct);
            this.groupBoxProduct.Controls.Add(this.btnSearchProduct);
            this.groupBoxProduct.Controls.Add(this.comboBoxBrand);
            this.groupBoxProduct.Controls.Add(this.txtSearchProduct);
            this.groupBoxProduct.Location = new System.Drawing.Point(12, 67);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(639, 94);
            this.groupBoxProduct.TabIndex = 6;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Tìm Kiếm sản phẩm";
            // 
            // btnResetProduct
            // 
            this.btnResetProduct.Location = new System.Drawing.Point(533, 36);
            this.btnResetProduct.Name = "btnResetProduct";
            this.btnResetProduct.Size = new System.Drawing.Size(75, 23);
            this.btnResetProduct.TabIndex = 5;
            this.btnResetProduct.Text = "Reset";
            this.btnResetProduct.UseVisualStyleBackColor = true;
            this.btnResetProduct.Click += new System.EventHandler(this.btnResetProduct_Click);
            // 
            // groupBoxCombo
            // 
            this.groupBoxCombo.Controls.Add(this.dateEnd);
            this.groupBoxCombo.Controls.Add(this.dateStart);
            this.groupBoxCombo.Controls.Add(this.btnResetCombo);
            this.groupBoxCombo.Controls.Add(this.btnSearchCombo);
            this.groupBoxCombo.Controls.Add(this.txtSeachCombo);
            this.groupBoxCombo.Location = new System.Drawing.Point(12, 67);
            this.groupBoxCombo.Name = "groupBoxCombo";
            this.groupBoxCombo.Size = new System.Drawing.Size(403, 94);
            this.groupBoxCombo.TabIndex = 6;
            this.groupBoxCombo.TabStop = false;
            this.groupBoxCombo.Text = "Tìm kiếm Combo";
            // 
            // btnResetCombo
            // 
            this.btnResetCombo.Location = new System.Drawing.Point(315, 51);
            this.btnResetCombo.Name = "btnResetCombo";
            this.btnResetCombo.Size = new System.Drawing.Size(75, 23);
            this.btnResetCombo.TabIndex = 5;
            this.btnResetCombo.Text = "Reset";
            this.btnResetCombo.UseVisualStyleBackColor = true;
            this.btnResetCombo.Click += new System.EventHandler(this.btnResetCombo_Click);
            // 
            // btnSearchCombo
            // 
            this.btnSearchCombo.Location = new System.Drawing.Point(234, 51);
            this.btnSearchCombo.Name = "btnSearchCombo";
            this.btnSearchCombo.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCombo.TabIndex = 5;
            this.btnSearchCombo.Text = "Tìm";
            this.btnSearchCombo.UseVisualStyleBackColor = true;
            this.btnSearchCombo.Click += new System.EventHandler(this.btnSearchCombo_Click);
            // 
            // txtSeachCombo
            // 
            this.txtSeachCombo.Location = new System.Drawing.Point(234, 18);
            this.txtSeachCombo.Name = "txtSeachCombo";
            this.txtSeachCombo.Size = new System.Drawing.Size(156, 20);
            this.txtSeachCombo.TabIndex = 4;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 19);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 6;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(12, 56);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 6;
            // 
            // LapDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 592);
            this.Controls.Add(this.groupBoxCombo);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.btnGiamSl);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnKhach);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.listViewSelect);
            this.Controls.Add(this.listViewData);
            this.Name = "LapDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập đơn hàng";
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxCombo.ResumeLayout(false);
            this.groupBoxCombo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ListView listViewSelect;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnGiamSl;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button btnKhach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button btnResetProduct;
        private System.Windows.Forms.GroupBox groupBoxCombo;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btnResetCombo;
        private System.Windows.Forms.Button btnSearchCombo;
        private System.Windows.Forms.TextBox txtSeachCombo;
    }
}