namespace QuestBankManager_Project
{
    partial class QuestBankManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestBankManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.find_tb = new System.Windows.Forms.TextBox();
            this.find_bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbinfo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.username_lb = new System.Windows.Forms.Label();
            this.access_bank_bt = new System.Windows.Forms.Button();
            this.add_bank_bt = new System.Windows.Forms.Button();
            this.delete_bank_bt = new System.Windows.Forms.Button();
            this.edit_bank_bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách ngân hàng:";
            // 
            // find_tb
            // 
            this.find_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_tb.Location = new System.Drawing.Point(204, 6);
            this.find_tb.Name = "find_tb";
            this.find_tb.Size = new System.Drawing.Size(133, 24);
            this.find_tb.TabIndex = 2;
            // 
            // find_bt
            // 
            this.find_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_bt.Image = ((System.Drawing.Image)(resources.GetObject("find_bt.Image")));
            this.find_bt.Location = new System.Drawing.Point(352, 6);
            this.find_bt.Name = "find_bt";
            this.find_bt.Size = new System.Drawing.Size(34, 25);
            this.find_bt.TabIndex = 3;
            this.find_bt.UseVisualStyleBackColor = true;
            this.find_bt.Click += new System.EventHandler(this.find_bt_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(489, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 24);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbinfo
            // 
            this.lbinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbinfo.AutoSize = true;
            this.lbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfo.Location = new System.Drawing.Point(633, 10);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(98, 20);
            this.lbinfo.TabIndex = 6;
            this.lbinfo.Text = "Người dùng: ";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(560, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Đăng xuất";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // username_lb
            // 
            this.username_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.Color.Red;
            this.username_lb.Location = new System.Drawing.Point(636, 34);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(88, 20);
            this.username_lb.TabIndex = 6;
            this.username_lb.Text = "username";
            // 
            // access_bank_bt
            // 
            this.access_bank_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.access_bank_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.access_bank_bt.Image = ((System.Drawing.Image)(resources.GetObject("access_bank_bt.Image")));
            this.access_bank_bt.Location = new System.Drawing.Point(585, 120);
            this.access_bank_bt.Name = "access_bank_bt";
            this.access_bank_bt.Size = new System.Drawing.Size(145, 47);
            this.access_bank_bt.TabIndex = 8;
            this.access_bank_bt.Text = "Truy cập";
            this.access_bank_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.access_bank_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.access_bank_bt.UseVisualStyleBackColor = true;
            this.access_bank_bt.Click += new System.EventHandler(this.access_bank_bt_Click);
            // 
            // add_bank_bt
            // 
            this.add_bank_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_bank_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bank_bt.Image = ((System.Drawing.Image)(resources.GetObject("add_bank_bt.Image")));
            this.add_bank_bt.Location = new System.Drawing.Point(585, 184);
            this.add_bank_bt.Name = "add_bank_bt";
            this.add_bank_bt.Size = new System.Drawing.Size(145, 47);
            this.add_bank_bt.TabIndex = 8;
            this.add_bank_bt.Text = "Thêm";
            this.add_bank_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_bank_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_bank_bt.UseVisualStyleBackColor = true;
            this.add_bank_bt.Click += new System.EventHandler(this.add_bank_bt_Click);
            // 
            // delete_bank_bt
            // 
            this.delete_bank_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_bank_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bank_bt.Image = ((System.Drawing.Image)(resources.GetObject("delete_bank_bt.Image")));
            this.delete_bank_bt.Location = new System.Drawing.Point(587, 309);
            this.delete_bank_bt.Name = "delete_bank_bt";
            this.delete_bank_bt.Size = new System.Drawing.Size(145, 47);
            this.delete_bank_bt.TabIndex = 8;
            this.delete_bank_bt.Text = "Xóa";
            this.delete_bank_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_bank_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_bank_bt.UseVisualStyleBackColor = true;
            this.delete_bank_bt.Click += new System.EventHandler(this.delete_bank_bt_Click);
            // 
            // edit_bank_bt
            // 
            this.edit_bank_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_bank_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_bank_bt.Image = ((System.Drawing.Image)(resources.GetObject("edit_bank_bt.Image")));
            this.edit_bank_bt.Location = new System.Drawing.Point(586, 246);
            this.edit_bank_bt.Name = "edit_bank_bt";
            this.edit_bank_bt.Size = new System.Drawing.Size(144, 47);
            this.edit_bank_bt.TabIndex = 9;
            this.edit_bank_bt.Text = "Sửa";
            this.edit_bank_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_bank_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_bank_bt.UseVisualStyleBackColor = true;
            this.edit_bank_bt.Click += new System.EventHandler(this.edit_bank_bt_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(588, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xuất";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "@YangKlee closebeta v2.2 Build time: 28/01/2025 \r\n";
            // 
            // QuestBankManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_bank_bt);
            this.Controls.Add(this.delete_bank_bt);
            this.Controls.Add(this.add_bank_bt);
            this.Controls.Add(this.access_bank_bt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.find_bt);
            this.Controls.Add(this.find_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuestBankManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ NGÂN HÀNG CÂU HỎI";
            this.Load += new System.EventHandler(this.QuestBankManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox find_tb;
        private System.Windows.Forms.Button find_bt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Button access_bank_bt;
        private System.Windows.Forms.Button add_bank_bt;
        private System.Windows.Forms.Button delete_bank_bt;
        private System.Windows.Forms.Button edit_bank_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}