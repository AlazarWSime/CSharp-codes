using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetrus_Game_GUI
{
    public partial class Form1 : Form
    {
        private Game game;
        private Timer gameTimer;
        private Panel boardPanel;
        private Panel nextPanel;
        private Label lblScore, lblLines, lblLevel;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
            game = new Game();
            gameTimer = new Timer();
            gameTimer.Interval = game.FallDelay;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void SetupForm()
        {
            this.Text = "Tetresu";
            this.Size = new Size(500, 700);
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;

            boardPanel = new Panel
            {
                Location = new Point(20, 20),
                Size = new Size(300, 600),
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle
            };
            boardPanel.Paint += BoardPanel_Paint;

            nextPanel = new Panel
            {
                Location = new Point(340, 20),
                Size = new Size(120, 120),
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle
            };
            nextPanel.Paint += NextPanel_Paint;

            lblScore = new Label
            {
                Location = new Point(340, 150),
                ForeColor = Color.White,
                Text = "Score: 0"
            };
            lblLines = new Label
            {
                Location = new Point(340, 180),
                ForeColor = Color.White,
                Text = "Lines: 0"
            };
            lblLevel = new Label
            {
                Location = new Point(340, 210),
                ForeColor = Color.White,
                Text = "Level: 0"
            };

            this.Controls.Add(boardPanel);
            this.Controls.Add(nextPanel);
            this.Controls.Add(lblScore);
            this.Controls.Add(lblLines);
            this.Controls.Add(lblLevel);

            this.KeyDown += Form1_KeyDown;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!game.GameOver)
            {
                game.MovePieceDown();
                boardPanel.Invalidate();
                nextPanel.Invalidate();
                UpdateLabels();
                gameTimer.Interval = game.FallDelay; // update speed
            }
            else
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over!\nPress OK to restart.", "Tetresu");
                game = new Game();
                gameTimer.Start();
                boardPanel.Invalidate();
                nextPanel.Invalidate();
                UpdateLabels();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (game.GameOver) return;

            switch (e.KeyCode)
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
            }
            boardPanel.Invalidate();
            nextPanel.Invalidate();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblScore.Text = "Score: " + game.Score;
            lblLines.Text = "Lines: " + game.Lines;
            lblLevel.Text = "Level: " + game.Level;
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

    // ------------------- Game Logic (adapted from console version) -------------------

    public class Tetromino
    {
        public int[,] Shape { get; private set; }
        public ConsoleColor ConsoleColor { get; private set; } // kept for compatibility, but we'll map to drawing color
        public Color Color { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        private static readonly List<Tetromino> pieces = new List<Tetromino>();

        static Tetromino()
        {
            // I
            pieces.Add(new Tetromino(new int[,] { { 1, 1, 1, 1 } }, ConsoleColor.Cyan, Color.Cyan));
            // O
            pieces.Add(new Tetromino(new int[,] { { 1, 1 }, { 1, 1 } }, ConsoleColor.Yellow, Color.Yellow));
            // T
            pieces.Add(new Tetromino(new int[,] { { 0, 1, 0 }, { 1, 1, 1 } }, ConsoleColor.Magenta, Color.Magenta));
            // S
            pieces.Add(new Tetromino(new int[,] { { 0, 1, 1 }, { 1, 1, 0 } }, ConsoleColor.Green, Color.Green));
            // Z
            pieces.Add(new Tetromino(new int[,] { { 1, 1, 0 }, { 0, 1, 1 } }, ConsoleColor.Red, Color.Red));
            // L
            pieces.Add(new Tetromino(new int[,] { { 1, 0, 0 }, { 1, 1, 1 } }, ConsoleColor.DarkYellow, Color.Orange));
            // J
            pieces.Add(new Tetromino(new int[,] { { 0, 0, 1 }, { 1, 1, 1 } }, ConsoleColor.Blue, Color.Blue));
        }

        private Tetromino(int[,] shape, ConsoleColor consoleColor, Color color)
        {
            Shape = shape;
            ConsoleColor = consoleColor;
            Color = color;
            X = 3;
            Y = 0;
        }

        public static Tetromino RandomPiece()
        {
            var rnd = new Random();
            return pieces[rnd.Next(pieces.Count)].Clone();
        }

        public Tetromino Clone()
        {
            return new Tetromino((int[,])Shape.Clone(), ConsoleColor, Color);
        }

        public void Rotate()
        {
            int rows = Shape.GetLength(0);
            int cols = Shape.GetLength(1);
            int[,] rotated = new int[cols, rows];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    rotated[j, rows - 1 - i] = Shape[i, j];
            Shape = rotated;
        }
    }

    public class Board
    {
        private int[,] grid;
        public const int Width = 10;
        public const int Height = 20;

        public Board()
        {
            grid = new int[Height, Width];
        }

        public bool PieceFits(Tetromino piece, int x, int y)
        {
            for (int i = 0; i < piece.Shape.GetLength(0); i++)
                for (int j = 0; j < piece.Shape.GetLength(1); j++)
                    if (piece.Shape[i, j] != 0)
                    {
                        int boardX = x + j;
                        int boardY = y + i;
                        if (boardX < 0 || boardX >= Width || boardY >= Height || boardY < 0)
                            return false;
                        if (boardY >= 0 && grid[boardY, boardX] != 0)
                            return false;
                    }
            return true;
        }

        public void LockPiece(Tetromino piece)
        {
            for (int i = 0; i < piece.Shape.GetLength(0); i++)
                for (int j = 0; j < piece.Shape.GetLength(1); j++)
                    if (piece.Shape[i, j] != 0)
                    {
                        int y = piece.Y + i;
                        int x = piece.X + j;
                        if (y >= 0 && y < Height && x >= 0 && x < Width)
                            grid[y, x] = 1; // store color later if needed
                    }
        }

        public int ClearLines()
        {
            int linesCleared = 0;
            for (int y = Height - 1; y >= 0; y--)
            {
                bool full = true;
                for (int x = 0; x < Width; x++)
                    if (grid[y, x] == 0) { full = false; break; }

                if (full)
                {
                    for (int yy = y; yy > 0; yy--)
                        for (int x = 0; x < Width; x++)
                            grid[yy, x] = grid[yy - 1, x];
                    for (int x = 0; x < Width; x++)
                        grid[0, x] = 0;
                    linesCleared++;
                    y++;
                }
            }
            return linesCleared;
        }

        public bool IsGameOver()
        {
            for (int x = 0; x < Width; x++)
                if (grid[0, x] != 0) return true;
            return false;
        }

        // For drawing
        public int GetCell(int x, int y) => grid[y, x];
    }

    public class Game
    {
        private Board board;
        private Tetromino currentPiece;
        private Tetromino nextPiece;
        private Random random;
        private int score;
        private int lines;
        private int level;
        private int fallDelay;

        public int Score => score;
        public int Lines => lines;
        public int Level => level;
        public int FallDelay => fallDelay;
        public bool GameOver { get; private set; }

        public Game()
        {
            board = new Board();
            random = new Random();
            score = 0;
            lines = 0;
            level = 0;
            fallDelay = 500;
            nextPiece = Tetromino.RandomPiece();
            SpawnNewPiece();
            GameOver = false;
        }

        private void SpawnNewPiece()
        {
            currentPiece = nextPiece;
            nextPiece = Tetromino.RandomPiece();
            if (!board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y))
                GameOver = true;
        }

        public void MoveLeft()
        {
            if (!GameOver && board.PieceFits(currentPiece, currentPiece.X - 1, currentPiece.Y))
                currentPiece.X--;
        }

        public void MoveRight()
        {
            if (!GameOver && board.PieceFits(currentPiece, currentPiece.X + 1, currentPiece.Y))
                currentPiece.X++;
        }

        public void MoveDown()
        {
            if (GameOver) return;
            if (board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y + 1))
                currentPiece.Y++;
            else
                LockPiece();
        }

        public void Rotate()
        {
            if (GameOver) return;
            var rotated = currentPiece.Clone();
            rotated.Rotate();
            if (board.PieceFits(rotated, currentPiece.X, currentPiece.Y))
                currentPiece.Rotate();
        }

        public void HardDrop()
        {
            if (GameOver) return;
            while (board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y + 1))
                currentPiece.Y++;
            LockPiece();
        }

        public void MovePieceDown()
        {
            if (GameOver) return;
            if (board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y + 1))
                currentPiece.Y++;
            else
                LockPiece();
        }

        private void LockPiece()
        {
            board.LockPiece(currentPiece);
            int linesCleared = board.ClearLines();
            if (linesCleared > 0)
            {
                lines += linesCleared;
                int baseScore = 0;
                switch (linesCleared)
                {
                    case 1: baseScore = 100; break;
                    case 2: baseScore = 300; break;
                    case 3: baseScore = 500; break;
                    case 4: baseScore = 800; break;
                }
                score += baseScore * (level + 1);
                level = lines / 10;
                fallDelay = Math.Max(100, 500 - level * 40);
            }
            SpawnNewPiece();
        }

        // Drawing methods
        public void DrawBoard(Graphics g, Rectangle bounds)
        {
            int cellSize = Math.Min(bounds.Width / Board.Width, bounds.Height / Board.Height);
            for (int y = 0; y < Board.Height; y++)
            {
                for (int x = 0; x < Board.Width; x++)
                {
                    Rectangle rect = new Rectangle(bounds.X + x * cellSize, bounds.Y + y * cellSize, cellSize - 1, cellSize - 1);
                    if (board.GetCell(x, y) != 0)
                    {
                        g.FillRectangle(Brushes.Gray, rect); // locked pieces
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, rect);
                    }
                    g.DrawRectangle(Pens.White, rect);
                }
            }

            // Draw current piece
            if (currentPiece != null && !GameOver)
            {
                for (int i = 0; i < currentPiece.Shape.GetLength(0); i++)
                    for (int j = 0; j < currentPiece.Shape.GetLength(1); j++)
                        if (currentPiece.Shape[i, j] != 0)
                        {
                            int x = currentPiece.X + j;
                            int y = currentPiece.Y + i;
                            if (y >= 0 && y < Board.Height && x >= 0 && x < Board.Width)
                            {
                                Rectangle rect = new Rectangle(bounds.X + x * cellSize, bounds.Y + y * cellSize, cellSize - 1, cellSize - 1);
                                using (Brush b = new SolidBrush(currentPiece.Color))
                                {
                                    g.FillRectangle(b, rect);
                                }
                                g.DrawRectangle(Pens.White, rect);
                            }
                        }
            }
        }

        public void DrawNextPiece(Graphics g, Rectangle bounds)
        {
            g.Clear(Color.Black);
            if (nextPiece == null) return;
            int cellSize = Math.Min(bounds.Width / 4, bounds.Height / 4); // max piece size is 4x4
            int offsetX = (bounds.Width - (nextPiece.Shape.GetLength(1) * cellSize)) / 2;
            int offsetY = (bounds.Height - (nextPiece.Shape.GetLength(0) * cellSize)) / 2;

            for (int i = 0; i < nextPiece.Shape.GetLength(0); i++)
                for (int j = 0; j < nextPiece.Shape.GetLength(1); j++)
                    if (nextPiece.Shape[i, j] != 0)
                    {
                        Rectangle rect = new Rectangle(bounds.X + offsetX + j * cellSize, bounds.Y + offsetY + i * cellSize, cellSize - 1, cellSize - 1);
                        using (Brush b = new SolidBrush(nextPiece.Color))
                        {
                            g.FillRectangle(b, rect);
                        }
                        g.DrawRectangle(Pens.White, rect);
                    }
        }
    }
}
