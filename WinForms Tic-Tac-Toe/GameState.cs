﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Tic_Tac_Toe
{
    public class GameState
    {
        public HashSet<int> restantPositions = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public bool thereIsWinner = false;
    }
}
