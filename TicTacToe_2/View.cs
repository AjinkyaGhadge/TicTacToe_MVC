namespace TicTacToe_2
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            Toggle_All_Button(true);

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

                //gameModel.player1_name = Player1NameBox.Text;
                //gameModel.player2_name = Player2NameBox.Text;
            }

            Button currButton = (Button)sender;
            if (currButton.Text == "PLAY" && StatusLabel.Text == "Game Over")
            {
                InitializeGame();
            }
            else
            {
                Toggle_All_Button(true);
                //StatusLabel.Text = $"Current Turn: {gameModel.player1_name}";
            }
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            Tuple<bool, string> response = gameController.onMouseEnter(button_in_int, currButton.Text);
            if (response.Item1)
            {
                currButton.Text = response.Item2;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            Tuple<bool, string> response = gameController.onMouseExit(button_in_int, currButton.Text);
            if (response.Item1)
            {
                currButton.Text = response.Item2;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (getGameModelLocationCurrentData(sender, e) != -1)
            {
                return;
            }

            else
            {
                Button currButton = (Button)sender;

                int button_in_int = int.Parse(currButton.Name);
                //if (gameModel.currentPlayerID == 1)
                //{
                //    currButton.Text = "X";
                //    StatusLabel.Text = $"Current Turn: {gameModel.player2_name}";
                //}
                //else
                //{
                //    currButton.Text = "O";
                //    StatusLabel.Text = $"Current Turn: {gameModel.player1_name}";
                //}
                //gameModel.OnGridEvent(button_in_int);
                //var result = gameModel.CheckGameStatus();
                //if (result == -1 || result == 1 || result == 0)
                //{
                //    Toggle_All_Button(false);
                //    StatusLabel.Text = "Game Over";
                //    Player1NameBox.Text = "";
                //    Player2NameBox.Text = "";
                //}
            }
        }

        private int getGameModelLocationCurrentData(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            //Tuple<int, int> corrdinates = getCoordinate(button_in_int);
            //return gameModel.grid[corrdinates.Item1][corrdinates.Item2
            return 1;
        }

        private void Toggle_All_Button(bool toggle)
        {
            if (toggle is false)
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
            else
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
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void InitializeGame()
        {
            ResetGameButton();
            ResetPlayer1NameBox();
            ResetPlayer2NameBox();
            ResetGameLabel();
            Toggle_All_Button(true);
        }

        private void ResetGameButton()
        {
            //button1.Text = String.Empty;
            //gameModel.grid[0][0] = -1;
            //button2.Text = String.Empty;
            //gameModel.grid[0][1] = -1;
            //button3.Text = String.Empty;
            //gameModel.grid[0][2] = -1;
            //button4.Text = String.Empty;
            //gameModel.grid[1][0] = -1;
            //button5.Text = String.Empty;
            //gameModel.grid[1][1] = -1;
            //button6.Text = String.Empty;
            //gameModel.grid[1][2] = -1;
            //button7.Text = String.Empty;
            //gameModel.grid[2][0] = -1;
            //button8.Text = String.Empty;
            //gameModel.grid[2][1] = -1;
            //button9.Text = String.Empty;
            //gameModel.grid[2][2] = -1;
        }



        private void ResetPlayButton()
        {
            PlayButton.Text = "PLay";
        }

        private void ResetPlayer1NameBox()
        {
            Player1NameBox.Text = String.Empty;
        }

        private void ResetPlayer2NameBox()
        {
            Player2NameBox.Text = String.Empty;
        }

        private void ResetGameLabel()
        {
            StatusLabel.Text = "Click Play to Start";
        }
    }
}
