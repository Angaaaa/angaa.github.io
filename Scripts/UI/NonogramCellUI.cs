using UnityEngine;
using UnityEngine.UI;

namespace Nonogram.UI
{
    /// <summary>
    /// Visual representation for a single cell in the grid.
    /// </summary>
    public class NonogramCellUI : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Image _markImage;

        public void SetColor(Color color)
        {
            if (_image != null)
                _image.color = color;
        }

        public void SetMarked(bool marked)
        {
            if (_markImage != null)
                _markImage.enabled = marked;
        }

        // TODO: Add interaction handlers
    }
}
