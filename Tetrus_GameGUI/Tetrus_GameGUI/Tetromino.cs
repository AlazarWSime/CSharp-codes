using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tetrus_GameGUI
{
    /// <summary>
    /// Represents a single Tetris puzzle piece (tetromino).
    /// Manages the piece's structural shape, color, location on the board, and rotation logic.
    /// </summary>
    public class Tetromino
    {
        public int[,] Shape { get; private set; }//shape of each 2D array 
        public Color Color { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        private static readonly List<Tetromino> pieces = new List<Tetromino>();

        // A static cache defining the 7 standard modern Tetris shapes and their colors.
        static Tetromino()
        {
            // I-Piece (Line)
            pieces.Add(new Tetromino(new int[,] { { 1, 1, 1, 1 } }, Color.Cyan));
            // O
            pieces.Add(new Tetromino(new int[,] { { 1, 1 }, { 1, 1 } }, Color.Yellow));
            // T
            pieces.Add(new Tetromino(new int[,] { { 0, 1, 0 }, { 1, 1, 1 } }, Color.Magenta));
            // S
            pieces.Add(new Tetromino(new int[,] { { 0, 1, 1 }, { 1, 1, 0 } }, Color.Green));
            // Z
            pieces.Add(new Tetromino(new int[,] { { 1, 1, 0 }, { 0, 1, 1 } }, Color.Red));
            // L
            pieces.Add(new Tetromino(new int[,] { { 1, 0, 0 }, { 1, 1, 1 } }, Color.Orange));
            // J
            pieces.Add(new Tetromino(new int[,] { { 0, 0, 1 }, { 1, 1, 1 } }, Color.Blue));
        }

        private Tetromino(int[,] shape, Color color)
        {
            Shape = shape;
            Color = color;
            X = 3;
            Y = 0;
        }

        /// <summary>
        /// Selects and returns a deep copy of a random tetromino from the standard set.
        /// </summary>
        public static Tetromino RandomPiece() // Ask haileyesus
        {
            var rnd = new Random();
            return pieces[rnd.Next(pieces.Count)].Clone();
        }

        public Tetromino Clone()
        {
            return new Tetromino((int[,])Shape.Clone(), Color);
        }

        /// <summary>
        /// Rotates the tetromino 90 degrees clockwise.
        /// Uses a matrix transpose-like algorithm (swapping rows for columns).
        /// </summary>
        public void Rotate()
        {
            int rows = Shape.GetLength(0);
            int cols = Shape.GetLength(1);
            
            // Create a new grid with swapped dimensions for the rotation.
            int[,] rotated = new int[cols, rows];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    rotated[j, rows - 1 - i] = Shape[i, j];
            Shape = rotated;
        }
    }
}