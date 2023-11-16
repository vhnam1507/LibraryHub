namespace LibraryHub.Forms_admin
{
    partial class Form_readers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.num_total = new System.Windows.Forms.NumericUpDown();
            this.num_now = new System.Windows.Forms.NumericUpDown();
            this.num_done = new System.Windows.Forms.NumericUpDown();
            this.dgv_readers = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_resetPassword = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_now)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_done)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readers)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(608, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(432, 28);
            this.txt_name.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(891, 660);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 37);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Huỷ thay đổi";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(699, 660);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(176, 37);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Lưu thay đổi";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(437, 660);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(150, 37);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "Xoá độc giả";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(224, 660);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(202, 37);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Chỉnh sửa thông tin";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(13, 660);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(200, 37);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Thêm độc giả mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.Info;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(608, 70);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(432, 28);
            this.txt_address.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng mượn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(795, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đã trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hiện đang mượn:";
            // 
            // num_total
            // 
            this.num_total.BackColor = System.Drawing.Color.Honeydew;
            this.num_total.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_total.Location = new System.Drawing.Point(168, 225);
            this.num_total.Name = "num_total";
            this.num_total.Size = new System.Drawing.Size(122, 29);
            this.num_total.TabIndex = 9;
            // 
            // num_now
            // 
            this.num_now.BackColor = System.Drawing.Color.LightCyan;
            this.num_now.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_now.Location = new System.Drawing.Point(556, 225);
            this.num_now.Name = "num_now";
            this.num_now.Size = new System.Drawing.Size(122, 29);
            this.num_now.TabIndex = 10;
            // 
            // num_done
            // 
            this.num_done.BackColor = System.Drawing.Color.LavenderBlush;
            this.num_done.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_done.Location = new System.Drawing.Point(918, 220);
            this.num_done.Name = "num_done";
            this.num_done.Size = new System.Drawing.Size(122, 29);
            this.num_done.TabIndex = 11;
            // 
            // dgv_readers
            // 
            this.dgv_readers.AllowUserToAddRows = false;
            this.dgv_readers.AllowUserToDeleteRows = false;
            this.dgv_readers.AllowUserToResizeColumns = false;
            this.dgv_readers.AllowUserToResizeRows = false;
            this.dgv_readers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_readers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_readers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_readers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_readers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_readers.Location = new System.Drawing.Point(12, 277);
            this.dgv_readers.Name = "dgv_readers";
            this.dgv_readers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_readers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_readers.RowHeadersVisible = false;
            this.dgv_readers.RowHeadersWidth = 51;
            this.dgv_readers.RowTemplate.Height = 24;
            this.dgv_readers.Size = new System.Drawing.Size(1028, 357);
            this.dgv_readers.TabIndex = 17;
            this.dgv_readers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_readers_CellContentClick);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(168, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(269, 28);
            this.txt_id.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Info;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(168, 121);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(269, 28);
            this.txt_username.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(609, 121);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(432, 28);
            this.txt_email.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số điện thoại:";
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Info;
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(168, 172);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(269, 28);
            this.txt_phone.TabIndex = 6;
            // 
            // btn_resetPassword
            // 
            this.btn_resetPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetPassword.Location = new System.Drawing.Point(891, 167);
            this.btn_resetPassword.Name = "btn_resetPassword";
            this.btn_resetPassword.Size = new System.Drawing.Size(149, 37);
            this.btn_resetPassword.TabIndex = 8;
            this.btn_resetPassword.Text = "Reset mật khẩu";
            this.btn_resetPassword.UseVisualStyleBackColor = true;
            this.btn_resetPassword.Click += new System.EventHandler(this.btn_resetPassword_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(485, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mật khẩu:";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Info;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(608, 172);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(277, 28);
            this.txt_password.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Username:";
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(168, 70);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(269, 28);
            this.txt_userID.TabIndex = 2;
            // 
            // Form_readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1052, 716);
            this.Controls.Add(this.dgv_readers);
            this.Controls.Add(this.num_done);
            this.Controls.Add(this.num_now);
            this.Controls.Add(this.num_total);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_resetPassword);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_readers";
            this.Text = "Form_Users";
            this.Load += new System.EventHandler(this.Form_readers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_now)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_done)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_total;
        private System.Windows.Forms.NumericUpDown num_now;
        private System.Windows.Forms.NumericUpDown num_done;
        private System.Windows.Forms.DataGridView dgv_readers;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_resetPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_userID;
    }
}