using UnityEngine;

namespace Nonogram.Core
{
    /// <summary>
    /// Represents a single cell on the nonogram grid.
    /// </summary>
    public class NonogramCell
    {
        /// <summary>
        /// Index in the palette. 0 means empty.
        /// </summary>
        public int ColorIndex { get; set; }

        /// <summary>
        /// Whether the player marked this cell as unsure/temporary.
        /// </summary>
        public bool IsMarked { get; set; }

        public NonogramCell(int colorIndex = 0)
        {
            ColorIndex = colorIndex;
            IsMarked = false;
        }
    }
}
