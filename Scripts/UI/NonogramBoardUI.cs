using UnityEngine;
using Nonogram.Core;

namespace Nonogram.UI
{
    /// <summary>
    /// Handles creation and visualization of the nonogram grid and clues.
    /// </summary>
    public class NonogramBoardUI : MonoBehaviour
    {
        [SerializeField] private GameObject cellPrefab;
        [SerializeField] private Transform gridRoot;

        private NonogramGrid _grid;

        public void CreateBoard(NonogramGrid grid)
        {
            _grid = grid;
            // TODO: Instantiate cell UI objects and position them
        }

        public void RefreshBoard()
        {
            // TODO: Update colors and marks on cell UIs
        }
    }
}
