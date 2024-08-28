using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IView
    {
        void SetPlayButtonText(string text);
        void SetStatusLabelText(string text);
        void SetPlayer1Name(string text);
        void SetPlayer2Name(string text);
        void UpdateGridButton(string button, string text);
        void ResetGrid();
        void ToggleGrid(bool toggle);
        void enablePlayButton(bool state);
        void InitializeGame();
    }
}
