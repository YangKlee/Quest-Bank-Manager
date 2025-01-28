using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestBankManager_Project
{
    public partial class QuestManager : Form
    {
        public QuestManager()
        {
            InitializeComponent();
        }
        public static bool isEditable = false;
        // them - isEditable = false
        // sua - isEditable = true
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
        public void updateListQuest()
        {
            SQLConnection conn = new SQLConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("call XemCauHoi(@idbank)", conn.getConnection());
                cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "lsbank");
                questTable.DataSource = ds.Tables["lsbank"];
                questTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn tới máy chủ!" + ex.Message, "Lỗi nè", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

            }

            conn.closeConnection();
        }
        private void QuestManager_Load(object sender, EventArgs e)
        {
            this.Text = "HỆ THỐNG QUẢN LÝ CÂU HỎI - MÃ NGÂN HÀNG: " + Data.idbankaccess;
            manganhang_tx.Text = Data.idbankaccess;
            updateListQuest();
            updateNumQuest();
        }

        private void questTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            isEditable = false;
            this.Hide();
            QuestModifyForm frm = new QuestModifyForm();
            frm.ShowDialog();
            this.Show();
            updateListQuest();
            updateNumQuest();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Data.idbankaccess = null;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLConnection conn = new SQLConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("call TimCauHoi(@idbank, @find)", conn.getConnection());
                cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                cmd.Parameters.AddWithValue("@find", "%"+find_tb.Text + "%");
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "lsbank");
                questTable.DataSource = ds.Tables["lsbank"];
                questTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn tới máy chủ!" + ex.Message, "Lỗi nè", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

            conn.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            find_tb.Text = null;
            updateListQuest();
            updateNumQuest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.idquestaccess!=null)
            {
                isEditable = true;
                QuestModifyForm frm = new QuestModifyForm();
                frm.ShowDialog();
                updateListQuest();
                updateNumQuest();
            }
            else
            {
                MessageBox.Show("Chưa chọn câu hỏi!", "Thông báo");
            }
            Data.idquestaccess = null;

        }

        private void questTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (questTable.CurrentRow != null)
            {
                int rowIndex = questTable.CurrentRow.Index;
                if (rowIndex != -1)
                {
                    Data.idquestaccess = questTable.Rows[rowIndex].Cells[0].Value.ToString();
                    //MessageBox.Show(Data.idbankaccess);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.idquestaccess != null) {
                SQLConnection conn = new SQLConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete from question where stt = @stt and idbank = @idbank", conn.getConnection());
                    cmd.Parameters.AddWithValue("@stt", Data.idquestaccess);
                    cmd.Parameters.AddWithValue("@idbank", Data.idbankaccess);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi!");
                }
                finally
                {
                    conn.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn câu hỏi để xóa!");
            }
            updateListQuest();
            updateNumQuest();
            Data.idquestaccess = null;

        }
    }
}
