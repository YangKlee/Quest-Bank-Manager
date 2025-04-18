using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestBankManager_Project
{
    public partial class QuestModifyForm : Form
    {
        public QuestModifyForm()
        {
            InitializeComponent();
        }
        string dapAnDung = null;
        string chuanHoaText(string s)
        {
            string res = s.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", "");
            return res;
        }
        public void reloadUI()
        {
            if (auto_increase.Checked)
            {
                socauhientai_tb.Text = (Int32.Parse(socauhientai_tb.Text) + 1).ToString();
            }
            else 
                socauhientai_tb.Text = null;
            noidung_tb.Text = null;
            dapanA_tb.Text = null;  
            dapanB_tb.Text = null;
            dapanC_tb.Text = null;
            dapanD_tb.Text = null;
            a_rd.Checked = false;
            b_rd.Checked = false;
            c_rd.Checked = false;
            d_rd.Checked = false;
            updateNumQuest();
        }
        public void updateNumQuest()
        {
            SQLConnection conn = new SQLConnection();
            try
            {
                MySqlCommand cmd =
                    new MySqlCommand("select count(*) from question where idbank = @idbank", conn.getConnection());
                cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                object socau = cmd.ExecuteScalar();
                if (socau != null)
                {
                    total_num_quest_tx.Text = Convert.ToString(socau);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn tới máy chủ!" + ex.Message, "Lỗi nè", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            conn.closeConnection();
        }
        private void QuestModifyForm_Load(object sender, EventArgs e)
        {
            if (QuestManager.isEditable == 0)
            {
                this.Text = "Thêm câu hỏi";
                if (!auto_next_quest.Checked)
                {
                    auto_increase.Enabled = false;
                    auto_increase.Checked = false;
                }
                else
                {
                    auto_increase.Enabled = true;
                }
                prev_btn.Visible = false;
                next_btn.Visible = false;
            }
            else if(QuestManager.isEditable == 1)
            {
                this.Text = "Sửa câu hỏi";
                socauhientai_tb.Enabled = false;
                auto_increase.Visible = false;
                auto_next_quest.Visible = false;
                smart_cp_cb.Visible = false;
                prev_btn.Visible = false;
                next_btn.Visible = false;
                loadQuestEdit();

            }
            else
            {
                this.Text = "Xem câu hỏi";
                socauhientai_tb.Enabled = false;
                auto_increase.Visible = false;
                auto_next_quest.Visible = false;
                smart_cp_cb.Visible = false;
                label7.Visible = false;
                a_rd.Visible = false;
                b_rd.Visible = false;
                c_rd.Visible = false;
                d_rd.Visible = false;
                prev_btn.Visible = true;
                next_btn.Visible = true;
                button1.Text = "Đóng";
                loadQuestEdit();
            }
            updateNumQuest();
        }
        public void loadQuestEdit()
        {
            SQLConnection conn = new SQLConnection();
            try
            {
                
                MySqlCommand cmd = new MySqlCommand("select stt, noidung, dapana, dapanb, dapanc, dapand, dapandung" +
                    " from question where stt = @stt and idbank = @idbank", conn.getConnection());
                cmd.Parameters.AddWithValue("@stt", Data.idquestaccess);
                cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                DataRow row = dataTable.Rows[0];
                var stt = row["stt"]; // Lấy giá trị của cột "stt"
                var noidung = row["noidung"]; // Lấy giá trị của cột "noidung"
                var dapana = row["dapana"]; // Lấy giá trị của cột "dapana"
                var dapanb = row["dapanb"]; // Lấy giá trị của cột "dapanb"
                var dapanc = row["dapanc"]; // Lấy giá trị của cột "dapanc"
                var dapand = row["dapand"]; // Lấy giá trị của cột "dapand"
                var dapandung = row["dapandung"]; // Lấy giá trị của cột "dapandung"
                socauhientai_tb.Text = stt.ToString();
                noidung_tb.Text = noidung.ToString();
                dapanA_tb.Text = dapana.ToString();
                dapanB_tb.Text = dapanb.ToString();
                dapanC_tb.Text = dapanc.ToString();
                dapanD_tb.Text = dapand.ToString();
                if (dapandung.ToString() == "A")
                {
                    a_rd.Checked = true;
                }
                if (dapandung.ToString() == "B")
                {
                    b_rd.Checked = true;
                }
                if (dapandung.ToString() == "C")
                {
                    c_rd.Checked = true;
                }
                if (dapandung.ToString() == "D")
                {
                    d_rd.Checked = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (QuestManager.isEditable == 0)
            {
                bool isSuccess = false;
                SQLConnection conn = new SQLConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("call addQuestion(@idbank, @stt, @nd, @a, @b, @c,@d, @ans, @user)", conn.getConnection());
                    cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                    cmd.Parameters.AddWithValue("@stt", socauhientai_tb.Text);
                    cmd.Parameters.AddWithValue("@nd", noidung_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", dapanA_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@b", dapanB_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", dapanC_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@d", dapanD_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@ans", dapAnDung);
                    cmd.Parameters.AddWithValue("@user", Data.loginUser.getUserName());
                    cmd.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.closeConnection();
                if (isSuccess)
                {
                    if (auto_next_quest.Checked)
                    {
                        reloadUI();
                    }
                    else
                        this.Close();
                }
            }
            else if(QuestManager.isEditable == 1)
            {
                bool isSuccess = false;
                SQLConnection conn = new SQLConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from question where stt = @stt and idbank = @idbank", conn.getConnection());
                    cmd.Parameters.AddWithValue("@stt", Data.idquestaccess);
                    cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("call addQuestion(@idbank, @stt, @nd, @a, @b, @c,@d, @ans, @user)", conn.getConnection());
                    cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                    cmd.Parameters.AddWithValue("@stt", socauhientai_tb.Text);
                    cmd.Parameters.AddWithValue("@nd", noidung_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", dapanA_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@b", dapanB_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", dapanC_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@d", dapanD_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@ans", dapAnDung);
                    cmd.Parameters.AddWithValue("@user", Data.loginUser.getUserName());
                    cmd.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "lỗi!");
                }
                finally
                {
                    conn.closeConnection(); 
                }
                if (isSuccess)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();

            }


        }

        private void a_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (a_rd.Checked == true)
            {
                dapAnDung = "A";
                dapanA_tb.BackColor = Color.Yellow;
            }
            else
            {
                dapanA_tb.BackColor = Color.White;
            }
        }

        private void b_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (b_rd.Checked == true)
            {
                dapAnDung = "B";
                dapanB_tb.BackColor = Color.Yellow;
            }
            else
            {
                dapanB_tb.BackColor = Color.White;
            }
        }

        private void c_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (c_rd.Checked == true)
            {
                dapAnDung = "C";
                dapanC_tb.BackColor = Color.Yellow;
            }
            else
            {
                dapanC_tb.BackColor = Color.White;
            }
        }

        private void d_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (d_rd.Checked == true)
            {
                dapAnDung = "D";
                dapanD_tb.BackColor = Color.Yellow;
            }
            else
            {
                dapanD_tb.BackColor = Color.White;
            }
        }

        private void auto_next_quest_CheckedChanged(object sender, EventArgs e)
        {
            if (!auto_next_quest.Checked)
            {
                auto_increase.Enabled = false;
                auto_increase.Checked = false;
            }
            else
            {
                auto_increase.Enabled = true;
            }
        }

        private void noidung_tb_TextChanged(object sender, EventArgs e)
        {
            noidung_tb.Text = chuanHoaText(noidung_tb.Text);
        }

        private void dapanA_tb_TextChanged(object sender, EventArgs e)
        {
            dapanA_tb.Text = chuanHoaText(dapanA_tb.Text);
        }

        private void dapanB_tb_TextChanged(object sender, EventArgs e)
        {
            dapanB_tb.Text = chuanHoaText(dapanB_tb.Text);
        }

        private void dapanC_tb_TextChanged(object sender, EventArgs e)
        {
            dapanC_tb.Text = chuanHoaText(dapanC_tb.Text);
        }

        private void dapanD_tb_TextChanged(object sender, EventArgs e)
        {
            dapanD_tb.Text = chuanHoaText(dapanD_tb.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void noidung_tb_Click(object sender, EventArgs e)
        {
            if (smart_cp_cb.Checked)
            {
                noidung_tb.Text= Clipboard.GetText();
            }

        }

        private void dapanA_tb_Click(object sender, EventArgs e)
        {
            if (smart_cp_cb.Checked)
            {
                dapanA_tb.Text = Clipboard.GetText();
            }
        }

        private void dapanB_tb_Click(object sender, EventArgs e)
        {
            if (smart_cp_cb.Checked)
            {
                dapanB_tb.Text = Clipboard.GetText();
            }
        }

        private void dapanC_tb_Click(object sender, EventArgs e)
        {
            if (smart_cp_cb.Checked)
            {
                dapanC_tb.Text = Clipboard.GetText();
            }
        }

        private void dapanD_tb_Click(object sender, EventArgs e)
        {
            if (smart_cp_cb.Checked)
            {
                dapanD_tb.Text = Clipboard.GetText();
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            Data.idquestaccess = (Int16.Parse(Data.idquestaccess) - 1).ToString();
            loadQuestEdit();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            Data.idquestaccess = (Int16.Parse(Data.idquestaccess) + 1).ToString();
            loadQuestEdit();
        }
    }
}
