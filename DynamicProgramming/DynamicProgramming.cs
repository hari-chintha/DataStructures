using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStuctures.DynamicProgramming
{
    public class DynamicProgramming
    {
        //0,1,1,2,3,5,8,13,21....n
        public static int Fib(int n)
        {
            int[] memo = new int[n + 2];
            memo[0] = 0;
            memo[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                memo[i] = memo[i - 2] + memo[i - 1];
            }
            return memo[n];
        }
        public static bool[,] inputGrid = new bool[8, 8] {
                                        { true, true, true,true,true,true,true,true },
                                        { true, true, false,true,true,true,false,true },
                                        { true, true, true,true,false,true,true,true },
                                        { false, true, false,true,true,false,true,true },
                                        { true, true, false,true,true,true,true,true },
                                        { true, true, true,false,false,true,false,true },
                                        { true, false, true,true,true,false,true,true },
                                        { true, true, true,true,true,true,true,true }};

        public static int[,] paths = new int[8, 8];
        public static int CountPaths(bool[,] grid, int row, int col, int[,] paths)
        {
            
            if (!IsValidSquare(grid, row, col))
            {
                return 0;
            }
            if (IsAtEnd(grid, row, col))
            {
                return 1;
            }
            if(paths[row,col] == 0)
            {
                paths[row, col] = CountPaths(grid, row + 1, col,paths) + CountPaths(grid, row, col + 1,paths);
            }
            return paths[row,col];
        }

        private static bool IsValidSquare(bool[,] grid, int row, int col)
        {
            try
            {
                return grid[row, col];
            }
            catch(Exception)
            {

                return false;
            }
        }
        private static bool IsAtEnd(bool[,] grid, int row, int col)
        {
            return row * col == grid.Length;
        }
    }
}
