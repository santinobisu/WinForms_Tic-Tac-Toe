using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Tic_Tac_Toe
{
    public static class WinningMovements
    {
        public static List<HashSet<int>> winningList = new List<HashSet<int>>()
        {
            new HashSet<int>() {1, 2, 3},
            new HashSet<int>() {4, 5, 6},
            new HashSet<int>() {7, 8, 9},
            new HashSet<int>() {1, 4, 7},
            new HashSet<int>() {2, 5, 8},
            new HashSet<int>() {3, 6, 9},
            new HashSet<int>() {1, 5, 9},
            new HashSet<int>() {3, 5, 7},
        };

        public static List<HashSet<int>> winningMovementsWithN(int n)
        {
            List<HashSet<int>> output;

            switch(n)
            {
                case 1:
                    output = new List<HashSet<int>> { winningList[0], winningList[3], winningList[6] };
                    break;
                case 2:
                    output = new List<HashSet<int>> { winningList[0], winningList[4] };
                    break;
                case 3:
                    output = new List<HashSet<int>> { winningList[0], winningList[5], winningList[7] };
                    break;
                case 4:
                    output = new List<HashSet<int>> { winningList[1], winningList[3] };
                    break;
                case 5:
                    output = new List<HashSet<int>> { winningList[1], winningList[4], winningList[6] };
                    break;
                case 6:
                    output = new List<HashSet<int>> { winningList[1], winningList[5] };
                    break;
                case 7:
                    output = new List<HashSet<int>> { winningList[2], winningList[3], winningList[7] };
                    break;
                case 8:
                    output = new List<HashSet<int>> { winningList[2], winningList[4] };
                    break;
                default:
                    output = new List<HashSet<int>> { winningList[2], winningList[5], winningList[6] };
                    break;
            }

            return output;
        }
    }
}
