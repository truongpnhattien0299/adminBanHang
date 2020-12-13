namespace AdminBanHang.GUI
{
    partial class Dashboard
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
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnQLCB = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLHĐ = new System.Windows.Forms.Button();
            this.btnNewDH = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLSP
            // 
            this.btnQLSP.Location = new System.Drawing.Point(37, 44);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(100, 64);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLCB
            // 
            this.btnQLCB.Location = new System.Drawing.Point(198, 44);
            this.btnQLCB.Name = "btnQLCB";
            this.btnQLCB.Size = new System.Drawing.Size(108, 64);
            this.btnQLCB.TabIndex = 1;
            this.btnQLCB.Text = "Quản lý Combo";
            this.btnQLCB.UseVisualStyleBackColor = true;
            this.btnQLCB.Click += new System.EventHandler(this.btnQLCB_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(37, 161);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(100, 57);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản lý Khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(198, 161);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(108, 57);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý Nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLHĐ
            // 
            this.btnQLHĐ.Location = new System.Drawing.Point(37, 276);
            this.btnQLHĐ.Name = "btnQLHĐ";
            this.btnQLHĐ.Size = new System.Drawing.Size(100, 57);
            this.btnQLHĐ.TabIndex = 1;
            this.btnQLHĐ.Text = "Quản lý hóa đơn";
            this.btnQLHĐ.UseVisualStyleBackColor = true;
            this.btnQLHĐ.Click += new System.EventHandler(this.btnQLHĐ_Click);
            // 
            // btnNewDH
            // 
            this.btnNewDH.Location = new System.Drawing.Point(198, 276);
            this.btnNewDH.Name = "btnNewDH";
            this.btnNewDH.Size = new System.Drawing.Size(108, 57);
            this.btnNewDH.TabIndex = 1;
            this.btnNewDH.Text = "Tạo đơn hàng mới";
            this.btnNewDH.UseVisualStyleBackColor = true;
            this.btnNewDH.Click += new System.EventHandler(this.btnNewDH_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(394, 161);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(108, 57);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 365);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnNewDH);
            this.Controls.Add(this.btnQLHĐ);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQLCB);
            this.Controls.Add(this.btnQLSP);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLCB;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLHĐ;
        private System.Windows.Forms.Button btnNewDH;
        private System.Windows.Forms.Button btnThongKe;
    }
}