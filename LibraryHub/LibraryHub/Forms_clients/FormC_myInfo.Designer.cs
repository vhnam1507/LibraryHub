namespace LibraryHub.Forms_clients
{
    partial class FormC_myInfo
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_pass = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_readerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(253, 616);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(252, 34);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Chỉnh sửa thông tin";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Địa chỉ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 24);
            this.label14.TabIndex = 60;
            this.label14.Text = "Họ và tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 24);
            this.label9.TabIndex = 78;
            this.label9.Text = "Số điện thoại:";
            // 
            // btn_pass
            // 
            this.btn_pass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pass.Location = new System.Drawing.Point(780, 533);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(149, 28);
            this.btn_pass.TabIndex = 9;
            this.btn_pass.Text = "Đổi mật khẩu";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(253, 118);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(675, 28);
            this.txt_name.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(253, 534);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(520, 28);
            this.txt_password.TabIndex = 8;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.Info;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(253, 378);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(675, 28);
            this.txt_address.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(254, 430);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(675, 28);
            this.txt_email.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Info;
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(253, 482);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(675, 28);
            this.txt_phone.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(557, 616);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(264, 34);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Lưu thông tin chỉnh sửa";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(254, 274);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(675, 28);
            this.txt_userID.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Info;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(254, 326);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(675, 28);
            this.txt_username.TabIndex = 4;
            // 
            // txt_readerID
            // 
            this.txt_readerID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_readerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_readerID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_readerID.Location = new System.Drawing.Point(254, 222);
            this.txt_readerID.Name = "txt_readerID";
            this.txt_readerID.ReadOnly = true;
            this.txt_readerID.Size = new System.Drawing.Size(675, 28);
            this.txt_readerID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 87;
            this.label7.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 88;
            this.label12.Text = "UserID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(107, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 24);
            this.label13.TabIndex = 86;
            this.label13.Text = "Mã độc giả:";
            // 
            // txt_role
            // 
            this.txt_role.BackColor = System.Drawing.SystemColors.Info;
            this.txt_role.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_role.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Location = new System.Drawing.Point(254, 170);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(675, 28);
            this.txt_role.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Vai trò:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(827, 616);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 34);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormC_myInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 716);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_readerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.label2);
            this.Name = "FormC_myInfo";
            this.Text = "FormC_myInfo";
            this.Load += new System.EventHandler(this.FormC_myInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_readerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
    }
}