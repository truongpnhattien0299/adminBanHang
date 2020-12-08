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
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(12, 278);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(776, 160);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            // 
            // QuanlyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewProduct);
            this.Name = "QuanlyProduct";
            this.Text = "QuanlyProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduct;
    }
}