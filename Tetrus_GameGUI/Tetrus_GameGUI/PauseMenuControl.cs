using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetrus_GameGUI
{
    public partial class PauseMenuControl : UserControl
    {
        private Form1 mainForm;
        private GameControl gameControl;

        public PauseMenuControl(Form1 form, GameControl gameCtrl)
        {
            mainForm = form;
            gameControl = gameCtrl;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.BackColor = Color.FromArgb(200, 0, 0, 0);
            this.BorderStyle = BorderStyle.FixedSingle;

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                BackColor = Color.Transparent,
                Padding = new Padding(20)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            var label = new Label
            {
                Text = "PAUSED",
                ForeColor = Color.White,
                Font = new Font("Arial", 20, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var btnContinue = CreateButton("Continue");
            btnContinue.Click += (s, e) => gameControl.ResumeGame();

            var btnMainMenu = CreateButton("Main Menu");
            btnMainMenu.Click += (s, e) => gameControl.QuitToMain();

            var btnOptions = CreateButton("Options");
            btnOptions.Click += (s, e) =>
            {
                gameControl.QuitToMain();
                mainForm.ShowOptions();
            };

            var btnExit = CreateButton("Exit");
            btnExit.Click += (s, e) => Application.Exit();

            layout.Controls.Add(label, 0, 0);
            layout.Controls.Add(btnContinue, 0, 1);
            layout.Controls.Add(btnMainMenu, 0, 2);
            layout.Controls.Add(btnOptions, 0, 3);
            layout.Controls.Add(btnExit, 0, 4);

            this.Controls.Add(layout);
        }

        private Button CreateButton(string text)
        {
            return new Button
            {
                Text = text,
                Dock = DockStyle.Fill,
                BackColor = Color.DarkGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Margin = new Padding(10)
            };
        }
    }
}