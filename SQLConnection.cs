using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestBankManager_Project
{
    public class SQLConnection : Form
    {
        private static String serverUrl = Data.ipserver;
        
        private static String dbName  = "questbankmanager";
        private static String userName = "YangKlee";
        private static String password = "18072005";
        private String urlConnection = "SERVER=" + serverUrl + 
            ";DATABASE=" + dbName + 
            ";USER=" + userName + 
            ";Password="+ password;

        MySqlConnection con = null;
        public SQLConnection()
        {
            
            serverUrl = Data.ipserver;
            try
            {
                con = new MySqlConnection(urlConnection);
                con.Open();
            }
            catch(Exception ex) 
            {
                if(File.Exists("logindata.dat"))
                {
                    File.Delete("logindata.dat");
                }
                MessageBox.Show("Không thể connect tới máy chủ \n " + ex.Message, "Lỗi nè!",buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Error);
            }

        }
        public MySqlConnection getConnection()
        {
            return con;
        }
        public void closeConnection()
        {
            con.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SQLConnection
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "SQLConnection";
            this.Load += new System.EventHandler(this.SQLConnection_Load);
            this.ResumeLayout(false);

        }

        private void SQLConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
