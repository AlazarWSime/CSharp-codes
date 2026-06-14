namespace FormsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginpal = new Panel();
            loginbutton = new Button();
            passwordtxtbx = new TextBox();
            passwordlab = new Label();
            usernametxtbx = new TextBox();
            usernamelab = new Label();
            welcomelab = new Label();
            dashboardtab = new TabControl();
            scheduletabpage = new TabPage();
            clearbutton = new Button();
            updatebutton = new Button();
            savebutton = new Button();
            statuscombx = new ComboBox();
            statuslab = new Label();
            timedtimep = new DateTimePicker();
            timelab = new Label();
            datedtimep = new DateTimePicker();
            datelab = new Label();
            vetcombx = new ComboBox();
            vetlab = new Label();
            ownercombx = new ComboBox();
            ownerlab = new Label();
            petcombx = new ComboBox();
            petlab = new Label();
            scheduleapplab = new Label();
            pettabpage = new TabPage();
            gendercombox = new ComboBox();
            genderlabel = new Label();
            agenumericUpDown = new NumericUpDown();
            nametxtbox = new TextBox();
            ownecombx = new ComboBox();
            typecombx = new ComboBox();
            deletebutton = new Button();
            updatebutto = new Button();
            savebutto = new Button();
            ownelab = new Label();
            agelab = new Label();
            typelab = new Label();
            namelab = new Label();
            petdetailslab = new Label();
            medicaltabpage = new TabPage();
            treatmenttxtbx = new RichTextBox();
            diagnosistxtbx = new RichTextBox();
            updatebtton = new Button();
            savebtton = new Button();
            datdTimeP = new DateTimePicker();
            datela = new Label();
            treatmentlab = new Label();
            diagnosislab = new Label();
            vetcobox = new ComboBox();
            petcobox = new ComboBox();
            vetla = new Label();
            petla = new Label();
            medicalrecordlab = new Label();
            paymenttabpage = new TabPage();
            paybutton = new Button();
            printreceiptbutton = new Button();
            amounttxtbx = new TextBox();
            methodcombx = new ComboBox();
            statuscobox = new ComboBox();
            appointmentcombx = new ComboBox();
            statslab = new Label();
            methodlab = new Label();
            amountlab = new Label();
            appointmentlab = new Label();
            paymentlab = new Label();
            addemployeetabpage = new TabPage();
            cancelbut = new Button();
            savebut = new Button();
            agenumericud = new NumericUpDown();
            passwordtextbx = new TextBox();
            usernametextbx = new TextBox();
            statuscombox = new ComboBox();
            positioncombx = new ComboBox();
            gendercombx = new ComboBox();
            lastnametxtbx = new TextBox();
            firstnametxtbx = new TextBox();
            accountinfolab = new Label();
            statuslabel = new Label();
            passwordlabel = new Label();
            usernamelabel = new Label();
            positionlab = new Label();
            agelabel = new Label();
            genderlab = new Label();
            lastnamelab = new Label();
            firstnamelab = new Label();
            addemployeelab = new Label();
            loginpal.SuspendLayout();
            dashboardtab.SuspendLayout();
            scheduletabpage.SuspendLayout();
            pettabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)agenumericUpDown).BeginInit();
            medicaltabpage.SuspendLayout();
            paymenttabpage.SuspendLayout();
            addemployeetabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)agenumericud).BeginInit();
            SuspendLayout();
            // 
            // loginpal
            // 
            loginpal.Controls.Add(loginbutton);
            loginpal.Controls.Add(passwordtxtbx);
            loginpal.Controls.Add(passwordlab);
            loginpal.Controls.Add(usernametxtbx);
            loginpal.Controls.Add(usernamelab);
            loginpal.Controls.Add(welcomelab);
            loginpal.Location = new Point(0, 0);
            loginpal.Name = "loginpal";
            loginpal.Size = new Size(801, 450);
            loginpal.TabIndex = 0;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(342, 315);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(85, 29);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += button1_Click;
            // 
            // passwordtxtbx
            // 
            passwordtxtbx.Location = new Point(268, 241);
            passwordtxtbx.Name = "passwordtxtbx";
            passwordtxtbx.Size = new Size(240, 23);
            passwordtxtbx.TabIndex = 4;
            passwordtxtbx.UseSystemPasswordChar = true;
            // 
            // passwordlab
            // 
            passwordlab.AutoSize = true;
            passwordlab.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlab.Location = new Point(116, 241);
            passwordlab.Name = "passwordlab";
            passwordlab.Size = new Size(109, 23);
            passwordlab.TabIndex = 3;
            passwordlab.Text = "Password:";
            // 
            // usernametxtbx
            // 
            usernametxtbx.Location = new Point(268, 190);
            usernametxtbx.Name = "usernametxtbx";
            usernametxtbx.Size = new Size(240, 23);
            usernametxtbx.TabIndex = 2;
            // 
            // usernamelab
            // 
            usernamelab.AutoSize = true;
            usernamelab.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelab.Location = new Point(116, 190);
            usernamelab.Name = "usernamelab";
            usernamelab.Size = new Size(114, 23);
            usernamelab.TabIndex = 1;
            usernamelab.Text = "Username:";
            // 
            // welcomelab
            // 
            welcomelab.AutoSize = true;
            welcomelab.Font = new Font("Lucida Calligraphy", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomelab.Location = new Point(280, 99);
            welcomelab.Name = "welcomelab";
            welcomelab.Size = new Size(228, 45);
            welcomelab.TabIndex = 0;
            welcomelab.Text = "WELCOME";
            // 
            // dashboardtab
            // 
            dashboardtab.Controls.Add(scheduletabpage);
            dashboardtab.Controls.Add(pettabpage);
            dashboardtab.Controls.Add(medicaltabpage);
            dashboardtab.Controls.Add(paymenttabpage);
            dashboardtab.Controls.Add(addemployeetabpage);
            dashboardtab.Location = new Point(0, 0);
            dashboardtab.Name = "dashboardtab";
            dashboardtab.SelectedIndex = 0;
            dashboardtab.Size = new Size(801, 450);
            dashboardtab.TabIndex = 6;
            // 
            // scheduletabpage
            // 
            scheduletabpage.Controls.Add(clearbutton);
            scheduletabpage.Controls.Add(updatebutton);
            scheduletabpage.Controls.Add(savebutton);
            scheduletabpage.Controls.Add(statuscombx);
            scheduletabpage.Controls.Add(statuslab);
            scheduletabpage.Controls.Add(timedtimep);
            scheduletabpage.Controls.Add(timelab);
            scheduletabpage.Controls.Add(datedtimep);
            scheduletabpage.Controls.Add(datelab);
            scheduletabpage.Controls.Add(vetcombx);
            scheduletabpage.Controls.Add(vetlab);
            scheduletabpage.Controls.Add(ownercombx);
            scheduletabpage.Controls.Add(ownerlab);
            scheduletabpage.Controls.Add(petcombx);
            scheduletabpage.Controls.Add(petlab);
            scheduletabpage.Controls.Add(scheduleapplab);
            scheduletabpage.Location = new Point(4, 24);
            scheduletabpage.Name = "scheduletabpage";
            scheduletabpage.Padding = new Padding(3);
            scheduletabpage.Size = new Size(793, 422);
            scheduletabpage.TabIndex = 0;
            scheduletabpage.Text = "Schedule Appointment";
            scheduletabpage.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(429, 360);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(75, 23);
            clearbutton.TabIndex = 15;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(264, 360);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(75, 23);
            updatebutton.TabIndex = 14;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(102, 360);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(75, 23);
            savebutton.TabIndex = 13;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = true;
            // 
            // statuscombx
            // 
            statuscombx.FormattingEnabled = true;
            statuscombx.Items.AddRange(new object[] { "Pending", "Completed" });
            statuscombx.Location = new Point(147, 291);
            statuscombx.Name = "statuscombx";
            statuscombx.Size = new Size(211, 23);
            statuscombx.TabIndex = 12;
            // 
            // statuslab
            // 
            statuslab.AutoSize = true;
            statuslab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            statuslab.Location = new Point(53, 291);
            statuslab.Name = "statuslab";
            statuslab.Size = new Size(72, 26);
            statuslab.TabIndex = 11;
            statuslab.Text = "Status:";
            // 
            // timedtimep
            // 
            timedtimep.Format = DateTimePickerFormat.Time;
            timedtimep.Location = new Point(147, 256);
            timedtimep.Name = "timedtimep";
            timedtimep.Size = new Size(211, 23);
            timedtimep.TabIndex = 10;
            // 
            // timelab
            // 
            timelab.AutoSize = true;
            timelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            timelab.Location = new Point(53, 256);
            timelab.Name = "timelab";
            timelab.Size = new Size(62, 26);
            timelab.TabIndex = 9;
            timelab.Text = "Time:";
            // 
            // datedtimep
            // 
            datedtimep.Location = new Point(147, 214);
            datedtimep.Name = "datedtimep";
            datedtimep.Size = new Size(211, 23);
            datedtimep.TabIndex = 8;
            // 
            // datelab
            // 
            datelab.AutoSize = true;
            datelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            datelab.Location = new Point(53, 214);
            datelab.Name = "datelab";
            datelab.Size = new Size(61, 26);
            datelab.TabIndex = 7;
            datelab.Text = "Date:";
            // 
            // vetcombx
            // 
            vetcombx.FormattingEnabled = true;
            vetcombx.Items.AddRange(new object[] { "Dr. A", "Dr. B" });
            vetcombx.Location = new Point(147, 177);
            vetcombx.Name = "vetcombx";
            vetcombx.Size = new Size(211, 23);
            vetcombx.TabIndex = 6;
            // 
            // vetlab
            // 
            vetlab.AutoSize = true;
            vetlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            vetlab.Location = new Point(53, 174);
            vetlab.Name = "vetlab";
            vetlab.Size = new Size(49, 26);
            vetlab.TabIndex = 5;
            vetlab.Text = "Vet:";
            // 
            // ownercombx
            // 
            ownercombx.FormattingEnabled = true;
            ownercombx.Location = new Point(147, 137);
            ownercombx.Name = "ownercombx";
            ownercombx.Size = new Size(211, 23);
            ownercombx.TabIndex = 4;
            // 
            // ownerlab
            // 
            ownerlab.AutoSize = true;
            ownerlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ownerlab.Location = new Point(49, 137);
            ownerlab.Name = "ownerlab";
            ownerlab.Size = new Size(77, 26);
            ownerlab.TabIndex = 3;
            ownerlab.Text = "Owner:";
            // 
            // petcombx
            // 
            petcombx.FormattingEnabled = true;
            petcombx.Location = new Point(147, 97);
            petcombx.Name = "petcombx";
            petcombx.Size = new Size(211, 23);
            petcombx.TabIndex = 2;
            // 
            // petlab
            // 
            petlab.AutoSize = true;
            petlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            petlab.Location = new Point(53, 94);
            petlab.Name = "petlab";
            petlab.Size = new Size(45, 26);
            petlab.TabIndex = 1;
            petlab.Text = "Pet:";
            // 
            // scheduleapplab
            // 
            scheduleapplab.AutoSize = true;
            scheduleapplab.Font = new Font("Goudy Old Style", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            scheduleapplab.Location = new Point(264, 30);
            scheduleapplab.Name = "scheduleapplab";
            scheduleapplab.Size = new Size(270, 34);
            scheduleapplab.TabIndex = 0;
            scheduleapplab.Text = "Schedule Appointment";
            // 
            // pettabpage
            // 
            pettabpage.Controls.Add(gendercombox);
            pettabpage.Controls.Add(genderlabel);
            pettabpage.Controls.Add(agenumericUpDown);
            pettabpage.Controls.Add(nametxtbox);
            pettabpage.Controls.Add(ownecombx);
            pettabpage.Controls.Add(typecombx);
            pettabpage.Controls.Add(deletebutton);
            pettabpage.Controls.Add(updatebutto);
            pettabpage.Controls.Add(savebutto);
            pettabpage.Controls.Add(ownelab);
            pettabpage.Controls.Add(agelab);
            pettabpage.Controls.Add(typelab);
            pettabpage.Controls.Add(namelab);
            pettabpage.Controls.Add(petdetailslab);
            pettabpage.Location = new Point(4, 24);
            pettabpage.Name = "pettabpage";
            pettabpage.Padding = new Padding(3);
            pettabpage.Size = new Size(793, 422);
            pettabpage.TabIndex = 1;
            pettabpage.Text = "Pet Form";
            pettabpage.UseVisualStyleBackColor = true;
            // 
            // gendercombox
            // 
            gendercombox.FormattingEnabled = true;
            gendercombox.Items.AddRange(new object[] { "Male", "Female" });
            gendercombox.Location = new Point(169, 217);
            gendercombox.Name = "gendercombox";
            gendercombox.Size = new Size(211, 23);
            gendercombox.TabIndex = 15;
            // 
            // genderlabel
            // 
            genderlabel.AutoSize = true;
            genderlabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            genderlabel.Location = new Point(72, 217);
            genderlabel.Name = "genderlabel";
            genderlabel.Size = new Size(79, 26);
            genderlabel.TabIndex = 13;
            genderlabel.Text = "Gender:";
            // 
            // agenumericUpDown
            // 
            agenumericUpDown.Location = new Point(169, 180);
            agenumericUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            agenumericUpDown.Name = "agenumericUpDown";
            agenumericUpDown.Size = new Size(211, 23);
            agenumericUpDown.TabIndex = 12;
            // 
            // nametxtbox
            // 
            nametxtbox.Location = new Point(169, 103);
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(211, 23);
            nametxtbox.TabIndex = 11;
            // 
            // ownecombx
            // 
            ownecombx.FormattingEnabled = true;
            ownecombx.Location = new Point(169, 254);
            ownecombx.Name = "ownecombx";
            ownecombx.Size = new Size(211, 23);
            ownecombx.TabIndex = 10;
            // 
            // typecombx
            // 
            typecombx.FormattingEnabled = true;
            typecombx.Items.AddRange(new object[] { "Dog", "Cat", "Bird" });
            typecombx.Location = new Point(169, 143);
            typecombx.Name = "typecombx";
            typecombx.Size = new Size(211, 23);
            typecombx.TabIndex = 9;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(453, 323);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(75, 23);
            deletebutton.TabIndex = 8;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            // 
            // updatebutto
            // 
            updatebutto.Location = new Point(285, 323);
            updatebutto.Name = "updatebutto";
            updatebutto.Size = new Size(75, 23);
            updatebutto.TabIndex = 7;
            updatebutto.Text = "Update";
            updatebutto.UseVisualStyleBackColor = true;
            // 
            // savebutto
            // 
            savebutto.Location = new Point(128, 323);
            savebutto.Name = "savebutto";
            savebutto.Size = new Size(75, 23);
            savebutto.TabIndex = 6;
            savebutto.Text = "Save";
            savebutto.UseVisualStyleBackColor = true;
            // 
            // ownelab
            // 
            ownelab.AutoSize = true;
            ownelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ownelab.Location = new Point(74, 251);
            ownelab.Name = "ownelab";
            ownelab.Size = new Size(77, 26);
            ownelab.TabIndex = 5;
            ownelab.Text = "Owner:";
            // 
            // agelab
            // 
            agelab.AutoSize = true;
            agelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            agelab.Location = new Point(74, 177);
            agelab.Name = "agelab";
            agelab.Size = new Size(49, 26);
            agelab.TabIndex = 4;
            agelab.Text = "Age:";
            // 
            // typelab
            // 
            typelab.AutoSize = true;
            typelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            typelab.Location = new Point(74, 140);
            typelab.Name = "typelab";
            typelab.Size = new Size(58, 26);
            typelab.TabIndex = 3;
            typelab.Text = "Type:";
            // 
            // namelab
            // 
            namelab.AutoSize = true;
            namelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            namelab.Location = new Point(74, 105);
            namelab.Name = "namelab";
            namelab.Size = new Size(70, 26);
            namelab.TabIndex = 2;
            namelab.Text = "Name:";
            // 
            // petdetailslab
            // 
            petdetailslab.AutoSize = true;
            petdetailslab.Font = new Font("Goudy Old Style", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            petdetailslab.Location = new Point(298, 41);
            petdetailslab.Name = "petdetailslab";
            petdetailslab.Size = new Size(139, 34);
            petdetailslab.TabIndex = 1;
            petdetailslab.Text = "Pet Details";
            // 
            // medicaltabpage
            // 
            medicaltabpage.Controls.Add(treatmenttxtbx);
            medicaltabpage.Controls.Add(diagnosistxtbx);
            medicaltabpage.Controls.Add(updatebtton);
            medicaltabpage.Controls.Add(savebtton);
            medicaltabpage.Controls.Add(datdTimeP);
            medicaltabpage.Controls.Add(datela);
            medicaltabpage.Controls.Add(treatmentlab);
            medicaltabpage.Controls.Add(diagnosislab);
            medicaltabpage.Controls.Add(vetcobox);
            medicaltabpage.Controls.Add(petcobox);
            medicaltabpage.Controls.Add(vetla);
            medicaltabpage.Controls.Add(petla);
            medicaltabpage.Controls.Add(medicalrecordlab);
            medicaltabpage.Location = new Point(4, 24);
            medicaltabpage.Name = "medicaltabpage";
            medicaltabpage.Padding = new Padding(3);
            medicaltabpage.Size = new Size(793, 422);
            medicaltabpage.TabIndex = 2;
            medicaltabpage.Text = "Medical Record";
            medicaltabpage.UseVisualStyleBackColor = true;
            // 
            // treatmenttxtbx
            // 
            treatmenttxtbx.Location = new Point(196, 223);
            treatmenttxtbx.Name = "treatmenttxtbx";
            treatmenttxtbx.Size = new Size(279, 46);
            treatmenttxtbx.TabIndex = 17;
            treatmenttxtbx.Text = "";
            // 
            // diagnosistxtbx
            // 
            diagnosistxtbx.Location = new Point(196, 165);
            diagnosistxtbx.Name = "diagnosistxtbx";
            diagnosistxtbx.Size = new Size(279, 46);
            diagnosistxtbx.TabIndex = 16;
            diagnosistxtbx.Text = "";
            // 
            // updatebtton
            // 
            updatebtton.Location = new Point(385, 347);
            updatebtton.Name = "updatebtton";
            updatebtton.Size = new Size(75, 23);
            updatebtton.TabIndex = 15;
            updatebtton.Text = "Update";
            updatebtton.UseVisualStyleBackColor = true;
            // 
            // savebtton
            // 
            savebtton.Location = new Point(163, 347);
            savebtton.Name = "savebtton";
            savebtton.Size = new Size(75, 23);
            savebtton.TabIndex = 14;
            savebtton.Text = "Save";
            savebtton.UseVisualStyleBackColor = true;
            // 
            // datdTimeP
            // 
            datdTimeP.Location = new Point(196, 288);
            datdTimeP.Name = "datdTimeP";
            datdTimeP.Size = new Size(211, 23);
            datdTimeP.TabIndex = 12;
            // 
            // datela
            // 
            datela.AutoSize = true;
            datela.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            datela.Location = new Point(76, 288);
            datela.Name = "datela";
            datela.Size = new Size(61, 26);
            datela.TabIndex = 11;
            datela.Text = "Date:";
            // 
            // treatmentlab
            // 
            treatmentlab.AutoSize = true;
            treatmentlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            treatmentlab.Location = new Point(66, 237);
            treatmentlab.Name = "treatmentlab";
            treatmentlab.Size = new Size(107, 26);
            treatmentlab.TabIndex = 10;
            treatmentlab.Text = "Treatment:";
            // 
            // diagnosislab
            // 
            diagnosislab.AutoSize = true;
            diagnosislab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            diagnosislab.Location = new Point(66, 176);
            diagnosislab.Name = "diagnosislab";
            diagnosislab.Size = new Size(101, 26);
            diagnosislab.TabIndex = 9;
            diagnosislab.Text = "Diagnosis:";
            // 
            // vetcobox
            // 
            vetcobox.FormattingEnabled = true;
            vetcobox.Items.AddRange(new object[] { "Dr. A", "Dr. B" });
            vetcobox.Location = new Point(196, 131);
            vetcobox.Name = "vetcobox";
            vetcobox.Size = new Size(211, 23);
            vetcobox.TabIndex = 8;
            // 
            // petcobox
            // 
            petcobox.FormattingEnabled = true;
            petcobox.Location = new Point(196, 91);
            petcobox.Name = "petcobox";
            petcobox.Size = new Size(211, 23);
            petcobox.TabIndex = 7;
            // 
            // vetla
            // 
            vetla.AutoSize = true;
            vetla.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            vetla.Location = new Point(76, 128);
            vetla.Name = "vetla";
            vetla.Size = new Size(49, 26);
            vetla.TabIndex = 6;
            vetla.Text = "Vet:";
            // 
            // petla
            // 
            petla.AutoSize = true;
            petla.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            petla.Location = new Point(76, 88);
            petla.Name = "petla";
            petla.Size = new Size(45, 26);
            petla.TabIndex = 2;
            petla.Text = "Pet:";
            // 
            // medicalrecordlab
            // 
            medicalrecordlab.AutoSize = true;
            medicalrecordlab.Font = new Font("Goudy Old Style", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            medicalrecordlab.Location = new Point(283, 32);
            medicalrecordlab.Name = "medicalrecordlab";
            medicalrecordlab.Size = new Size(192, 34);
            medicalrecordlab.TabIndex = 1;
            medicalrecordlab.Text = "Medical Record";
            // 
            // paymenttabpage
            // 
            paymenttabpage.Controls.Add(paybutton);
            paymenttabpage.Controls.Add(printreceiptbutton);
            paymenttabpage.Controls.Add(amounttxtbx);
            paymenttabpage.Controls.Add(methodcombx);
            paymenttabpage.Controls.Add(statuscobox);
            paymenttabpage.Controls.Add(appointmentcombx);
            paymenttabpage.Controls.Add(statslab);
            paymenttabpage.Controls.Add(methodlab);
            paymenttabpage.Controls.Add(amountlab);
            paymenttabpage.Controls.Add(appointmentlab);
            paymenttabpage.Controls.Add(paymentlab);
            paymenttabpage.Location = new Point(4, 24);
            paymenttabpage.Name = "paymenttabpage";
            paymenttabpage.Padding = new Padding(3);
            paymenttabpage.Size = new Size(793, 422);
            paymenttabpage.TabIndex = 3;
            paymenttabpage.Text = "Payment";
            paymenttabpage.UseVisualStyleBackColor = true;
            // 
            // paybutton
            // 
            paybutton.Location = new Point(120, 347);
            paybutton.Name = "paybutton";
            paybutton.Size = new Size(106, 23);
            paybutton.TabIndex = 21;
            paybutton.Text = "Pay";
            paybutton.UseVisualStyleBackColor = true;
            // 
            // printreceiptbutton
            // 
            printreceiptbutton.Location = new Point(398, 347);
            printreceiptbutton.Name = "printreceiptbutton";
            printreceiptbutton.Size = new Size(106, 23);
            printreceiptbutton.TabIndex = 20;
            printreceiptbutton.Text = "Print Receipt";
            printreceiptbutton.UseVisualStyleBackColor = true;
            // 
            // amounttxtbx
            // 
            amounttxtbx.Location = new Point(239, 163);
            amounttxtbx.Name = "amounttxtbx";
            amounttxtbx.Size = new Size(211, 23);
            amounttxtbx.TabIndex = 18;
            // 
            // methodcombx
            // 
            methodcombx.Enabled = false;
            methodcombx.FormattingEnabled = true;
            methodcombx.Location = new Point(239, 214);
            methodcombx.Name = "methodcombx";
            methodcombx.Size = new Size(211, 23);
            methodcombx.TabIndex = 17;
            methodcombx.Text = "Cash";
            // 
            // statuscobox
            // 
            statuscobox.FormattingEnabled = true;
            statuscobox.Items.AddRange(new object[] { "Paid", "Pending" });
            statuscobox.Location = new Point(239, 262);
            statuscobox.Name = "statuscobox";
            statuscobox.Size = new Size(211, 23);
            statuscobox.TabIndex = 16;
            // 
            // appointmentcombx
            // 
            appointmentcombx.FormattingEnabled = true;
            appointmentcombx.Location = new Point(239, 117);
            appointmentcombx.Name = "appointmentcombx";
            appointmentcombx.Size = new Size(211, 23);
            appointmentcombx.TabIndex = 15;
            // 
            // statslab
            // 
            statslab.AutoSize = true;
            statslab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            statslab.Location = new Point(76, 261);
            statslab.Name = "statslab";
            statslab.Size = new Size(72, 26);
            statslab.TabIndex = 14;
            statslab.Text = "Status:";
            // 
            // methodlab
            // 
            methodlab.AutoSize = true;
            methodlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            methodlab.Location = new Point(76, 211);
            methodlab.Name = "methodlab";
            methodlab.Size = new Size(84, 26);
            methodlab.TabIndex = 13;
            methodlab.Text = "Method:";
            // 
            // amountlab
            // 
            amountlab.AutoSize = true;
            amountlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            amountlab.Location = new Point(76, 160);
            amountlab.Name = "amountlab";
            amountlab.Size = new Size(88, 26);
            amountlab.TabIndex = 12;
            amountlab.Text = "Amount:";
            // 
            // appointmentlab
            // 
            appointmentlab.AutoSize = true;
            appointmentlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            appointmentlab.Location = new Point(76, 114);
            appointmentlab.Name = "appointmentlab";
            appointmentlab.Size = new Size(129, 26);
            appointmentlab.TabIndex = 11;
            appointmentlab.Text = "Appointment:";
            // 
            // paymentlab
            // 
            paymentlab.AutoSize = true;
            paymentlab.Font = new Font("Goudy Old Style", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            paymentlab.Location = new Point(310, 41);
            paymentlab.Name = "paymentlab";
            paymentlab.Size = new Size(113, 34);
            paymentlab.TabIndex = 2;
            paymentlab.Text = "Payment";
            // 
            // addemployeetabpage
            // 
            addemployeetabpage.Controls.Add(cancelbut);
            addemployeetabpage.Controls.Add(savebut);
            addemployeetabpage.Controls.Add(agenumericud);
            addemployeetabpage.Controls.Add(passwordtextbx);
            addemployeetabpage.Controls.Add(usernametextbx);
            addemployeetabpage.Controls.Add(statuscombox);
            addemployeetabpage.Controls.Add(positioncombx);
            addemployeetabpage.Controls.Add(gendercombx);
            addemployeetabpage.Controls.Add(lastnametxtbx);
            addemployeetabpage.Controls.Add(firstnametxtbx);
            addemployeetabpage.Controls.Add(accountinfolab);
            addemployeetabpage.Controls.Add(statuslabel);
            addemployeetabpage.Controls.Add(passwordlabel);
            addemployeetabpage.Controls.Add(usernamelabel);
            addemployeetabpage.Controls.Add(positionlab);
            addemployeetabpage.Controls.Add(agelabel);
            addemployeetabpage.Controls.Add(genderlab);
            addemployeetabpage.Controls.Add(lastnamelab);
            addemployeetabpage.Controls.Add(firstnamelab);
            addemployeetabpage.Controls.Add(addemployeelab);
            addemployeetabpage.Location = new Point(4, 24);
            addemployeetabpage.Name = "addemployeetabpage";
            addemployeetabpage.Padding = new Padding(3);
            addemployeetabpage.Size = new Size(793, 422);
            addemployeetabpage.TabIndex = 4;
            addemployeetabpage.Text = "Add Employee";
            addemployeetabpage.UseVisualStyleBackColor = true;
            // 
            // cancelbut
            // 
            cancelbut.Location = new Point(414, 391);
            cancelbut.Name = "cancelbut";
            cancelbut.Size = new Size(75, 23);
            cancelbut.TabIndex = 21;
            cancelbut.Text = "Cancel";
            cancelbut.UseVisualStyleBackColor = true;
            // 
            // savebut
            // 
            savebut.Location = new Point(146, 391);
            savebut.Name = "savebut";
            savebut.Size = new Size(75, 23);
            savebut.TabIndex = 20;
            savebut.Text = "Save";
            savebut.UseVisualStyleBackColor = true;
            // 
            // agenumericud
            // 
            agenumericud.Location = new Point(205, 183);
            agenumericud.Name = "agenumericud";
            agenumericud.Size = new Size(211, 23);
            agenumericud.TabIndex = 19;
            // 
            // passwordtextbx
            // 
            passwordtextbx.Enabled = false;
            passwordtextbx.Location = new Point(205, 320);
            passwordtextbx.Name = "passwordtextbx";
            passwordtextbx.Size = new Size(211, 23);
            passwordtextbx.TabIndex = 18;
            // 
            // usernametextbx
            // 
            usernametextbx.Enabled = false;
            usernametextbx.Location = new Point(205, 291);
            usernametextbx.Name = "usernametextbx";
            usernametextbx.Size = new Size(211, 23);
            usernametextbx.TabIndex = 17;
            // 
            // statuscombox
            // 
            statuscombox.FormattingEnabled = true;
            statuscombox.Items.AddRange(new object[] { "Active", "Inactive" });
            statuscombox.Location = new Point(205, 353);
            statuscombox.Name = "statuscombox";
            statuscombox.Size = new Size(211, 23);
            statuscombox.TabIndex = 16;
            // 
            // positioncombx
            // 
            positioncombx.FormattingEnabled = true;
            positioncombx.Items.AddRange(new object[] { "Admin", "Receptionist", "Veterinarian", "Cashier" });
            positioncombx.Location = new Point(205, 214);
            positioncombx.Name = "positioncombx";
            positioncombx.Size = new Size(211, 23);
            positioncombx.TabIndex = 15;
            // 
            // gendercombx
            // 
            gendercombx.FormattingEnabled = true;
            gendercombx.Items.AddRange(new object[] { "Male", "Female" });
            gendercombx.Location = new Point(205, 148);
            gendercombx.Name = "gendercombx";
            gendercombx.Size = new Size(211, 23);
            gendercombx.TabIndex = 14;
            // 
            // lastnametxtbx
            // 
            lastnametxtbx.Location = new Point(205, 113);
            lastnametxtbx.Name = "lastnametxtbx";
            lastnametxtbx.Size = new Size(211, 23);
            lastnametxtbx.TabIndex = 13;
            // 
            // firstnametxtbx
            // 
            firstnametxtbx.Location = new Point(205, 78);
            firstnametxtbx.Name = "firstnametxtbx";
            firstnametxtbx.Size = new Size(211, 23);
            firstnametxtbx.TabIndex = 12;
            // 
            // accountinfolab
            // 
            accountinfolab.AutoSize = true;
            accountinfolab.Font = new Font("Goudy Old Style", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            accountinfolab.Location = new Point(283, 240);
            accountinfolab.Name = "accountinfolab";
            accountinfolab.Size = new Size(140, 30);
            accountinfolab.TabIndex = 11;
            accountinfolab.Text = "Account Info";
            // 
            // statuslabel
            // 
            statuslabel.AutoSize = true;
            statuslabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            statuslabel.Location = new Point(54, 350);
            statuslabel.Name = "statuslabel";
            statuslabel.Size = new Size(72, 26);
            statuslabel.TabIndex = 10;
            statuslabel.Text = "Status:";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            passwordlabel.Location = new Point(54, 320);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(97, 26);
            passwordlabel.TabIndex = 9;
            passwordlabel.Text = "Password:";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            usernamelabel.Location = new Point(54, 289);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(103, 26);
            usernamelabel.TabIndex = 8;
            usernamelabel.Text = "Username:";
            // 
            // positionlab
            // 
            positionlab.AutoSize = true;
            positionlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            positionlab.Location = new Point(54, 214);
            positionlab.Name = "positionlab";
            positionlab.Size = new Size(87, 26);
            positionlab.TabIndex = 7;
            positionlab.Text = "Position:";
            // 
            // agelabel
            // 
            agelabel.AutoSize = true;
            agelabel.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            agelabel.Location = new Point(54, 180);
            agelabel.Name = "agelabel";
            agelabel.Size = new Size(49, 26);
            agelabel.TabIndex = 6;
            agelabel.Text = "Age:";
            // 
            // genderlab
            // 
            genderlab.AutoSize = true;
            genderlab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            genderlab.Location = new Point(54, 145);
            genderlab.Name = "genderlab";
            genderlab.Size = new Size(79, 26);
            genderlab.TabIndex = 5;
            genderlab.Text = "Gender:";
            // 
            // lastnamelab
            // 
            lastnamelab.AutoSize = true;
            lastnamelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lastnamelab.Location = new Point(54, 110);
            lastnamelab.Name = "lastnamelab";
            lastnamelab.Size = new Size(114, 26);
            lastnamelab.TabIndex = 4;
            lastnamelab.Text = "Last Name:";
            // 
            // firstnamelab
            // 
            firstnamelab.AutoSize = true;
            firstnamelab.Font = new Font("Goudy Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            firstnamelab.Location = new Point(54, 75);
            firstnamelab.Name = "firstnamelab";
            firstnamelab.Size = new Size(115, 26);
            firstnamelab.TabIndex = 3;
            firstnamelab.Text = "First Name:";
            // 
            // addemployeelab
            // 
            addemployeelab.AutoSize = true;
            addemployeelab.Font = new Font("Goudy Old Style", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            addemployeelab.Location = new Point(276, 23);
            addemployeelab.Name = "addemployeelab";
            addemployeelab.Size = new Size(178, 34);
            addemployeelab.TabIndex = 2;
            addemployeelab.Text = "Add Employee";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginpal);
            Controls.Add(dashboardtab);
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            loginpal.ResumeLayout(false);
            loginpal.PerformLayout();
            dashboardtab.ResumeLayout(false);
            scheduletabpage.ResumeLayout(false);
            scheduletabpage.PerformLayout();
            pettabpage.ResumeLayout(false);
            pettabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)agenumericUpDown).EndInit();
            medicaltabpage.ResumeLayout(false);
            medicaltabpage.PerformLayout();
            paymenttabpage.ResumeLayout(false);
            paymenttabpage.PerformLayout();
            addemployeetabpage.ResumeLayout(false);
            addemployeetabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)agenumericud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginpal;
        private Label welcomelab;
        private Label usernamelab;
        private Button loginbutton;
        private TextBox passwordtxtbx;
        private Label passwordlab;
        private TextBox usernametxtbx;
        private TabControl dashboardtab;
        private TabPage scheduletabpage;
        private TabPage pettabpage;
        private Label scheduleapplab;
        private ComboBox petcombx;
        private Label petlab;
        private ComboBox vetcombx;
        private Label vetlab;
        private ComboBox ownercombx;
        private Label ownerlab;
        private Label timelab;
        private DateTimePicker datedtimep;
        private Label datelab;
        private Button savebutton;
        private ComboBox statuscombx;
        private Label statuslab;
        private DateTimePicker timedtimep;
        private Button updatebutton;
        private Button clearbutton;
        private Label petdetailslab;
        private Label ownelab;
        private Label agelab;
        private Label typelab;
        private Label namelab;
        private NumericUpDown agenumericUpDown;
        private TextBox nametxtbox;
        private ComboBox ownecombx;
        private ComboBox typecombx;
        private Button deletebutton;
        private Button updatebutto;
        private Button savebutto;
        private TabPage medicaltabpage;
        private Label medicalrecordlab;
        private TabPage paymenttabpage;
        private TabPage addemployeetabpage;
        private Label treatmentlab;
        private Label diagnosislab;
        private ComboBox vetcobox;
        private ComboBox petcobox;
        private Label vetla;
        private Label petla;
        private RichTextBox treatmenttxtbx;
        private RichTextBox diagnosistxtbx;
        private Button updatebtton;
        private Button savebtton;
        private DateTimePicker datdTimeP;
        private Label datela;
        private Label appointmentlab;
        private Label paymentlab;
        private Label addemployeelab;
        private Button printreceiptbutton;
        private TextBox amounttxtbx;
        private ComboBox methodcombx;
        private ComboBox statuscobox;
        private ComboBox appointmentcombx;
        private Label statslab;
        private Label methodlab;
        private Label amountlab;
        private Button paybutton;
        private Label positionlab;
        private Label agelabel;
        private Label genderlab;
        private Label lastnamelab;
        private Label firstnamelab;
        private Label statuslabel;
        private Label passwordlabel;
        private Label usernamelabel;
        private TextBox firstnametxtbx;
        private Label accountinfolab;
        private ComboBox positioncombx;
        private ComboBox gendercombx;
        private TextBox lastnametxtbx;
        private ComboBox statuscombox;
        private Button savebut;
        private NumericUpDown agenumericud;
        private TextBox passwordtextbx;
        private TextBox usernametextbx;
        private Button cancelbut;
        private ComboBox gendercombox;
        private Label genderlabel;
    }
}
