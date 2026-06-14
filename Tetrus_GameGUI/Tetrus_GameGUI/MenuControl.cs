using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetrus_GameGUI
{
    /// <summary>
    /// Represents the main start menu layout and navigation buttons.
    /// </summary>
    public partial class MenuControl : UserControl
    {
        private Form1 mainForm;

        public MenuControl(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.BackColor = Color.Black;

            // Use a TableLayoutPanel to center buttons automatically
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                BackColor = Color.Black
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            var titleLabel = new Label
            {
                Text = "TETRESU",
                ForeColor = Color.Cyan,
                Font = new Font("Arial", 36, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var btnPlay = CreateButton("Play");
            btnPlay.Click += (s, e) => mainForm.ShowGame();

            var btnOptions = CreateButton("Options");
            btnOptions.Click += (s, e) => mainForm.ShowOptions();

            var btnExit = CreateButton("Exit");
            btnExit.Click += (s, e) => Application.Exit();

            layout.Controls.Add(titleLabel, 0, 0);
            layout.Controls.Add(btnPlay, 0, 1);
            layout.Controls.Add(btnOptions, 0, 2);
            layout.Controls.Add(btnExit, 0, 3);

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
                Font = new Font("Arial", 16, FontStyle.Bold),
                Margin = new Padding(50, 10, 50, 10) // add spacing
            };
        }
    }
}