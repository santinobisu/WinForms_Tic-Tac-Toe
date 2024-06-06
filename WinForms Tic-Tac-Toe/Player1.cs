using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Tic_Tac_Toe
{
    public class Player1
    {
        public HashSet<int>? PlayerMovements { get; set; } = new HashSet<int>();
        private bool isYourTurn;

        public Player1(bool _isYourTurn)
        {
            isYourTurn = _isYourTurn;
        }

        public void setTurnValue(bool b)
        {
            isYourTurn = b;
        }

        public bool getTurnValue()
        {
            return isYourTurn;
        }
    }
}
