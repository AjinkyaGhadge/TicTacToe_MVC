using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class HardStrategy : IAIStrategy
    {
        Random random;

        public HardStrategy()
        {
            this.random = new Random();
        }


        List<int> GetMoveRandom(List<List<int>> grid)
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
                        availableMoves.Add(index);
                    }
                }
            }

            if (availableMoves.Count == 0)
            {
                throw new InvalidOperationException("No available moves.");
            }
            return availableMoves;
        }


        public int GetMove(List<List<int>> grid, int target)
        {
            // Check for potential winning moves and block them
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (grid[i].Count(x => x == target) == 2 && grid[i].Contains(0))
                {
                    return i * 3 + grid[i].IndexOf(0);
                }

                // Check columns
                if (grid[0][i] == target && grid[1][i] == target && grid[2][i] == 0)
                {
                    return 2 * 3 + i;
                }
                if (grid[0][i] == target && grid[2][i] == target && grid[1][i] == 0)
                {
                    return 1 * 3 + i;
                }
                if (grid[1][i] == target && grid[2][i] == target && grid[0][i] == 0)
                {
                    return 0 * 3 + i;
                }
            }

            // Check diagonals
            if (grid[0][0] == target && grid[1][1] == target && grid[2][2] == 0)
            {
                return 8;
            }
            if (grid[0][0] == target && grid[2][2] == target && grid[1][1] == 0)
            {
                return 4;
            }
            if (grid[1][1] == target && grid[2][2] == target && grid[0][0] == 0)
            {
                return 0;
            }
            if (grid[0][2] == target && grid[1][1] == target && grid[2][0] == 0)
            {
                return 6;
            }
            if (grid[0][2] == target && grid[2][0] == target && grid[1][1] == 0)
            {
                return 4;
            }
            if (grid[1][1] == target && grid[2][0] == target && grid[0][2] == 0)
            {
                return 2;
            }

            // If no blocking move is found, return a random available move
            List<int> availableMoves = new List<int>();
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[i].Count; j++)
                {
                    if (grid[i][j] == 0) // Assuming 0 means unoccupied
                    {
                        int index = i * 3 + j;
                        availableMoves.Add(index);
                    }
                }
            }

            if (availableMoves.Count == 0)
            {
                throw new InvalidOperationException("No available moves.");
            }

            int randomIndex = random.Next(availableMoves.Count);

            List<int> randomMoves = GetMoveRandom(grid);

            int randomIndex2 = random.Next(2);

            if (randomIndex2 == 0)
            {
                return randomMoves[randomIndex];
            }
            else
            {
                return availableMoves[randomIndex];
            }                
        }
    }
}