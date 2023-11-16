namespace LibraryHub.Forms_admin
{
    partial class Form_myInfo
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pass = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(845, 557);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 34);
            this.btn_cancel.TabIndex = 103;
            this.btn_cancel.Text = "Huỷ";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(575, 557);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(264, 34);
            this.btn_save.TabIndex = 102;
            this.btn_save.Text = "Lưu thông tin chỉnh sửa";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(271, 557);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(252, 34);
            this.btn_edit.TabIndex = 101;
            this.btn_edit.Text = "Chỉnh sửa thông tin";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 36);
            this.label2.TabIndex = 104;
            this.label2.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // btn_pass
            // 
            this.btn_pass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pass.Location = new System.Drawing.Point(800, 451);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(149, 28);
            this.btn_pass.TabIndex = 100;
            this.btn_pass.Text = "Đổi mật khẩu";
            this.btn_pass.UseVisualStyleBackColor = true;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(135, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 24);
            this.label14.TabIndex = 105;
            this.label14.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "Mật khẩu:";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(272, 152);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(675, 28);
            this.txt_name.TabIndex = 91;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(273, 452);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(520, 28);
            this.txt_password.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(160, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 112;
            this.label12.Text = "UserID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 111;
            this.label7.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Info;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(272, 377);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(675, 28);
            this.txt_username.TabIndex = 95;
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(272, 302);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(675, 28);
            this.txt_userID.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Vai trò:";
            // 
            // txt_role
            // 
            this.txt_role.BackColor = System.Drawing.SystemColors.Info;
            this.txt_role.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_role.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Location = new System.Drawing.Point(273, 227);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(675, 28);
            this.txt_role.TabIndex = 92;
            // 
            // Form_myInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 716);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_myInfo";
            this.Text = "1070, 763";
            this.Load += new System.EventHandler(this.Form_myInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_role;
    }
}