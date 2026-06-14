using System;
using System.Drawing;
using Tetrus_GameGUI;

namespace Tetrus_GameGUI
{
    /// <summary>
    /// The central game controller orchestrating the interaction between the Board and Tetrominoes.
    /// Manages score, level progression, game loop state, and logic execution (movement, dropping).
    /// </summary>
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

        private void SpawnNewPiece()// create a new standard tetromino piece out of the 7 standard tetrominoes
        {
            currentPiece = nextPiece; 
            nextPiece = Tetromino.RandomPiece();
            if (!board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y))
                GameOver = true;
        }

        /// <summary>
        /// Moves the active piece left if it won't collide with the wall or other blocks.
        /// </summary>
        public void MoveLeft()
        {
            if (!GameOver && board.PieceFits(currentPiece, currentPiece.X - 1, currentPiece.Y))
                currentPiece.X--;
        }

        /// <summary>
        /// Moves the active piece right if it won't collide with the wall or other blocks.
        /// </summary>
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

        /// <summary>
        /// Instantly drops the current piece down as far as possible until it touches the ground/blocks,
        /// and locks it securely into place.
        /// </summary>
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

        /// <summary>
        /// Handles the logic when a piece can no longer descend. Locks the piece,
        /// calculates score based on lines cleared, adjusts difficulty (level), and spawns the next piece.
        /// </summary>
        private void LockPiece()
        {
            board.LockPiece(currentPiece);
            int linesCleared = board.ClearLines();
            if (linesCleared > 0)
            {
                // Classic Tetris scoring system implementation based on simultaneous lines cleared.
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
                
                // Increase the level for every 10 lines, and decrease the timer delay (making it fall faster)
                level = lines / 10;
                fallDelay = Math.Max(100, 500 - level * 40);
            }
            SpawnNewPiece();
        }

        /// <summary>
        /// Renders the locked blocks on the board and the currently active dropping piece.
        /// </summary>
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
                        g.FillRectangle(Brushes.Gray, rect);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, rect);
                    }
                    g.DrawRectangle(Pens.White, rect);
                }
            }

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

        /// <summary>
        /// Renders the upcoming 'Next Piece' to a separate UI panel visually.
        /// </summary>
        public void DrawNextPiece(Graphics g, Rectangle bounds)
        {
            g.Clear(Color.Black);
            if (nextPiece == null) return;
            int cellSize = Math.Min(bounds.Width / 4, bounds.Height / 4);
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