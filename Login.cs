using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestBankManager_Project
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SQLConnection conn = new SQLConnection();
            try
            {
                
                String sqlCommandLogin = "select Login(@UserName, @Password) as isSuccess";
                MySqlCommand login = new MySqlCommand(sqlCommandLogin, conn.getConnection());
                login.Parameters.AddWithValue("@UserName", usernameTB.Text);
                login.Parameters.AddWithValue("@Password", passTB.Text);
                object result = login.ExecuteScalar();
                
                if (result != null && Convert.ToBoolean(result))
                {
                    Data.loginUser.setUserName(usernameTB.Text);
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi truy vấn tới máy chủ!"  +ex.Message, "Lỗi nè", buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Error);

            }
            finally
            {

                conn.closeConnection();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting setting = new setting();
            setting.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                Data.ipserver = File.ReadAllText("ipserver.dat");
            }
            catch
            {
                MessageBox.Show("Vì lần đầu chạy chương trình,Vui lòng thiết lập kết nối", "Thông báo");
                this.Hide();
                setting setting = new setting();
                setting.ShowDialog();
                this.Show();
            }
        }
    }
}
