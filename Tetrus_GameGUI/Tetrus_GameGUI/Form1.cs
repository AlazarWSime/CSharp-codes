using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetrus_GameGUI
{
    /// <summary>
    /// The main application window.
    /// Acts as a central router that swaps between different UserControl screens (Menu, Game, Options).
    /// </summary>
    public partial class Form1 : Form
    {
        private Panel contentPanel;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
            ShowMenu();
        }

        private void SetupForm()
        {
            this.Text = "Tetresu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.WindowState = FormWindowState.Maximized; // start maximized
            this.MinimumSize = new Size(500, 600);       // prevent too small

            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black
            };
            this.Controls.Add(contentPanel);
        }

        public void ShowMenu()
        {
            contentPanel.Controls.Clear();
            var menu = new MenuControl(this);
            menu.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(menu);
        }

        public void ShowGame()
        {
            contentPanel.Controls.Clear();
            var game = new GameControl(this);
            game.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(game);
            game.Focus();
        }

        public void ShowOptions()
        {
            contentPanel.Controls.Clear();
            var options = new OptionsControl(this);
            options.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(options);
        }
    }
}