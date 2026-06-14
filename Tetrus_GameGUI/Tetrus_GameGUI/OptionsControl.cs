using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetrus_GameGUI
{
    public partial class OptionsControl : UserControl
    {
        private Form1 mainForm;

        public OptionsControl(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.BackColor = Color.Black;

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                BackColor = Color.Black
            };
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            var label = new Label
            {
                Text = "OPTIONS",
                ForeColor = Color.Cyan,
                Font = new Font("Arial", 36, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var btnBack = new Button
            {
                Text = "Back to Menu",
                Dock = DockStyle.Fill,
                BackColor = Color.DarkGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Margin = new Padding(100, 20, 100, 50)
            };
            btnBack.Click += (s, e) => mainForm.ShowMenu();

            layout.Controls.Add(label, 0, 0);
            layout.Controls.Add(btnBack, 0, 1);

            this.Controls.Add(layout);
        }
    }
}