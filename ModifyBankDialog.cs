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
    public partial class ModifyBankDialog : Form
    {
        public ModifyBankDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnection conn = new SQLConnection();
                MySqlCommand cmd = new MySqlCommand("call addBank(@IDBank, @NameBank, @User)", conn.getConnection());
                cmd.Parameters.AddWithValue("@IDBank", bank_id_tb.Text);
                cmd.Parameters.AddWithValue("@NameBank", bank_name_tb.Text);
                cmd.Parameters.AddWithValue("@User", Data.loginUser.getUserName());
                cmd.ExecuteNonQuery();
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
