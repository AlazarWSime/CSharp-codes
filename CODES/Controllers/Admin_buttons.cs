// Global flags tracking edit configurations inside your Form class
private bool isEditMode = false;
private Guid editingEmployeeId = Guid.Empty;
private Guid editingUserId = Guid.Empty;
private AdminController adminCtrl = new AdminController();




private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
{
    int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
    
    // Adjust age if their birthday hasn't occurred yet this year
    if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-age)) 
    {
        age--;
    }
    
    txtAge.Text = age.ToString(); // Injects the computed age directly into your textbox
}





private void btnSave_Click(object sender, EventArgs e)
{
    string firstName = txtFirstName.Text.Trim();
    string lastName = txtLastName.Text.Trim();
    string position = cbPosition.Text;
    
    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(position))
    {
        MessageBox.Show("Please fill all required inputs.", "Validation Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    int age = Convert.ToInt32(txtAge.Text);
    char gender = cbGender.Text[0];

    if (isEditMode)
    {
        // Execute Update Sequence
        bool updated = adminCtrl.UpdateEmployee(editingEmployeeId, editingUserId, firstName, lastName, gender, age, position);
        if (updated)


        
        {
            MessageBox.Show("Employee database record updated cleanly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
            RefreshGrids();
        }
    }
    else
    {
        // Execute Fresh Insertion Sequence
        string result = adminCtrl.AddEmployee(firstName, lastName, gender, age, position);
        string[] parts = result.Split('|');

        if (parts[0] == "SUCCESS")
        {
            string username = parts[1];
            string password = parts[2];

            // Display plain text credentials in message box as requested
            MessageBox.Show($"Employee Added Successfully!\n\nGenerated Account Credentials:\nUsername: {username}\nPassword: {password}\n\nPlease copy and provide these safely to the staff member.", 
                            "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ResetForm();
            RefreshGrids();
        }
        else
        {
            MessageBox.Show($"Operation Failed: {parts[1]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}





private void btnClear_Click(object sender, EventArgs e)
{
    ResetForm();
}

private void ResetForm()
{
    txtFirstName.Clear();
    txtLastName.Clear();
    txtAge.Clear();
    cbGender.SelectedIndex = -1;
    cbPosition.SelectedIndex = -1;
    isEditMode = false;
    editingEmployeeId = Guid.Empty;
    editingUserId = Guid.Empty;
    btnSave.Text = "Save"; // Reset button text label
}

private void RefreshGrids()
{
    // Binds the data adapters to your DataGridView properties instantly
    dgvEmployees.DataSource = adminCtrl.GetAllEmployees();
    dgvAccounts.DataSource = adminCtrl.GetActiveAccounts();
}






// FOR THE EMPLOYEES GRIDVIEW (Screenshot 2)
private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex < 0) return;

    Guid empId = (Guid)dgvEmployees.Rows[e.RowIndex].Cells["EmployeeId"].Value;
    Guid userId = (Guid)dgvEmployees.Rows[e.RowIndex].Cells["UserId"].Value;

    // IF UPDATE CLICKED
    if (dgvEmployees.Columns[e.ColumnIndex].Name == "btnUpdate")
    {
        txtFirstName.Text = dgvEmployees.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
        txtLastName.Text = dgvEmployees.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
        txtAge.Text = dgvEmployees.Rows[e.RowIndex].Cells["Age"].Value.ToString();
        cbGender.Text = dgvEmployees.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
        cbPosition.Text = dgvEmployees.Rows[e.RowIndex].Cells["Position"].Value.ToString();

        // Switch application context flag to edit mode
        isEditMode = true;
        editingEmployeeId = empId;
        editingUserId = userId;
        btnSave.Text = "Update";

        // Programmatically direct view focus to the input form tab panel
        myTabControl.SelectedTab = tabAddEmployee; 
    }

    // IF DELETE CLICKED (Soft Delete)
    if (dgvEmployees.Columns[e.ColumnIndex].Name == "btnDelete")
    {
        DialogResult check = MessageBox.Show("Are you sure you want to remove this employee account?", "Confirm Soft Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (check == DialogResult.Yes)
        {
            if (adminCtrl.SoftDeleteEmployee(userId))
            {
                MessageBox.Show("Employee account removed successfully.");
                RefreshGrids();
            }
        }
    }
}

// FOR THE ACCOUNTS GRIDVIEW (Screenshot 3)
private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex < 0) return;

    // IF STATUS ACTION CLICKED
    if (dgvAccounts.Columns[e.ColumnIndex].Name == "btnAction")
    {
        Guid userId = (Guid)dgvAccounts.Rows[e.RowIndex].Cells["UserId"].Value;
        string currentStatus = dgvAccounts.Rows[e.RowIndex].Cells["Status"].Value.ToString();

        if (adminCtrl.ToggleAccountStatus(userId, currentStatus))
        {
            MessageBox.Show("Account authorization status modified successfully!");
            RefreshGrids();
        }
    }
}







