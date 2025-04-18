using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestBankManager_Project
{
    struct Question
    {
        string stt;
        string cauhoi;
        string dapana;
        string dapanb;
        string dapanc;
        string dapand;
        char trueAns;
    };
    public partial class QuestBankManager : Form
    {
        public QuestBankManager()
        {
            InitializeComponent();
        }
        public void login()
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            if (Data.loginUser.getUserName() != null )
            {
                
                username_lb.Text = Data.loginUser.getUserName();
                this.Show();
            }
            else
                this.Close();
        }
        public void loadBank()
        {

            SQLConnection conn = new SQLConnection();
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select idbank as 'Mã ngân hàng', " +
                "namebank as 'Tên ngân hàng', soluong as 'Số câu'  from questbank", conn.getConnection());
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "lsbank");
                dataGridView1.DataSource = ds.Tables["lsbank"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn tới máy chủ!" + ex.Message, "Lỗi nè", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

            conn.closeConnection();
        }
        private void QuestBankManager_Load(object sender, EventArgs e)
        {
            login();
            if (Data.loginUser.getUserName() != null)
                loadBank(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.loginUser.setUserName(null);
            if (File.Exists("logindata.dat"))
            {
                File.Delete("logindata.dat");
            }
            login();
        }

        private void add_bank_bt_Click(object sender, EventArgs e)
        {
            ModifyBankDialog addBank = new ModifyBankDialog();
            addBank.ShowDialog();
            loadBank();
        }

        private void access_bank_bt_Click(object sender, EventArgs e)
        {
            if (Data.idbankaccess != null)
            {
                    QuestManager questManager = new QuestManager();
                    this.Hide();
                    questManager.ShowDialog();
                    loadBank();
                    this.Show();
            }
            else
            {
                MessageBox.Show("Chưa chọn ngân hàng");
            }
        }

        private void delete_bank_bt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Khi xóa ngân hàng thì toàn bộ câu hỏi trong ngân hàng đều bị mất và không thể khôi phục.\n Are you ready", "Cẩn thận nè", MessageBoxButtons.YesNo, icon:MessageBoxIcon.Warning);

            if (Data.idbankaccess != null )
            {
                if (dialogResult == DialogResult.Yes)
                {
                    SQLConnection conn = new SQLConnection();
                    MySqlCommand cmd = new MySqlCommand("delete from questbank where idbank = @id;", conn.getConnection());
                    cmd.Parameters.AddWithValue("@id", Data.idbankaccess);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn ngân hàng!");
            }
            loadBank();
            Data.idbankaccess = null;
        }

        private void find_bt_Click(object sender, EventArgs e)
        {
            SQLConnection conn = new SQLConnection();
            String commm = "select idbank as 'Mã ngân hàng', " +
                "namebank as 'Tên ngân hàng', soluong as 'Số câu'  from questbank " +
                "where idbank like @find or namebank like @find;";
            MySqlCommand cmd = new MySqlCommand(commm, conn.getConnection());
            cmd.Parameters.AddWithValue("@find", "%"+find_tb.Text + "%");
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds, "lsbank");

            dataGridView1.DataSource = ds.Tables["lsbank"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            find_bt.Text = null;
            loadBank();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.DefaultExt = "txt"; // Định dạng mặc định

            if(Data.idbankaccess != null && saveFile.ShowDialog() == DialogResult.OK)
            {

                SQLConnection conn = new SQLConnection();
                String sqlComm = "select stt, noidung, dapana, dapanb, dapanc, dapand, dapandung from question where idbank = @id";
                MySqlCommand comm = new MySqlCommand(sqlComm, conn.getConnection());
                comm.Parameters.AddWithValue("@id", Data.idbankaccess);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "shikanoko");
                DataTable dt = ds.Tables["shikanoko"];
                foreach (DataRow row in dt.Rows)
                {
                    string stt = row["stt"].ToString();
                    string cauhoi = row["noidung"].ToString();
                    string dapanA = row["dapana"].ToString();
                    string dapanB = row["dapanb"].ToString();
                    string dapanC = row["dapanc"].ToString();
                    string dapanD = row["dapand"].ToString();
                    string key = row["dapandung"].ToString();
                    string output = $"Câu {stt}: {cauhoi}\n";
                    if (key == "A")
                    {
                        output += $"*A. {dapanA} \n";
                    }
                    else
                    {
                        output += $"A. {dapanA} \n";
                    }

                    if (key == "B")
                    {
                        output += $"*B. {dapanB} \n";
                    }
                    else
                    {
                        output += $"B. {dapanB}\n";
                    }

                    if (key == "C")
                    {
                        output += $"*C. {dapanC}\n";
                    }
                    else
                    {
                        output += $"C. {dapanC}\n";
                    }

                    if (key == "D")
                    {
                        output += $"*D. {dapanD}\n";
                    }
                    else
                    {
                        output += $"D. {dapanD}\n";
                    }
                    File.AppendAllText(saveFile.FileName, output + Environment.NewLine);
                    
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn ngân hàng");
            }


            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                if (rowIndex != -1)
                {
                    Data.idbankaccess = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                    //MessageBox.Show(Data.idbankaccess);

                }
                //loadBank();
            }
        }

        private void edit_bank_bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dev lười code tính năng này\nQua tết làm :)))", "Lỗi!", MessageBoxButtons.OK,icon:MessageBoxIcon.Error);
        }
    }
}
