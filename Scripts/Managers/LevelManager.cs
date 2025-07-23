using Nonogram.Core;
using System.IO;
using UnityEngine;

namespace Nonogram.Managers
{
    /// <summary>
    /// Responsible for loading levels from resources and creating grid data.
    /// </summary>
    public class LevelManager : MonoBehaviour
    {
        public string LevelsPath = "Resources/Levels";

        public NonogramLevel LoadLevel(string levelId)
        {
            string path = Path.Combine(LevelsPath, levelId + ".json");
            // In a real project, use Resources.Load<TextAsset>
            return NonogramLevel.LoadFromJson(path);
        }
    }
}
