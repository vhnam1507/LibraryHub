namespace LibraryHub.Forms
{
    partial class Form_editPassword
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newPass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(330, 123);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(403, 28);
            this.txt_password.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "Nhập mật khẩu hiện tại:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(631, 290);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 34);
            this.btn_cancel.TabIndex = 68;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(475, 290);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 34);
            this.btn_save.TabIndex = 67;
            this.btn_save.Text = "Hoàn tất";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 36);
            this.label2.TabIndex = 70;
            this.label2.Text = "ĐỔI MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // txt_newPass
            // 
            this.txt_newPass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_newPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPass.Location = new System.Drawing.Point(330, 175);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '●';
            this.txt_newPass.Size = new System.Drawing.Size(403, 28);
            this.txt_newPass.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txt_newPass2
            // 
            this.txt_newPass2.BackColor = System.Drawing.SystemColors.Info;
            this.txt_newPass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newPass2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPass2.Location = new System.Drawing.Point(330, 227);
            this.txt_newPass2.Name = "txt_newPass2";
            this.txt_newPass2.PasswordChar = '●';
            this.txt_newPass2.Size = new System.Drawing.Size(403, 28);
            this.txt_newPass2.TabIndex = 66;
            // 
            // Form_editPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_newPass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Name = "Form_editPassword";
            this.Text = "Form_editPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newPass2;
    }
}