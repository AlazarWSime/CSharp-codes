using Lab_exercise.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // DBConnection.Initialte();
            string userName = usernameBOX.Text;
            string password = passwordBox.Text;

            string query = $@"INSERT INTO testTable(userID, userName, passWord) VALUES('{1}','{userName}','{password}') ";
            DBConnection.ExecuteNonQuery(query);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
