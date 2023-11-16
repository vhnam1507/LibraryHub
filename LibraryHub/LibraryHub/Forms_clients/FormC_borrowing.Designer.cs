namespace LibraryHub.Forms_clients
{
    partial class FormC_borrowing
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
            this.dgv_borrow = new System.Windows.Forms.DataGridView();
            this.rad_notyet = new System.Windows.Forms.RadioButton();
            this.rad_done = new System.Windows.Forms.RadioButton();
            this.lst_books = new System.Windows.Forms.ListBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.txt_readerID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_late = new System.Windows.Forms.Button();
            this.btn_notyet = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_borrow
            // 
            this.dgv_borrow.AllowUserToAddRows = false;
            this.dgv_borrow.AllowUserToDeleteRows = false;
            this.dgv_borrow.AllowUserToResizeColumns = false;
            this.dgv_borrow.AllowUserToResizeRows = false;
            this.dgv_borrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_borrow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_borrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_borrow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_borrow.Location = new System.Drawing.Point(12, 347);
            this.dgv_borrow.Name = "dgv_borrow";
            this.dgv_borrow.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_borrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_borrow.RowHeadersVisible = false;
            this.dgv_borrow.RowHeadersWidth = 51;
            this.dgv_borrow.RowTemplate.Height = 24;
            this.dgv_borrow.Size = new System.Drawing.Size(1028, 322);
            this.dgv_borrow.TabIndex = 11;
            this.dgv_borrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_borrow_CellContentClick);
            // 
            // rad_notyet
            // 
            this.rad_notyet.AutoSize = true;
            this.rad_notyet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_notyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rad_notyet.Location = new System.Drawing.Point(920, 244);
            this.rad_notyet.Name = "rad_notyet";
            this.rad_notyet.Size = new System.Drawing.Size(104, 25);
            this.rad_notyet.TabIndex = 6;
            this.rad_notyet.TabStop = true;
            this.rad_notyet.Text = "Chưa trả";
            this.rad_notyet.UseVisualStyleBackColor = true;
            // 
            // rad_done
            // 
            this.rad_done.AutoSize = true;
            this.rad_done.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_done.ForeColor = System.Drawing.Color.Green;
            this.rad_done.Location = new System.Drawing.Point(786, 244);
            this.rad_done.Name = "rad_done";
            this.rad_done.Size = new System.Drawing.Size(83, 25);
            this.rad_done.TabIndex = 5;
            this.rad_done.TabStop = true;
            this.rad_done.Text = "Đã trả";
            this.rad_done.UseVisualStyleBackColor = true;
            // 
            // lst_books
            // 
            this.lst_books.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_books.FormattingEnabled = true;
            this.lst_books.ItemHeight = 18;
            this.lst_books.Location = new System.Drawing.Point(16, 96);
            this.lst_books.Name = "lst_books";
            this.lst_books.Size = new System.Drawing.Size(542, 220);
            this.lst_books.TabIndex = 12;
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_end.Location = new System.Drawing.Point(727, 199);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(301, 28);
            this.dtp_end.TabIndex = 4;
            // 
            // dtp_start
            // 
            this.dtp_start.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Location = new System.Drawing.Point(726, 149);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(301, 28);
            this.dtp_start.TabIndex = 3;
            // 
            // txt_readerID
            // 
            this.txt_readerID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_readerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_readerID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_readerID.Location = new System.Drawing.Point(605, 47);
            this.txt_readerID.Name = "txt_readerID";
            this.txt_readerID.Size = new System.Drawing.Size(422, 28);
            this.txt_readerID.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(606, 96);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(422, 28);
            this.txt_name.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(141, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(270, 28);
            this.txt_id.TabIndex = 0;
            // 
            // btn_late
            // 
            this.btn_late.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_late.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_late.Location = new System.Drawing.Point(830, 304);
            this.btn_late.Name = "btn_late";
            this.btn_late.Size = new System.Drawing.Size(106, 37);
            this.btn_late.TabIndex = 9;
            this.btn_late.Text = "Quá hạn";
            this.btn_late.UseVisualStyleBackColor = true;
            this.btn_late.Click += new System.EventHandler(this.btn_late_Click);
            // 
            // btn_notyet
            // 
            this.btn_notyet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_notyet.Location = new System.Drawing.Point(712, 304);
            this.btn_notyet.Name = "btn_notyet";
            this.btn_notyet.Size = new System.Drawing.Size(106, 37);
            this.btn_notyet.TabIndex = 8;
            this.btn_notyet.Text = "Chưa trả";
            this.btn_notyet.UseVisualStyleBackColor = true;
            this.btn_notyet.Click += new System.EventHandler(this.btn_notyet_Click);
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.Location = new System.Drawing.Point(948, 304);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(80, 37);
            this.btn_all.TabIndex = 10;
            this.btn_all.Text = "ALL";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_done
            // 
            this.btn_done.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.Green;
            this.btn_done.Location = new System.Drawing.Point(594, 304);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(106, 37);
            this.btn_done.TabIndex = 7;
            this.btn_done.Text = "Đã trả";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "Hạn trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Người mượn:";
            // 
            // FormC_borrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1052, 716);
            this.Controls.Add(this.dgv_borrow);
            this.Controls.Add(this.rad_notyet);
            this.Controls.Add(this.rad_done);
            this.Controls.Add(this.lst_books);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.txt_readerID);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_late);
            this.Controls.Add(this.btn_notyet);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormC_borrowing";
            this.Text = "FormC_borrowing";
            this.Load += new System.EventHandler(this.FormC_borrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_borrow;
        private System.Windows.Forms.RadioButton rad_notyet;
        private System.Windows.Forms.RadioButton rad_done;
        private System.Windows.Forms.ListBox lst_books;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.TextBox txt_readerID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_late;
        private System.Windows.Forms.Button btn_notyet;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}