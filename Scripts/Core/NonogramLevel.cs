using System.IO;
using UnityEngine;

namespace Nonogram.Core
{
    /// <summary>
    /// Represents level data loaded from a JSON file.
    /// </summary>
    [System.Serializable]
    public class NonogramLevel
    {
        public string levelId;
        public int width;
        public int height;
        public string[] palette;
        public int[][] solution;

        /// <summary>
        /// Load a NonogramLevel from a JSON text asset.
        /// </summary>
        public static NonogramLevel LoadFromJson(string jsonPath)
        {
            var text = File.ReadAllText(jsonPath);
            return JsonUtility.FromJson<NonogramLevel>(text);
        }

        /// <summary>
        /// Convert solution jagged array to 2D int array.
        /// </summary>
        public int[,] GetSolutionGrid()
        {
            int[,] grid = new int[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[x, y] = solution[y][x];
                }
            }
            return grid;
        }
    }
}
