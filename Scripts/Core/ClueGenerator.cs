using System.Collections.Generic;

namespace Nonogram.Core
{
    /// <summary>
    /// Generates row and column clues from a nonogram solution.
    /// </summary>
    public static class ClueGenerator
    {
        /// <summary>
        /// Returns clues for each row. Each clue list contains pairs of color index and count.
        /// </summary>
        public static List<List<(int color, int count)>> GetRowClues(int[,] solution)
        {
            int width = solution.GetLength(0);
            int height = solution.GetLength(1);
            var result = new List<List<(int color, int count)>>();

            for (int y = 0; y < height; y++)
            {
                var clues = new List<(int color, int count)>();
                int currentColor = 0;
                int run = 0;
                for (int x = 0; x < width; x++)
                {
                    int color = solution[x, y];
                    if (color == 0)
                    {
                        if (run > 0)
                        {
                            clues.Add((currentColor, run));
                            run = 0;
                        }
                    }
                    else
                    {
                        if (color != currentColor)
                        {
                            if (run > 0)
                                clues.Add((currentColor, run));
                            currentColor = color;
                            run = 1;
                        }
                        else
                        {
                            run++;
                        }
                    }
                }
                if (run > 0)
                    clues.Add((currentColor, run));

                if (clues.Count == 0)
                    clues.Add((0, 0));
                result.Add(clues);
            }

            return result;
        }

        /// <summary>
        /// Returns clues for each column.
        /// </summary>
        public static List<List<(int color, int count)>> GetColumnClues(int[,] solution)
        {
            int width = solution.GetLength(0);
            int height = solution.GetLength(1);
            var result = new List<List<(int color, int count)>>();

            for (int x = 0; x < width; x++)
            {
                var clues = new List<(int color, int count)>();
                int currentColor = 0;
                int run = 0;
                for (int y = 0; y < height; y++)
                {
                    int color = solution[x, y];
                    if (color == 0)
                    {
                        if (run > 0)
                        {
                            clues.Add((currentColor, run));
                            run = 0;
                        }
                    }
                    else
                    {
                        if (color != currentColor)
                        {
                            if (run > 0)
                                clues.Add((currentColor, run));
                            currentColor = color;
                            run = 1;
                        }
                        else
                        {
                            run++;
                        }
                    }
                }
                if (run > 0)
                    clues.Add((currentColor, run));
                if (clues.Count == 0)
                    clues.Add((0, 0));
                result.Add(clues);
            }

            return result;
        }
    }
}
