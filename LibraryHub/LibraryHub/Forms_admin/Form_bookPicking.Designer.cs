namespace LibraryHub.Forms_admin
{
    partial class Form_bookPicking
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
            this.num_borrowing = new System.Windows.Forms.NumericUpDown();
            this.num_onstock = new System.Windows.Forms.NumericUpDown();
            this.num_total = new System.Windows.Forms.NumericUpDown();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.txt_gen = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_borrowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_onstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // num_borrowing
            // 
            this.num_borrowing.BackColor = System.Drawing.Color.LavenderBlush;
            this.num_borrowing.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_borrowing.Location = new System.Drawing.Point(860, 196);
            this.num_borrowing.Name = "num_borrowing";
            this.num_borrowing.Size = new System.Drawing.Size(107, 29);
            this.num_borrowing.TabIndex = 8;
            // 
            // num_onstock
            // 
            this.num_onstock.BackColor = System.Drawing.Color.LightCyan;
            this.num_onstock.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_onstock.Location = new System.Drawing.Point(477, 196);
            this.num_onstock.Name = "num_onstock";
            this.num_onstock.Size = new System.Drawing.Size(107, 29);
            this.num_onstock.TabIndex = 7;
            // 
            // num_total
            // 
            this.num_total.BackColor = System.Drawing.Color.Honeydew;
            this.num_total.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_total.Location = new System.Drawing.Point(146, 196);
            this.num_total.Name = "num_total";
            this.num_total.Size = new System.Drawing.Size(111, 29);
            this.num_total.TabIndex = 6;
            // 
            // txt_publisher
            // 
            this.txt_publisher.BackColor = System.Drawing.SystemColors.Info;
            this.txt_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_publisher.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_publisher.Location = new System.Drawing.Point(522, 139);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(539, 28);
            this.txt_publisher.TabIndex = 5;
            // 
            // txt_gen
            // 
            this.txt_gen.BackColor = System.Drawing.SystemColors.Info;
            this.txt_gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gen.Location = new System.Drawing.Point(127, 139);
            this.txt_gen.Name = "txt_gen";
            this.txt_gen.Size = new System.Drawing.Size(218, 28);
            this.txt_gen.TabIndex = 4;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.SystemColors.Info;
            this.txt_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_author.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(887, 88);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(174, 28);
            this.txt_author.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(475, 88);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(265, 28);
            this.txt_name.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(127, 88);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(218, 28);
            this.txt_id.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(765, 645);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(298, 37);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "Hoàn tất chọn sách!";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // dgv_books
            // 
            this.dgv_books.AllowUserToAddRows = false;
            this.dgv_books.AllowUserToDeleteRows = false;
            this.dgv_books.AllowUserToResizeColumns = false;
            this.dgv_books.AllowUserToResizeRows = false;
            this.dgv_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_books.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_books.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_books.Location = new System.Drawing.Point(35, 268);
            this.dgv_books.Name = "dgv_books";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_books.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_books.RowHeadersVisible = false;
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.Size = new System.Drawing.Size(1028, 357);
            this.dgv_books.TabIndex = 9;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // Check
            // 
            this.Check.HeaderText = "Chọn";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "SL còn trên kệ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "SL đang được mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(799, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tác giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tìm kiếm sách:";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Info;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(200, 29);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(708, 28);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(942, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 32);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 652);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Số sách đã chọn:";
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.SystemColors.Info;
            this.txt_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_count.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(241, 650);
            this.txt_count.Name = "txt_count";
            this.txt_count.ReadOnly = true;
            this.txt_count.Size = new System.Drawing.Size(72, 32);
            this.txt_count.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(317, 652);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 28);
            this.label11.TabIndex = 28;
            this.label11.Text = "/5";
            // 
            // Form_bookPicking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 722);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.num_borrowing);
            this.Controls.Add(this.num_onstock);
            this.Controls.Add(this.num_total);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_gen);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_bookPicking";
            this.Text = "Chọn sách cho phiếu mượn";
            this.Load += new System.EventHandler(this.Form_bookPicking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_borrowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_onstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_borrowing;
        private System.Windows.Forms.NumericUpDown num_onstock;
        private System.Windows.Forms.NumericUpDown num_total;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.TextBox txt_gen;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label11;
    }
}