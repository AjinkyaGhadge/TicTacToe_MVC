namespace Controller
{
    public interface IView
    {
        void SetPlayButtonText(string text);
        void SetStatusLabelText(string text);
        void SetPlayer1Name(string text);
        void SetPlayer2Name(string text);
        void UpdateGridButtonText(string button, string text); 
        void ResetGrid();
        void ToggleGridButtons(bool toggle); 
        void EnablePlayButton(bool state);
        void InitializeGame();
    }
}