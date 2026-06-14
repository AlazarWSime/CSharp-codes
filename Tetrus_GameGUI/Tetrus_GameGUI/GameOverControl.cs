using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetrus_GameGUI
{
    public partial class GameOverControl : UserControl
    {
        private Form1 mainForm;
        private GameControl gameControl;

        public GameOverControl(Form1 form, GameControl gameCtrl)
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
                RowCount = 3,
                BackColor = Color.Transparent,
                Padding = new Padding(20)
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            var label = new Label
            {
                Text = "GAME OVER",
                ForeColor = Color.Red,
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var btnTryAgain = CreateButton("Try Again");
            btnTryAgain.Click += (s, e) => gameControl.RestartGame();

            var btnExit = CreateButton("Exit");
            btnExit.Click += (s, e) => gameControl.QuitToMain();

            layout.Controls.Add(label, 0, 0);
            layout.Controls.Add(btnTryAgain, 0, 1);
            layout.Controls.Add(btnExit, 0, 2);

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
                Margin = new Padding(10)
            };
        }
    }
}