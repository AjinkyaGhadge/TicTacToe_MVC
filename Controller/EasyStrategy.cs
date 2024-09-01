using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class EasyStrategy : IAIStrategy
    {

        Random random;

        public EasyStrategy()
        {
            this.random = new Random();
        }

        public int GetMove(List<List<int>> grid, int target)
        {
            List<int> availableMoves = new List<int>();

            // Flatten the grid and find available moves
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[i].Count; j++)
                {
                    if (grid[i][j] == -1) // Assuming -1 means unoccupied
                    {
                        int index = i * 3 + j;
                        availableMoves.Add(index+1);
                    }
                }
            }

            if (availableMoves.Count == 0)
            {
                throw new InvalidOperationException("No available moves.");
            }

            // Select a random move from the available moves
            int randomIndex = random.Next(availableMoves.Count);
            return availableMoves[randomIndex];
        }
    }
}