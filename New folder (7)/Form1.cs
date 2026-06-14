namespace FormsApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernametxtbx.Text) ||
                string.IsNullOrEmpty(passwordtxtbx.Text))
            {
                MessageBox.Show("No username or password provided.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (usernametxtbx.Text == "admin01" && passwordtxtbx.Text == "ADMIN01"){
                MessageBox.Show("Welcome to the Dashboard.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        
    }
}
