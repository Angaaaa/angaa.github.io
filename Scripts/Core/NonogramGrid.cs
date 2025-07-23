using System;

namespace Nonogram.Core
{
    /// <summary>
    /// Holds all cells for a nonogram puzzle.
    /// </summary>
    public class NonogramGrid
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public NonogramCell[,] Cells { get; private set; }

        public NonogramGrid(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new NonogramCell[width, height];
            InitializeCells();
        }

        private void InitializeCells()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Cells[x, y] = new NonogramCell();
                }
            }
        }

        /// <summary>
        /// Apply a solution grid (color indexes) to this grid.
        /// </summary>
        public void ApplySolution(int[,] solution)
        {
            if (solution.GetLength(0) != Width || solution.GetLength(1) != Height)
                throw new ArgumentException("Solution dimensions do not match grid size.");

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Cells[x, y].ColorIndex = solution[x, y];
                }
            }
        }
    }
}
