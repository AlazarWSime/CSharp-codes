using Tetrus_GameGUI;

namespace Tetrus_GameGUI
{
    /// <summary>
    /// Represents the game grid matrix where standard inactive blocks reside.
    /// Responsible for collision detection, piece locking, and resolving full lines.
    /// </summary>
    public class Board
    {
        private int[,] grid;
        public const int Width = 10;
        public const int Height = 20;

        public Board()
        {
            grid = new int[Height, Width];
        }

        /// <summary>
        /// Validates that an active Tetromino can safely exist at the given target coordinates.
        /// Checks against board boundaries and previously locked blocks.
        /// </summary>
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

        /// <summary>
        /// Permanently anchors an active piece onto the grid matrix once it can't fall any further.
        /// </summary>
        public void LockPiece(Tetromino piece)
        {
            for (int i = 0; i < piece.Shape.GetLength(0); i++)
                for (int j = 0; j < piece.Shape.GetLength(1); j++)
                    if (piece.Shape[i, j] != 0)
                    {
                        int y = piece.Y + i;
                        int x = piece.X + j;
                        if (y >= 0 && y < Height && x >= 0 && x < Width)
                            grid[y, x] = 1;
                    }
        }

        /// <summary>
        /// Scans the grid from bottom to top for solidly filled rows.
        /// Removes filled rows, drops blocks above downwards, and returns the number of cleared rows.
        /// </summary>
        public int ClearLines()
        {
            int linesCleared = 0;
            
            // Iterate directly from bottom block row up to the top.
            for (int y = Height - 1; y >= 0; y--)
            {
                bool full = true;
                for (int x = 0; x < Width; x++)
                    if (grid[y, x] == 0) { full = false; break; }

                if (full)
                {
                    // Shift all elements in lines above this one downwards by 1 row
                    for (int yy = y; yy > 0; yy--)
                        for (int x = 0; x < Width; x++)
                            grid[yy, x] = grid[yy - 1, x];
                    
                    // Clear the absolute top row to 0
                    for (int x = 0; x < Width; x++)
                        grid[0, x] = 0;
                    
                    linesCleared++;
                    // Keep the index on the same row, in case the row that just dropped down is also full.
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

        public int GetCell(int x, int y) => grid[y, x];
    }
}