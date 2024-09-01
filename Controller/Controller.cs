using System.Diagnostics;
using Model;
using static Model.Model;

namespace Controller
{
    public class Controller
    {
        private Model.Model gameModel;
        private IView view;
        private List<IGridObserver> gridObservers;
        string aiStrategyStr;
        private IAIStrategy aiStrategy;


        public Controller(IView currentView, List<IGridObserver> gridObservers, string aiStrategyStr="Easy", string player1 = "Player1", string player2 = "Player2")
        {
            gameModel = new Model.Model(player1, player2);
            view = currentView;
            aiStrategyStr = aiStrategyStr;
            this.gridObservers = gridObservers;
            foreach(var observer in gridObservers)
            {
                gameModel.Attach(observer);
            }
            if (aiStrategyStr == "Easy")
            {
                this.aiStrategy = new EasyStrategy();
            }
            else if (aiStrategyStr == "Medium")
            {
                this.aiStrategy = new MediumStrategy();
            }
            else if (aiStrategyStr == "Hard")
            {
                this.aiStrategy = new HardStrategy();
            }
        }

        #region Public Methods
        public void HandleGridEvent(int button)
        {
            var coordinate = GetCoordinate(button);
            if (gameModel.currentPlayerID.Equals(gameModel.player1_id))
            {
                gameModel.SetGridValue(coordinate.Item1, coordinate.Item2, 1);
                gameModel.SetPlayer(gameModel.player2_id);
            }
            else
            {
                gameModel.SetGridValue(coordinate.Item1, coordinate.Item2, 0);
                gameModel.SetPlayer(gameModel.player1_id);
            }
            if(gameModel.currentPlayerID == gameModel.player2_id && gameModel.isPlayer2AI)
            {
                int move = aiStrategy.GetMove(gameModel.grid, gameModel.player1_id);
                HandleButtonClick(move);
            }
            else if (gameModel.currentPlayerID == gameModel.player1_id && gameModel.isPlayer1AI)
            {
                int move = aiStrategy.GetMove(gameModel.grid, gameModel.player1_id);
                HandleButtonClick(move);
            }
        }

        public int GetGameStatus()
        {
            var gameResult = CheckThreeInARow();
            return gameResult switch
            {
                GameResult.One => 1,
                GameResult.Zero => 0,
                GameResult.Tie => -1,
                _ => 2,
            };
        }

        public void HandleButtonClick(int button)
        {
            int value = GetGameModelLocationCurrentData(button);
            if (value != -1) return;

            if (gameModel.currentPlayerID == 1)
            {
                view.SetStatusLabelText($"Current Turn: {gameModel.player2_name}");
            }
            else
            {
                view.SetStatusLabelText($"Current Turn: {gameModel.player1_name}");
            }

            HandleGridEvent(button);
            var result = GetGameStatus();
            if (result == -1 || result == 1 || result == 0)
            {
                view.ToggleGridButtons(false);
                view.SetStatusLabelText("Game Over");
                view.SetPlayer1Name("");
                view.SetPlayer2Name("");
                view.EnablePlayButton(true);
            }
        }

        public void HandlePlayButton(string player1, string player2)
        {
            gameModel = new Model.Model(player1, player2);
        }

        public void HandleMouseEnter(int button, string text)
        {
            if (GetGameModelLocationCurrentData(button) != -1) return;

            if (gameModel.currentPlayerID == 0)
            {
                view.UpdateGridButtonText(button.ToString(), "O");
            }
            else
            {
                view.UpdateGridButtonText(button.ToString(), "X");
            }
        }

        public void HandleMouseExit(int button, string text)
        {
            int currentGridValue = GetGameModelLocationCurrentData(button);
            if (currentGridValue != -1)
            {
                view.UpdateGridButtonText(button.ToString(), currentGridValue == 0 ? "O" : "X");
            }
            else
            {
                view.UpdateGridButtonText(button.ToString(), "");
            }
        }

        #endregion

        #region Private Methods

        private GameResult CheckThreeInARow()
        {
            var gridDimensions = gameModel.GetGridDimensions();
            if (gridDimensions.Item1 != 3 || gridDimensions.Item2 != 3)
                throw new ArgumentException("Grid must be 3x3.");

            for (int i = 0; i < 3; i++)
            {
                var rowResult = CheckLine(gameModel.GetGridValue(i, 0), gameModel.GetGridValue(i, 1), gameModel.GetGridValue(i, 2));
                if (rowResult != GameResult.None) return rowResult;

                var colResult = CheckLine(gameModel.GetGridValue(0, i), gameModel.GetGridValue(1, i), gameModel.GetGridValue(2, i));
                if (colResult != GameResult.None) return colResult;
            }

            var mainDiagResult = CheckLine(gameModel.GetGridValue(0, 0), gameModel.GetGridValue(1, 1), gameModel.GetGridValue(2, 2));
            if (mainDiagResult != GameResult.None) return mainDiagResult;

            var antiDiagResult = CheckLine(gameModel.GetGridValue(0, 2), gameModel.GetGridValue(1, 1), gameModel.GetGridValue(2, 0));
            if (antiDiagResult != GameResult.None) return antiDiagResult;

            for (var i = 0; i < 3; i++)
            {
                if (gameModel.GetGridRow(i).Contains(-1))
                    return GameResult.None;
            }
            return GameResult.Tie;
        }

        private GameResult CheckLine(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                if (a == 0) return GameResult.Zero;
                if (a == 1) return GameResult.One;
            }
            return GameResult.None;
        }

        private Tuple<int, int> GetCoordinate(int digit, int grid = 3)
        {
            if (digit < 1 || digit > 9)
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit must be between 1 and 9.");

            int row = (digit - 1) / grid;
            int col = (digit - 1) % grid;

            return Tuple.Create(row, col);
        }

        private int GetGameModelLocationCurrentData(int button)
        {
            var coordinates = GetCoordinate(button);
            return gameModel.GetGridValue(coordinates.Item1, coordinates.Item2);
        }

        public void UpdateAIPlay(string text, int v)
        {
            if (text == "Easy")
            {
                this.aiStrategy = new EasyStrategy();
            }
            else if (text == "Medium")
            {
                this.aiStrategy = new MediumStrategy();
            }
            else if (text == "Hard")
            {
                this.aiStrategy = new HardStrategy();
            }

            if(v == 0)
            {
                gameModel.isPlayer1AI = true;
            }
            else if(v == 1)
            {
                gameModel.isPlayer2AI = true;
            }
        }

        public void FirstAIMove()
        {
            if (gameModel.isPlayer1AI)
            {
                int move = aiStrategy.GetMove(gameModel.grid, gameModel.player1_id);
                HandleGridEvent(move);
            }
        }

        #endregion
    }
}