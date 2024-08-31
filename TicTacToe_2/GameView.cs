using Controller;
using System.Diagnostics;
using System.Windows.Forms;

namespace TicTacToe_2
{
    public partial class GameView : Form, IView
    {
        View.ThemeManager themeManager = new View.ThemeManager();
        public GameView()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Player1NameBox.Text) || string.IsNullOrEmpty(Player2NameBox.Text))
            {
                MessageBox.Show("Enter player names before starting");
                return;
            }
            else
            {
                Player1NameBox.Enabled = false;
                Player2NameBox.Enabled = false;
            }
            ResetGrid();
            ToggleGridButtons(true);
            gameController.HandlePlayButton(Player1NameBox.Text, Player2NameBox.Text);
            PlayButton.Enabled = false;
        }

        public void EnablePlayButton(bool state)
        {
            PlayButton.Enabled = state;
            Player1NameBox.Enabled = true;
            Player2NameBox.Enabled = true;
        }

        private void GridButton_MouseEnter(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            int buttonId = int.Parse(currButton.Name);
            gameController.HandleMouseEnter(buttonId, currButton.Text);
        }

        private void GridButton_MouseLeave(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            int buttonId = int.Parse(currButton.Name);
            gameController.HandleMouseExit(buttonId, currButton.Text);
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonId = int.Parse(button.Name);
            gameController.HandleButtonClick(buttonId);
        }

        public void InitializeGame()
        {
            ResetGrid();
            SetPlayer1Name("");
            SetPlayer2Name("");
            SetStatusLabelText("Click Play to Start");
            ToggleGridButtons(false);
        }

        public void SetPlayButtonText(string text)
        {
            PlayButton.Text = text;
        }

        public void SetStatusLabelText(string text)
        {
            StatusLabel.Text = text;
        }

        public void SetPlayer1Name(string text)
        {
            Player1NameBox.Text = text;
        }

        public void SetPlayer2Name(string text)
        {
            Player2NameBox.Text = text;
        }

        public void UpdateGridButtonText(string button, string text)
        {
            switch (button)
            {
                case "1": button1.Text = text; break;
                case "2": button2.Text = text; break;
                case "3": button3.Text = text; break;
                case "4": button4.Text = text; break;
                case "5": button5.Text = text; break;
                case "6": button6.Text = text; break;
                case "7": button7.Text = text; break;
                case "8": button8.Text = text; break;
                case "9": button9.Text = text; break;
                default:
                    Trace.TraceError("No button of type " + button + " in grid");
                    throw new ArgumentException("Button of type " + button + " is not present in grid");
            }
        }

        public void ResetGrid()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
        }

        public void ToggleGridButtons(bool toggle)
        {
            button1.Enabled = toggle;
            button2.Enabled = toggle;
            button3.Enabled = toggle;
            button4.Enabled = toggle;
            button5.Enabled = toggle;
            button6.Enabled = toggle;
            button7.Enabled = toggle;
            button8.Enabled = toggle;
            button9.Enabled = toggle;
        }

        private void ChangeThemeButton_Click(object sender, EventArgs e)
        {
            SwitchTheme(sender, e);
        }

        private void SwitchTheme(object sender, EventArgs e)
        {
            themeManager.SwitchToNextTheme();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var currentTheme = themeManager.GetCurrentTheme();
            this.BackColor = currentTheme.BackgroundColor;
            this.ForeColor = currentTheme.ForegroundColor;
            foreach (Control control in this.Controls)
            {
                control.BackColor = currentTheme.BackgroundColor;
                control.ForeColor = currentTheme.ForegroundColor;
            }
            this.Text = $"Theme Switcher - {currentTheme.Name} Theme";
        }
    }
}