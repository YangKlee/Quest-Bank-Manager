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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.ipserver = ip_tb.Text;
            File.WriteAllText("ipserver.dat", ip_tb.Text);

            this.Close();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            ip_tb.Text = Data.ipserver;
        }
    }
}
