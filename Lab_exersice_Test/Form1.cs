using Lab_exersice_Test.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_exersice_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {

            
            string userID = UserIDBox.Text;
            string Username = UsernameBox.Text;
            string Password = PasswordBox.Text;
            string query = $@"INSERT INTO testTable1(userID, userName, passWord) VALUES('{userID}', '{Username}', '{Password}')";
            DBConnection.ExcuteNonQuery(query);
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
