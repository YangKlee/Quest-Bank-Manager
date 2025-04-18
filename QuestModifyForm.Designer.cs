namespace QuestBankManager_Project
{
    partial class QuestModifyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.socauhientai_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noidung_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dapanA_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dapanB_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dapanC_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dapanD_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.a_rd = new System.Windows.Forms.RadioButton();
            this.b_rd = new System.Windows.Forms.RadioButton();
            this.c_rd = new System.Windows.Forms.RadioButton();
            this.d_rd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.auto_next_quest = new System.Windows.Forms.CheckBox();
            this.auto_increase = new System.Windows.Forms.CheckBox();
            this.total_num_quest_tx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.smart_cp_cb = new System.Windows.Forms.CheckBox();
            this.prev_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số câu:";
            // 
            // socauhientai_tb
            // 
            this.socauhientai_tb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.socauhientai_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socauhientai_tb.Location = new System.Drawing.Point(105, 36);
            this.socauhientai_tb.Name = "socauhientai_tb";
            this.socauhientai_tb.Size = new System.Drawing.Size(99, 29);
            this.socauhientai_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung:";
            // 
            // noidung_tb
            // 
            this.noidung_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noidung_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noidung_tb.Location = new System.Drawing.Point(106, 88);
            this.noidung_tb.Multiline = true;
            this.noidung_tb.Name = "noidung_tb";
            this.noidung_tb.Size = new System.Drawing.Size(916, 109);
            this.noidung_tb.TabIndex = 3;
            this.noidung_tb.Click += new System.EventHandler(this.noidung_tb_Click);
            this.noidung_tb.TextChanged += new System.EventHandler(this.noidung_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đáp án A:";
            // 
            // dapanA_tb
            // 
            this.dapanA_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dapanA_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dapanA_tb.Location = new System.Drawing.Point(106, 220);
            this.dapanA_tb.Multiline = true;
            this.dapanA_tb.Name = "dapanA_tb";
            this.dapanA_tb.Size = new System.Drawing.Size(912, 60);
            this.dapanA_tb.TabIndex = 3;
            this.dapanA_tb.Click += new System.EventHandler(this.dapanA_tb_Click);
            this.dapanA_tb.TextChanged += new System.EventHandler(this.dapanA_tb_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đáp án B:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dapanB_tb
            // 
            this.dapanB_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dapanB_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dapanB_tb.Location = new System.Drawing.Point(106, 306);
            this.dapanB_tb.Multiline = true;
            this.dapanB_tb.Name = "dapanB_tb";
            this.dapanB_tb.Size = new System.Drawing.Size(912, 61);
            this.dapanB_tb.TabIndex = 3;
            this.dapanB_tb.Click += new System.EventHandler(this.dapanB_tb_Click);
            this.dapanB_tb.TextChanged += new System.EventHandler(this.dapanB_tb_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đáp án C:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dapanC_tb
            // 
            this.dapanC_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dapanC_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dapanC_tb.Location = new System.Drawing.Point(106, 387);
            this.dapanC_tb.Multiline = true;
            this.dapanC_tb.Name = "dapanC_tb";
            this.dapanC_tb.Size = new System.Drawing.Size(912, 61);
            this.dapanC_tb.TabIndex = 3;
            this.dapanC_tb.Click += new System.EventHandler(this.dapanC_tb_Click);
            this.dapanC_tb.TextChanged += new System.EventHandler(this.dapanC_tb_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đáp án D:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dapanD_tb
            // 
            this.dapanD_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dapanD_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dapanD_tb.Location = new System.Drawing.Point(106, 467);
            this.dapanD_tb.Multiline = true;
            this.dapanD_tb.Name = "dapanD_tb";
            this.dapanD_tb.Size = new System.Drawing.Size(912, 61);
            this.dapanD_tb.TabIndex = 3;
            this.dapanD_tb.Click += new System.EventHandler(this.dapanD_tb_Click);
            this.dapanD_tb.TextChanged += new System.EventHandler(this.dapanD_tb_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chọn đáp án đúng:";
            // 
            // a_rd
            // 
            this.a_rd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.a_rd.AutoSize = true;
            this.a_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_rd.Location = new System.Drawing.Point(177, 565);
            this.a_rd.Name = "a_rd";
            this.a_rd.Size = new System.Drawing.Size(39, 24);
            this.a_rd.TabIndex = 5;
            this.a_rd.TabStop = true;
            this.a_rd.Text = "A";
            this.a_rd.UseVisualStyleBackColor = true;
            this.a_rd.CheckedChanged += new System.EventHandler(this.a_rd_CheckedChanged);
            // 
            // b_rd
            // 
            this.b_rd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_rd.AutoSize = true;
            this.b_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rd.Location = new System.Drawing.Point(222, 565);
            this.b_rd.Name = "b_rd";
            this.b_rd.Size = new System.Drawing.Size(39, 24);
            this.b_rd.TabIndex = 5;
            this.b_rd.TabStop = true;
            this.b_rd.Text = "B";
            this.b_rd.UseVisualStyleBackColor = true;
            this.b_rd.CheckedChanged += new System.EventHandler(this.b_rd_CheckedChanged);
            // 
            // c_rd
            // 
            this.c_rd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c_rd.AutoSize = true;
            this.c_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_rd.Location = new System.Drawing.Point(267, 565);
            this.c_rd.Name = "c_rd";
            this.c_rd.Size = new System.Drawing.Size(39, 24);
            this.c_rd.TabIndex = 5;
            this.c_rd.TabStop = true;
            this.c_rd.Text = "C";
            this.c_rd.UseVisualStyleBackColor = true;
            this.c_rd.CheckedChanged += new System.EventHandler(this.c_rd_CheckedChanged);
            // 
            // d_rd
            // 
            this.d_rd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.d_rd.AutoSize = true;
            this.d_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_rd.Location = new System.Drawing.Point(312, 565);
            this.d_rd.Name = "d_rd";
            this.d_rd.Size = new System.Drawing.Size(40, 24);
            this.d_rd.TabIndex = 5;
            this.d_rd.TabStop = true;
            this.d_rd.Text = "D";
            this.d_rd.UseVisualStyleBackColor = true;
            this.d_rd.CheckedChanged += new System.EventHandler(this.d_rd_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(886, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // auto_next_quest
            // 
            this.auto_next_quest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.auto_next_quest.AutoSize = true;
            this.auto_next_quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto_next_quest.Location = new System.Drawing.Point(595, 574);
            this.auto_next_quest.Name = "auto_next_quest";
            this.auto_next_quest.Size = new System.Drawing.Size(285, 22);
            this.auto_next_quest.TabIndex = 7;
            this.auto_next_quest.Text = "Lưu và tự động chuyển sang câu kế tiếp";
            this.auto_next_quest.UseVisualStyleBackColor = true;
            this.auto_next_quest.CheckedChanged += new System.EventHandler(this.auto_next_quest_CheckedChanged);
            // 
            // auto_increase
            // 
            this.auto_increase.AutoSize = true;
            this.auto_increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto_increase.Location = new System.Drawing.Point(222, 40);
            this.auto_increase.Name = "auto_increase";
            this.auto_increase.Size = new System.Drawing.Size(113, 22);
            this.auto_increase.TabIndex = 8;
            this.auto_increase.Text = "Tự động tăng";
            this.auto_increase.UseVisualStyleBackColor = true;
            // 
            // total_num_quest_tx
            // 
            this.total_num_quest_tx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total_num_quest_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_num_quest_tx.ForeColor = System.Drawing.Color.Red;
            this.total_num_quest_tx.Location = new System.Drawing.Point(796, 33);
            this.total_num_quest_tx.Name = "total_num_quest_tx";
            this.total_num_quest_tx.Size = new System.Drawing.Size(181, 34);
            this.total_num_quest_tx.TabIndex = 10;
            this.total_num_quest_tx.Text = "num";
            this.total_num_quest_tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(665, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tổng số câu hỏi:";
            // 
            // smart_cp_cb
            // 
            this.smart_cp_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.smart_cp_cb.AutoSize = true;
            this.smart_cp_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smart_cp_cb.Location = new System.Drawing.Point(465, 40);
            this.smart_cp_cb.Name = "smart_cp_cb";
            this.smart_cp_cb.Size = new System.Drawing.Size(167, 22);
            this.smart_cp_cb.TabIndex = 11;
            this.smart_cp_cb.Text = "Sao chép thông minh";
            this.smart_cp_cb.UseVisualStyleBackColor = true;
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(680, 545);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(75, 23);
            this.prev_btn.TabIndex = 12;
            this.prev_btn.Text = "prev";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(770, 545);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 12;
            this.next_btn.Text = "next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // QuestModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1055, 608);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.smart_cp_cb);
            this.Controls.Add(this.total_num_quest_tx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.auto_increase);
            this.Controls.Add(this.auto_next_quest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.d_rd);
            this.Controls.Add(this.c_rd);
            this.Controls.Add(this.b_rd);
            this.Controls.Add(this.a_rd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dapanD_tb);
            this.Controls.Add(this.dapanC_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dapanB_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dapanA_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noidung_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.socauhientai_tb);
            this.Controls.Add(this.label1);
            this.Name = "QuestModifyForm";
            this.Text = "QuestModifyForm";
            this.Load += new System.EventHandler(this.QuestModifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox socauhientai_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noidung_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dapanA_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dapanB_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dapanC_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dapanD_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton a_rd;
        private System.Windows.Forms.RadioButton b_rd;
        private System.Windows.Forms.RadioButton c_rd;
        private System.Windows.Forms.RadioButton d_rd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox auto_next_quest;
        private System.Windows.Forms.CheckBox auto_increase;
        private System.Windows.Forms.Label total_num_quest_tx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox smart_cp_cb;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Button next_btn;
    }
}