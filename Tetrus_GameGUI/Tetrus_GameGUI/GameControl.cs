using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetrus_GameGUI
{
    /// <summary>
    /// The primary gameplay user interface control.
    /// Handles the game loop via a Timer, intercepts keyboard inputs, translates them to Game commands,
    /// and manages rendering updates and overlay menus (Pause, Game Over).
    /// </summary>
    public partial class GameControl : UserControl
    {
        private Form1 mainForm;
        private Game game;
        private Timer gameTimer;
        private Panel boardPanel;
        private Panel nextPanel;
        private Label lblScore, lblLines, lblLevel;
        private Button btnPause;
        private PauseMenuControl pauseMenu;
        private GameOverControl gameOverMenu;

        public GameControl(Form1 form)
        {
            mainForm = form;
            InitializeComponent();   // calls designer method (empty)
            SetupGame();
            SetupUI();
            StartGame();
        }

        private void SetupGame()
        {
            game = new Game();
            gameTimer = new Timer();
            gameTimer.Interval = game.FallDelay;
            gameTimer.Tick += GameTimer_Tick;
        }

        /// <summary>
        /// Initializes the visual layout of the game screen, dividing it into a playing board
        /// on the left and a statistics/next-piece panel on the right.
        /// </summary>
        private void SetupUI()
        {
            this.BackColor = Color.Black;

            // Main layout: two columns (board | right panel)
            var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.Black
            };
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));

            // Right panel (stacked controls)
            var rightPanel = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 5,
                Dock = DockStyle.Fill,
                BackColor = Color.Black,
                Padding = new Padding(5)
            };
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            // Next piece panel
            nextPanel = new Panel
            {
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill
            };
            nextPanel.Paint += NextPanel_Paint;

            // Labels
            lblScore = new Label
            {
                ForeColor = Color.White,
                Text = "Score: 0",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            lblLines = new Label
            {
                ForeColor = Color.White,
                Text = "Lines: 0",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            lblLevel = new Label
            {
                ForeColor = Color.White,
                Text = "Level: 0",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            // Pause button
            btnPause = new Button
            {
                Text = "Pause",
                BackColor = Color.DarkGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            btnPause.Click += BtnPause_Click;

            // Add to right panel
            rightPanel.Controls.Add(nextPanel, 0, 0);
            rightPanel.Controls.Add(lblScore, 0, 1);
            rightPanel.Controls.Add(lblLines, 0, 2);
            rightPanel.Controls.Add(lblLevel, 0, 3);
            rightPanel.Controls.Add(btnPause, 0, 4);

            // Board panel
            boardPanel = new Panel
            {
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill
            };
            boardPanel.Paint += BoardPanel_Paint;

            // Add to main layout
            mainLayout.Controls.Add(boardPanel, 0, 0);
            mainLayout.Controls.Add(rightPanel, 1, 0);

            this.Controls.Add(mainLayout);

            // Overlays (pause and game over) – centered
            pauseMenu = new PauseMenuControl(mainForm, this);
            pauseMenu.Size = new Size(300, 250);
            pauseMenu.Visible = false;
            pauseMenu.Anchor = AnchorStyles.None;
            this.Controls.Add(pauseMenu);
            pauseMenu.BringToFront();

            gameOverMenu = new GameOverControl(mainForm, this);
            gameOverMenu.Size = new Size(300, 250);
            gameOverMenu.Visible = false;
            gameOverMenu.Anchor = AnchorStyles.None;
            this.Controls.Add(gameOverMenu);
            gameOverMenu.BringToFront();

            // Center overlays on resize
            this.Resize += (s, e) =>
            {
                pauseMenu.Location = new Point(
                    (this.ClientSize.Width - pauseMenu.Width) / 2,
                    (this.ClientSize.Height - pauseMenu.Height) / 2
                );
                gameOverMenu.Location = new Point(
                    (this.ClientSize.Width - gameOverMenu.Width) / 2,
                    (this.ClientSize.Height - gameOverMenu.Height) / 2
                );
            };
        }

        private void StartGame()
        {
            gameTimer.Start();
            this.Focus();
        }

        public void PauseGame()
        {
            gameTimer.Stop();
            pauseMenu.Visible = true;
            pauseMenu.BringToFront();
        }

        public void ResumeGame()
        {
            pauseMenu.Visible = false;
            gameTimer.Start();
            this.Focus();
        }

        public void QuitToMain()
        {
            gameTimer.Stop();
            gameOverMenu.Visible = false;
            mainForm.ShowMenu();
        }

        public void RestartGame()
        {
            game = new Game();
            gameTimer.Start();
            gameOverMenu.Visible = false;
            btnPause.Enabled = true;
            boardPanel.Invalidate();
            nextPanel.Invalidate();
            UpdateLabels();
            this.Focus();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        /// <summary>
        /// The main game loop event. Fires periodically based on the FallDelay.
        /// Forces the active piece down by one block and triggers necessary redraws.
        /// </summary>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!game.GameOver)
            {
                game.MovePieceDown();
                boardPanel.Invalidate();
                nextPanel.Invalidate();
                UpdateLabels();
                gameTimer.Interval = game.FallDelay;
            }
            else
            {
                gameTimer.Stop();
                ShowGameOver();
            }
        }

        private void ShowGameOver()
        {
            gameOverMenu.Visible = true;
            gameOverMenu.BringToFront();
            btnPause.Enabled = false;
        }

        private void UpdateLabels()
        {
            lblScore.Text = "Score: " + game.Score;
            lblLines.Text = "Lines: " + game.Lines;
            lblLevel.Text = "Level: " + game.Level;
        }

        /// <summary>
        /// Intercepts keyboard inputs at the control level before they reach focused child elements,
        /// ensuring smooth and reliable gameplay controls.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (game.GameOver || pauseMenu.Visible || gameOverMenu.Visible)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.Left:
                    game.MoveLeft();
                    break;
                case Keys.Right:
                    game.MoveRight();
                    break;
                case Keys.Down:
                    game.MoveDown();
                    break;
                case Keys.Up:
                    game.Rotate();
                    break;
                case Keys.Space:
                    game.HardDrop();
                    break;
                case Keys.P:
                    PauseGame();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            boardPanel.Invalidate();
            nextPanel.Invalidate();
            UpdateLabels();
            return true;
        }

        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {
            if (game == null) return;
            game.DrawBoard(e.Graphics, boardPanel.ClientRectangle);
        }

        private void NextPanel_Paint(object sender, PaintEventArgs e)
        {
            if (game == null) return;
            game.DrawNextPiece(e.Graphics, nextPanel.ClientRectangle);
        }
    }
}