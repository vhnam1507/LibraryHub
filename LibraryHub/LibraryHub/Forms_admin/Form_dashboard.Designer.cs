namespace LibraryHub.Forms_admin
{
    partial class Form_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dashboard));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_readers = new System.Windows.Forms.Button();
            this.btn_books = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_side = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pictureBox2);
            this.pnl_main.Location = new System.Drawing.Point(412, 121);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1048, 706);
            this.pnl_main.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.btn_report);
            this.panel2.Controls.Add(this.btn_borrow);
            this.panel2.Controls.Add(this.btn_readers);
            this.panel2.Controls.Add(this.btn_books);
            this.panel2.Location = new System.Drawing.Point(412, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 108);
            this.panel2.TabIndex = 0;
            // 
            // btn_report
            // 
            this.btn_report.AutoSize = true;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_report.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_report.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_report.Location = new System.Drawing.Point(799, 13);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(223, 78);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "Tài khoản";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.AutoSize = true;
            this.btn_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_borrow.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_borrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_borrow.Location = new System.Drawing.Point(538, 13);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(223, 78);
            this.btn_borrow.TabIndex = 2;
            this.btn_borrow.Text = "Phiếu mượn";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // btn_readers
            // 
            this.btn_readers.AutoSize = true;
            this.btn_readers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_readers.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_readers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_readers.Location = new System.Drawing.Point(277, 13);
            this.btn_readers.Name = "btn_readers";
            this.btn_readers.Size = new System.Drawing.Size(223, 78);
            this.btn_readers.TabIndex = 1;
            this.btn_readers.Text = "Độc giả";
            this.btn_readers.UseVisualStyleBackColor = true;
            this.btn_readers.Click += new System.EventHandler(this.btn_readers_Click);
            // 
            // btn_books
            // 
            this.btn_books.AutoSize = true;
            this.btn_books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_books.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_books.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_books.Location = new System.Drawing.Point(16, 13);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(223, 78);
            this.btn_books.TabIndex = 0;
            this.btn_books.Text = "Tủ sách";
            this.btn_books.UseVisualStyleBackColor = true;
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.pnl_side);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 820);
            this.panel1.TabIndex = 1;
            // 
            // pnl_side
            // 
            this.pnl_side.Location = new System.Drawing.Point(6, 114);
            this.pnl_side.Name = "pnl_side";
            this.pnl_side.Size = new System.Drawing.Size(391, 653);
            this.pnl_side.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_logout.Location = new System.Drawing.Point(3, 773);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(394, 42);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(161, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(748, 316);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 834);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dashboard";
            this.pnl_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_readers;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_side;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}