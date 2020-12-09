namespace AdminBanHang.GUI
{
    partial class QuanlyProduct
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
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSearchCategory = new System.Windows.Forms.ComboBox();
            this.comboSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNameImage = new System.Windows.Forms.Label();
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(351, 75);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(635, 389);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.Click += new System.EventHandler(this.Click_listview);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSearchCategory);
            this.groupBox1.Controls.Add(this.comboSearchType);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(351, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm nâng cao";
            // 
            // comboSearchCategory
            // 
            this.comboSearchCategory.FormattingEnabled = true;
            this.comboSearchCategory.Location = new System.Drawing.Point(140, 23);
            this.comboSearchCategory.Name = "comboSearchCategory";
            this.comboSearchCategory.Size = new System.Drawing.Size(86, 21);
            this.comboSearchCategory.TabIndex = 30;
            // 
            // comboSearchType
            // 
            this.comboSearchType.FormattingEnabled = true;
            this.comboSearchType.Location = new System.Drawing.Point(25, 23);
            this.comboSearchType.Name = "comboSearchType";
            this.comboSearchType.Size = new System.Drawing.Size(93, 21);
            this.comboSearchType.TabIndex = 30;
            this.comboSearchType.SelectedIndexChanged += new System.EventHandler(this.comboSearchType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(449, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(255, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblNameImage);
            this.groupBox2.Controls.Add(this.previewImage);
            this.groupBox2.Controls.Add(this.comboType);
            this.groupBox2.Controls.Add(this.comboCategory);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtDetail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.price);
            this.groupBox2.Controls.Add(this.amount);
            this.groupBox2.Controls.Add(this.txtProductname);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 451);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nhà Sản Xuất";
            // 
            // lblNameImage
            // 
            this.lblNameImage.AutoSize = true;
            this.lblNameImage.Location = new System.Drawing.Point(106, 96);
            this.lblNameImage.MaximumSize = new System.Drawing.Size(120, 50);
            this.lblNameImage.Name = "lblNameImage";
            this.lblNameImage.Size = new System.Drawing.Size(68, 13);
            this.lblNameImage.TabIndex = 32;
            this.lblNameImage.Text = "Chưa có ảnh";
            // 
            // previewImage
            // 
            this.previewImage.Location = new System.Drawing.Point(228, 62);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(70, 70);
            this.previewImage.TabIndex = 31;
            this.previewImage.TabStop = false;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(109, 242);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(194, 21);
            this.comboType.TabIndex = 30;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(109, 284);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(194, 21);
            this.comboCategory.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(228, 396);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(125, 396);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 45);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 396);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 45);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(109, 326);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(194, 56);
            this.txtDetail.TabIndex = 26;
            this.txtDetail.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mô tả chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(109, 198);
            this.price.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(194, 20);
            this.price.TabIndex = 18;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(109, 155);
            this.amount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(194, 20);
            this.amount.TabIndex = 19;
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(109, 26);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(194, 20);
            this.txtProductname.TabIndex = 16;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(109, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(538, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 27);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // QuanlyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewProduct);
            this.Name = "QuanlyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanlyProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox txtDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboSearchType;
        private System.Windows.Forms.Label lblNameImage;
        private System.Windows.Forms.PictureBox previewImage;
        private System.Windows.Forms.ComboBox comboSearchCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnReset;
    }
}