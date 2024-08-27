using System.Diagnostics;
using System.Reflection;
using System.Xml.Schema;
using Model;
using static Model.Model;

namespace Controller
{
    public class Controller
    {
        private Model.Model gameModel;

        public Controller(string player_1 = "Player1", string player_2= "Player2") 
        {
            gameModel = new Model.Model(player_1,player_2);
        }

        public void resetModel(string player1Name, string player2Name)
        {
            gameModel = new Model.Model(player1Name, player2Name);
        }
        public void OnGridEvent(int button)
        {
            Tuple<int, int> coordinate = getCoordinate(button);
            if (gameModel.currentPlayerID.Equals(gameModel.player1_id))
            {
                gameModel.setGridValue(coordinate.Item1, coordinate.Item2, 1);
                gameModel.setPlayer(gameModel.player2_id);
            }
            else
            {
                gameModel.setGridValue(coordinate.Item1, coordinate.Item2, 0);
                gameModel.setPlayer(gameModel.player1_id);
            }
        }

        #region helper functions
        //This needs to be moved to the controller
        private GameResult CheckThreeInARow()
        {
            // Validate grid size
            Tuple<int, int> gridXYvalues = gameModel.getGridDimmensions();
            if (gridXYvalues.Item1 != 3 || gridXYvalues.Item2 != 3)
                throw new ArgumentException("Grid must be 3x3.");

            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                GameResult rowResult = CheckLine(gameModel.getGridValue(i,0), gameModel.getGridValue(i, 1), gameModel.getGridValue(i, 2));
                if (rowResult != GameResult.None) return rowResult;

                GameResult colResult = CheckLine(gameModel.getGridValue(0, i), gameModel.getGridValue(1, i), gameModel.getGridValue(2, i));
                if (colResult != GameResult.None) return colResult;
            }

            // Check diagonals
            GameResult mainDiagResult = CheckLine(gameModel.getGridValue(0, 0), gameModel.getGridValue(1, 1), gameModel.getGridValue(2, 2));
            if (mainDiagResult != GameResult.None) return mainDiagResult;

            GameResult antiDiagResult = CheckLine(gameModel.getGridValue(0, 2), gameModel.getGridValue(1, 1), gameModel.getGridValue(2, 0));
            if (antiDiagResult != GameResult.None) return antiDiagResult;

            // Check for tie
            for (var i = 0;i<3;i++)
            {
                if (gameModel.getGridRow(i).Contains(-1))// Assuming -1 is used for empty cells
                    return GameResult.None;// Not a tie yet
            }
            return GameResult.Tie;
        }

        //This need to move to controller
        private GameResult CheckLine(int a, int b, int c)
        {
            // Check if all elements in the line are the same and either 0 or 1
            if (a == b && b == c)
            {
                if (a == 0) return GameResult.Zero;
                if (a == 1) return GameResult.One;
            }
            return GameResult.None;
        }

        //Move this to controller
        public Tuple<int, int> getCoordinate(int digit, int grid = 3)
        {
            if (digit < 1 || digit > 9)
                throw new ArgumentOutOfRangeException("digit", "Digit must be between 1 and 9.");

            int row = (digit - 1) / grid;
            int col = (digit - 1) % grid;

            return Tuple.Create(row, col);
        }

        public int CheckGameStatus()
        {
            GameResult gameResult = CheckThreeInARow();
            if (gameResult == GameResult.One)
            {
                return 1;
            }
            if (gameResult == GameResult.Zero)
            {
                return 0;
            }
            if (gameResult == GameResult.Tie)
            {
                return -1;
            }
            if (gameResult == GameResult.None)
            {
                return 2;
            }
            return 2;
        }

        public Tuple<bool,string> onMouseEnter(int button,string text)
        {
            if (getGameModelLocationCurrentData(button) != -1)
            {
                return new Tuple<bool,string>(false,text);
            }
            if (gameModel.currentPlayerID == 0)
            {
                return new Tuple<bool, string>(true, "O");
            }
            else
            {
                return new Tuple<bool, string>(true, "X");
            }
        }

        public Tuple<bool, string> onMouseExit(int button, string text)
        {
            if (getGameModelLocationCurrentData(button) != -1)
            {
                return new Tuple<bool, string>(false, text);
            }
            else
            {
                return new Tuple<bool, string>(true, "");
            }
        }

        private int getGameModelLocationCurrentData(int button)
        {
            Tuple<int, int> corrdinates = getCoordinate(button);
            return gameModel.getGridValue(corrdinates.Item1, corrdinates.Item2);
        }


        #endregion

    }
}
