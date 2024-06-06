using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Tic_Tac_Toe
{
    public class Player
    {
        public HashSet<int>? PlayerMovements { get; set; } = new HashSet<int>();
        private bool isYourTurn;
        public Image imageToUse;
        public string playerName;

        public Player(bool _isYourTurn, Image _imageToUse, string _playerName)
        {
            isYourTurn = _isYourTurn;
            imageToUse = _imageToUse;
            playerName = _playerName;
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
