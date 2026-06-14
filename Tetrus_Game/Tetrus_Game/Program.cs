using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetrus_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }

    // Represents a single tetromino piece
    class Tetromino
    {
        public int[,] Shape { get; private set; }
        public ConsoleColor Color { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        private static readonly List<Tetromino> pieces = new List<Tetromino>
        {
            // I
            new Tetromino(new int[,] { { 1, 1, 1, 1 } }, ConsoleColor.Cyan),
            // O
            new Tetromino(new int[,] { { 1, 1 }, { 1, 1 } }, ConsoleColor.Yellow),
            // T
            new Tetromino(new int[,] { { 0, 1, 0 }, { 1, 1, 1 } }, ConsoleColor.Magenta),
            // S
            new Tetromino(new int[,] { { 0, 1, 1 }, { 1, 1, 0 } }, ConsoleColor.Green),
            // Z
            new Tetromino(new int[,] { { 1, 1, 0 }, { 0, 1, 1 } }, ConsoleColor.Red),
            // L
            new Tetromino(new int[,] { { 1, 0, 0 }, { 1, 1, 1 } }, ConsoleColor.DarkYellow),
            // J
            new Tetromino(new int[,] { { 0, 0, 1 }, { 1, 1, 1 } }, ConsoleColor.Blue)
        };

        private Tetromino(int[,] shape, ConsoleColor color)
        {
            Shape = shape;
            Color = color;
            X = 3; // Starting column (centered on 10-wide board)
            Y = 0;
        }

        public static Tetromino RandomPiece()
        {
            var rnd = new Random();
            return pieces[rnd.Next(pieces.Count)].Clone();
        }

        public Tetromino Clone()
        {
            return new Tetromino((int[,])Shape.Clone(), Color);
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

    // Game board
    class Board
    {
        private int[,] grid; // 0 = empty, >0 = color index or piece ID
        public const int Width = 10;
        public const int Height = 20;

        public Board()
        {
            grid = new int[Height, Width];
        }

        public bool IsCellEmpty(int x, int y)
        {
            if (x < 0 || x >= Width || y < 0 || y >= Height)
                return false; // Out of bounds considered occupied
            return grid[y, x] == 0;
        }

        // Check if piece fits at given position
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

        // Lock the piece into the grid
        public void LockPiece(Tetromino piece)
        {
            for (int i = 0; i < piece.Shape.GetLength(0); i++)
                for (int j = 0; j < piece.Shape.GetLength(1); j++)
                    if (piece.Shape[i, j] != 0)
                    {
                        int y = piece.Y + i;
                        int x = piece.X + j;
                        if (y >= 0 && y < Height && x >= 0 && x < Width)
                            grid[y, x] = 1; // 1 indicates filled, could store color later
                    }
        }

        // Clear full lines and return number cleared
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
                    // Remove line, shift everything down
                    for (int yy = y; yy > 0; yy--)
                        for (int x = 0; x < Width; x++)
                            grid[yy, x] = grid[yy - 1, x];
                    // Top line becomes empty
                    for (int x = 0; x < Width; x++)
                        grid[0, x] = 0;
                    linesCleared++;
                    y++; // Check same line again because it shifted
                }
            }
            return linesCleared;
        }

        // Check if any cell in top row is filled (game over)
        public bool IsGameOver()
        {
            for (int x = 0; x < Width; x++)
                if (grid[0, x] != 0) return true;
            return false;
        }

        // Draw the board and current piece
        public void Draw(Tetromino currentPiece)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Score: " + Game.Score + "  Lines: " + Game.Lines + "  Level: " + Game.Level);
            Console.WriteLine("┌──────────┐");
            for (int y = 0; y < Height; y++)
            {
                Console.Write("│");
                for (int x = 0; x < Width; x++)
                {
                    bool isPieceHere = false;
                    // Check if current piece occupies this cell
                    if (currentPiece != null)
                        for (int i = 0; i < currentPiece.Shape.GetLength(0); i++)
                            for (int j = 0; j < currentPiece.Shape.GetLength(1); j++)
                                if (currentPiece.Shape[i, j] != 0 &&
                                    currentPiece.Y + i == y &&
                                    currentPiece.X + j == x)
                                {
                                    isPieceHere = true;
                                    Console.ForegroundColor = currentPiece.Color;
                                    Console.Write("█");
                                }
                    if (!isPieceHere)
                    {
                        if (grid[y, x] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("·");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("█");
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("│");
            }
            Console.WriteLine("└──────────┘");
        }
    }

    class Game
    {
        private Board board;
        private Tetromino currentPiece;
        private Tetromino nextPiece;
        private bool gameOver;
        private static int score;
        private static int lines;
        private static int level;
        private int fallDelay; // milliseconds
        private DateTime lastFallTime;
        private Random random;

        public static int Score => score;
        public static int Lines => lines;
        public static int Level => level;

        public Game()
        {
            board = new Board();
            random = new Random();
            score = 0;
            lines = 0;
            level = 0;
            fallDelay = 500; // 500 ms start
            nextPiece = Tetromino.RandomPiece();
            SpawnNewPiece();
            gameOver = false;
            lastFallTime = DateTime.Now;
        }

        private void SpawnNewPiece()
        {
            currentPiece = nextPiece;
            nextPiece = Tetromino.RandomPiece();
            // Check if piece fits at spawn position; if not, game over
            if (!board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y))
                gameOver = true;
        }

        public void Run()
        {
            Console.CursorVisible = false;
            Console.Clear();

            while (!gameOver)
            {
                // Handle input
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    HandleInput(key);
                }

                // Automatic falling based on time
                if ((DateTime.Now - lastFallTime).TotalMilliseconds >= fallDelay)
                {
                    MovePieceDown();
                    lastFallTime = DateTime.Now;
                }

                // Draw
                board.Draw(currentPiece);
                DrawNextPiece();
                Thread.Sleep(10); // Small delay to reduce CPU usage
            }

            // Game over screen
            Console.SetCursorPosition(0, Board.Height + 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER! Press R to restart or any key to exit.");
            if (Console.ReadKey(true).Key == ConsoleKey.R)
            {
                // Restart
                new Game().Run();
            }
        }

        private void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (board.PieceFits(currentPiece, currentPiece.X - 1, currentPiece.Y))
                        currentPiece.X--;
                    break;
                case ConsoleKey.RightArrow:
                    if (board.PieceFits(currentPiece, currentPiece.X + 1, currentPiece.Y))
                        currentPiece.X++;
                    break;
                case ConsoleKey.DownArrow:
                    if (board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y + 1))
                        currentPiece.Y++;
                    else
                        LockPiece();
                    break;
                case ConsoleKey.UpArrow:
                    var rotated = currentPiece.Clone();
                    rotated.Rotate();
                    if (board.PieceFits(rotated, currentPiece.X, currentPiece.Y))
                        currentPiece.Rotate();
                    break;
                case ConsoleKey.Spacebar:
                    // Hard drop
                    while (board.PieceFits(currentPiece, currentPiece.X, currentPiece.Y + 1))
                        currentPiece.Y++;
                    LockPiece();
                    break;
            }
        }

        private void MovePieceDown()
        {
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
                // Base score for lines cleared (compatible with C# 7.3)
                int baseScore = 0;
                switch (linesCleared)
                {
                    case 1: baseScore = 100; break;
                    case 2: baseScore = 300; break;
                    case 3: baseScore = 500; break;
                    case 4: baseScore = 800; break;
                }
                score += baseScore * (level + 1);
                // Update level every 10 lines
                level = lines / 10;
                fallDelay = Math.Max(100, 500 - level * 40); // speed up
            }
            SpawnNewPiece();
        }

        private void DrawNextPiece()
        {
            int startX = Board.Width + 5;
            int startY = 2;
            Console.SetCursorPosition(startX, startY - 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Next:");
            for (int i = 0; i < nextPiece.Shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(startX, startY + i);
                for (int j = 0; j < nextPiece.Shape.GetLength(1); j++)
                {
                    Console.ForegroundColor = nextPiece.Color;
                    Console.Write(nextPiece.Shape[i, j] == 1 ? "█" : " ");
                }
            }
        }
    }
}
