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
            this.btnSanPham.Location = new System.Drawing.Point(44, 89);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(89, 49);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(139, 89);
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
            this.txtThanhtien.Location = new System.Drawing.Point(957, 519);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(160, 29);
            this.txtThanhtien.TabIndex = 2;
            // 
            // btnKhach
            // 
            this.btnKhach.Location = new System.Drawing.Point(957, 554);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.Size = new System.Drawing.Size(160, 29);
            this.btnKhach.TabIndex = 1;
            this.btnKhach.Text = "Thông tin Khách hàng";
            this.btnKhach.UseVisualStyleBackColor = true;
            this.btnKhach.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // LapDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 592);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.btnGiamSl);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnKhach);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.listViewSelect);
            this.Controls.Add(this.listViewData);
            this.Name = "LapDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập đơn hàng";
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
    }
}