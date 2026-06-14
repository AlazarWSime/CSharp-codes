using FormApp.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FormApp
{
    public partial class Inventory_MS : Form
    {
        public Inventory_MS()
        {
            InitializeComponent();
        }
        private void LoadInventory(DataGridView grid)
        { 
            
                string query = "SELECT UserID, Username, PassCode, Rolle FROM Users";
                SqlCommand cmd = new SqlCommand(query, DBConnection._Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd );
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid.DataSource = dt;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Adim_Panel.Visible = false;
            LoadInventory(dataGridView3);
            LoadInventory(dataGridView6);
            LoadInventory(dataGridView2);
            //staff_Panel.Visible = false;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            string Username = UsernameBox.Text;
            string Password = PasswordBox.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrMsgLbl_Login.Text = "Provide all Username and Password";
                ErrMsgLbl_Login.ForeColor = Color.Firebrick;
                return; // this stopes the method here - with out this it saves empty, one or two boxes to the database

            }

            //string query = $@"INSERT INTO [Users](Username, PassCode) VALUES('{Username}', '{Password}')";
            string query = "SELECT PassCode FROM Users WHERE Username=@Username";
            DBConnection.Initialte();
            SqlCommand cmd = new SqlCommand(query, DBConnection._Connection);

            SqlParameter[] parameters =
                    {
                        new SqlParameter("@Username", Username)                    
                    };
            cmd.Parameters.AddRange(parameters);
            var result = cmd.ExecuteScalar();//ExecuteScalar -> runs your query and gives you back one single value based on that it only selects Rolle that have the specified name and password
            
            DBConnection._Connection.Close();

            if (result != null)
            {
                string storedHash = result.ToString();

                bool isValid = BCrypt.Net.BCrypt.EnhancedVerify(Password, storedHash);

                if (isValid)
                {
                    
                    ErrMsgLbl_Login.Text = "Logged in successfully!";
                    ErrMsgLbl_Login.ForeColor = Color.LimeGreen;
                    Adim_Panel.Visible = true;
                    tabControl1.Visible = true;
                    LoginPanel.Visible = false;
                    SignIn_pannel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else  
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_pannel_Paint(object sender, PaintEventArgs e)
        {
             
            
        }

        private void RoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_PageLbl_Click(object sendeer, EventArgs e) 
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string Username = UserName_Box.Text;
            string Password = Passsword_Box.Text;
            string Rolle = RoleBox.Text;

            // Hash the password before saving
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(Password);

            string query = "INSERT INTO Users (Username, PassCode,Rolle ) VALUES (@Username, @Password, @Rolle)";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@Username", Username),
                new SqlParameter("@Password", hashedPassword), // ← saving hash not plain text
                new SqlParameter("@Rolle", Rolle)
            };

            DBConnection.ExcuteNonQuery(query, parameters);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashbord_SystemAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Adim_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Management_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Supplier_Management_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_InventoryManager_Click(object sender, EventArgs e)
        {

        }

        private void ItemEditor_InventroyManager_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_InvetoryManager_Click(object sender, EventArgs e)
        {

        }

        private void Reposrts_InventoryManager_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_WarehouseStaff_Click(object sender, EventArgs e)
        {

        }

        private void ItemEditor_WarehouseStaff_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_WarehouseStaff_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_SalesManager_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_SalaesManager_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_SalesManager_Click(object sender, EventArgs e)
        {

        }

        private void Reports_SalesManager_Click(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ErrMsgLbl_Login_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passLab_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ErrMsgLbl_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Box_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Passsword_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
