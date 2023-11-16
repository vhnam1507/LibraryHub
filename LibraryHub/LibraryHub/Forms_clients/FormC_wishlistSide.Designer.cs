namespace LibraryHub.Forms_clients
{
    partial class FormC_wishlistSide
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm trong Wishlist của bạn \r\n(Mã sách, tên sách, tác giả, nxb,...)";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(256, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 32);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(12, 59);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(363, 35);
            this.txt_search.TabIndex = 0;
            // 
            // FormC_wishlistSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(387, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "FormC_wishlistSide";
            this.Text = "FormC_wishlistSide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}