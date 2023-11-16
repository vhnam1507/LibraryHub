namespace LibraryHub.Forms_clients
{
    partial class FormC_books
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
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_avail = new System.Windows.Forms.Button();
            this.btn_borrowed = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
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
            this.num_borrowing.Location = new System.Drawing.Point(838, 213);
            this.num_borrowing.Name = "num_borrowing";
            this.num_borrowing.Size = new System.Drawing.Size(107, 29);
            this.num_borrowing.TabIndex = 7;
            // 
            // num_onstock
            // 
            this.num_onstock.BackColor = System.Drawing.Color.LightCyan;
            this.num_onstock.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_onstock.Location = new System.Drawing.Point(455, 213);
            this.num_onstock.Name = "num_onstock";
            this.num_onstock.Size = new System.Drawing.Size(107, 29);
            this.num_onstock.TabIndex = 6;
            // 
            // num_total
            // 
            this.num_total.BackColor = System.Drawing.Color.Honeydew;
            this.num_total.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_total.Location = new System.Drawing.Point(124, 213);
            this.num_total.Name = "num_total";
            this.num_total.Size = new System.Drawing.Size(111, 29);
            this.num_total.TabIndex = 5;
            // 
            // txt_publisher
            // 
            this.txt_publisher.BackColor = System.Drawing.SystemColors.Info;
            this.txt_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_publisher.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_publisher.Location = new System.Drawing.Point(502, 114);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(539, 28);
            this.txt_publisher.TabIndex = 4;
            // 
            // txt_gen
            // 
            this.txt_gen.BackColor = System.Drawing.SystemColors.Info;
            this.txt_gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gen.Location = new System.Drawing.Point(107, 114);
            this.txt_gen.Name = "txt_gen";
            this.txt_gen.Size = new System.Drawing.Size(218, 28);
            this.txt_gen.TabIndex = 3;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.SystemColors.Info;
            this.txt_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_author.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_author.Location = new System.Drawing.Point(867, 19);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(174, 28);
            this.txt_author.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(455, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(265, 28);
            this.txt_name.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(107, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(218, 28);
            this.txt_id.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(781, 287);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(257, 37);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Thêm sách vào Wishlist";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_books.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_books.Location = new System.Drawing.Point(12, 330);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.ReadOnly = true;
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
            this.dgv_books.TabIndex = 12;
            this.dgv_books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "SL còn trên kệ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(622, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "SL đang được mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(779, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tác giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sách:";
            // 
            // btn_avail
            // 
            this.btn_avail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avail.Location = new System.Drawing.Point(338, 287);
            this.btn_avail.Name = "btn_avail";
            this.btn_avail.Size = new System.Drawing.Size(150, 37);
            this.btn_avail.TabIndex = 10;
            this.btn_avail.Text = "Sách còn hàng";
            this.btn_avail.UseVisualStyleBackColor = true;
            this.btn_avail.Click += new System.EventHandler(this.btn_avail_Click);
            // 
            // btn_borrowed
            // 
            this.btn_borrowed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrowed.Location = new System.Drawing.Point(118, 287);
            this.btn_borrowed.Name = "btn_borrowed";
            this.btn_borrowed.Size = new System.Drawing.Size(203, 37);
            this.btn_borrowed.TabIndex = 9;
            this.btn_borrowed.Text = "Sách từng mượn";
            this.btn_borrowed.UseVisualStyleBackColor = true;
            this.btn_borrowed.Click += new System.EventHandler(this.btn_borrowed_Click);
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.Location = new System.Drawing.Point(12, 287);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(89, 37);
            this.btn_all.TabIndex = 8;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // FormC_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1052, 716);
            this.Controls.Add(this.num_borrowing);
            this.Controls.Add(this.num_onstock);
            this.Controls.Add(this.num_total);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.txt_gen);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_borrowed);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_avail);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormC_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_books";
            this.Load += new System.EventHandler(this.FormC_books_Load);
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_avail;
        private System.Windows.Forms.Button btn_borrowed;
        private System.Windows.Forms.Button btn_all;
    }
}