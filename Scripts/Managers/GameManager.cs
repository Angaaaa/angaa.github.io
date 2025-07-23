using Nonogram.Core;
using Nonogram.UI;
using UnityEngine;

namespace Nonogram.Managers
{
    /// <summary>
    /// Coordinates overall game flow.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private LevelManager levelManager;
        [SerializeField] private NonogramBoardUI boardUI;

        private NonogramGrid _grid;

        private void Start()
        {
            LoadLevel("level_001");
        }

        public void LoadLevel(string levelId)
        {
            var level = levelManager.LoadLevel(levelId);
            _grid = new NonogramGrid(level.width, level.height);
            _grid.ApplySolution(level.GetSolutionGrid());
            boardUI.CreateBoard(_grid);
            // TODO: create palette and clue UI from level data
        }

        public void CheckForCompletion()
        {
            // TODO: Compare player's input with solution and display win screen
        }
    }
}
