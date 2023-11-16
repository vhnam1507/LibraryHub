namespace LibraryHub.Forms
{
    partial class Form_entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_entry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_entry = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_quotes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_entry.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐÂY LÀ BOOK HUB";
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(220, 464);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(167, 42);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_entry
            // 
            this.pnl_entry.Controls.Add(this.lbl_welcome);
            this.pnl_entry.Controls.Add(this.groupBox1);
            this.pnl_entry.Controls.Add(this.btn_go);
            this.pnl_entry.Controls.Add(this.btn_exit);
            this.pnl_entry.Controls.Add(this.label1);
            this.pnl_entry.Location = new System.Drawing.Point(12, 199);
            this.pnl_entry.Name = "pnl_entry";
            this.pnl_entry.Size = new System.Drawing.Size(868, 590);
            this.pnl_entry.TabIndex = 0;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(3, 32);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(862, 38);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome label";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_quotes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_quotes
            // 
            this.lbl_quotes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quotes.Location = new System.Drawing.Point(43, 18);
            this.lbl_quotes.Name = "lbl_quotes";
            this.lbl_quotes.Size = new System.Drawing.Size(776, 200);
            this.lbl_quotes.TabIndex = 0;
            this.lbl_quotes.Text = "QUOTES";
            this.lbl_quotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(862, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome label";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(862, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome label";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_go
            // 
            this.btn_go.AutoSize = true;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_go.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go.Location = new System.Drawing.Point(493, 464);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(167, 42);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "GO!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // Form_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(892, 801);
            this.Controls.Add(this.pnl_entry);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_entry.ResumeLayout(false);
            this.pnl_entry.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_entry;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_quotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}