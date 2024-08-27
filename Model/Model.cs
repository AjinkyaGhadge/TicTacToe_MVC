using System.Diagnostics;

namespace Model
{
    public class Model
    {
        #region private members
        public string player1_name { get; set; } = string.Empty;
        public string player2_name { get; set; } = string.Empty;
        public int player1_id { get; private set; }
        public int player2_id { get; private set; }
        public int currentPlayerID { get; private set; }
        private int number_of_turns;
        public List<List<int>> grid { get; private set; }

        TraceListener fileListener;
        #endregion

        public enum GameResult
        {
            None,  // No winner
            Zero,  // Player 0 wins
            One,   // Player 1 wins
            Tie    // All possible rows, columns, and diagonals are filled and no winner
        }

        #region Constructors
        public Model(string p1_name = "Player X", string p2_name = "Player Y")
        {
            player1_name = p1_name;
            player2_name = p2_name;
            player1_id = 1;
            player2_id = 0;
            grid = new List<List<int>>();

            // Fill the grid with default values (e.g., 0)
            for (int i = 0; i < 3; i++)
            {
                // Create a new list for each row
                List<int> row = new List<int>();

                for (int j = 0; j < 3; j++)
                {
                    // Add default values to each cell
                    row.Add(-1); // Replace 0 with any default value
                }

                // Add the row to the grid
                grid.Add(row);
            }
            number_of_turns = 0;
            currentPlayerID = player1_id;

            fileListener = new TextWriterTraceListener("trace.log");
            Trace.Listeners.Add(fileListener);
        }
        #endregion

        public void setGridValue(int xCoordinate, int yCoordinate, int value)
        {
            try
            {
                this.grid[xCoordinate][yCoordinate] = value;
            }
            catch(Exception  e) 
            { 
                Trace.WriteLine("Error updating value "+value+" for "+xCoordinate+", "+yCoordinate + ".Due to Exception " + e);
            }
        }

        public int getGridValue(int xCoordinate, int yCoordinates)
        {
            try
            {
                int value = grid[xCoordinate][yCoordinates];
                return value;
            }
            catch (Exception E)
            {
                Trace.WriteLine("Error occured: " + E);
                return -2;
            }
        }
        public void setPlayer(int playerID)
        {
            try
            {
                currentPlayerID = playerID;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Error updating value due to exception: " + e);
            }
        }
        public List<int> getGridRow(int xCoordinate)
        {
            return grid[xCoordinate];
        }

        public Tuple<int,int> getGridDimmensions()
        {
            return new Tuple<int,int>(grid.Count, grid[0].Count);
        }
    }

}
