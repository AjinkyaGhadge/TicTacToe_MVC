using Controller;
using System.Diagnostics;
namespace TicTacToe_2
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (Player1NameBox.Text == string.Empty || Player2NameBox.Text == string.Empty)
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
            ToggleGrid(true);
            gameController.onPlayButton(Player1NameBox.Text, Player2NameBox.Text);
            PlayButton.Enabled = false;
        }

        public void enablePlayButton (bool state)
        {
            PlayButton.Enabled = state;
            if (Player1NameBox.Enabled is not true)
            {
                Player1NameBox.Enabled = true;
            }
            if (Player2NameBox.Enabled is not true) 
            { 
                Player2NameBox.Enabled= true;
            }
        }
        
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            gameController.onMouseEnter(button_in_int, currButton.Text);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            gameController.onMouseExit(button_in_int, currButton.Text);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int button = int.Parse(b.Name);
            gameController.onButtonClick(button);
        }

        public void InitializeGame()
        {
            ResetGrid();
            SetPlayer1Name("");
            SetPlayer2Name("");
            SetStatusLabelText("Click Play to Start");
            ToggleGrid(false);
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

        public void UpdateGridButton(string button,string text)
        {
            switch (button)
            {
                case "1": button1.Text = text;
                    break;
                case "2": button2.Text = text;
                    break;
                case "3": button3.Text = text;
                    break;
                case "4": button4.Text = text;
                    break;
                case "5": button5.Text = text;
                    break;
                case "6": button6.Text = text;
                    break;
                case "7": button7.Text = text;
                    break;
                case "8": button8.Text = text;
                    break;
                case "9": button9.Text = text;
                    break;
                default: Trace.TraceError("No button of type " + button + "in grid");
                    throw new ArgumentException("Button of type "+button+" is not present in grid");
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

        public void ToggleGrid(bool toggle)
        {
            if(toggle)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

        }
    }
}
