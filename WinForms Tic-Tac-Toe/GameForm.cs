using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Tic_Tac_Toe
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            GameState gameState = new GameState();
            Player player1 = new Player(true, Properties.Resources.X, "Player 1");
            Player player2 = new Player(false, Properties.Resources.O, "Player 2");
            ButtonUtility buttonClickUtility = new ButtonUtility(this, player1, player2, gameState);

            Button_1.Click += buttonClickUtility.gameButtonClick;
            Button_2.Click += buttonClickUtility.gameButtonClick;
            Button_3.Click += buttonClickUtility.gameButtonClick;
            Button_4.Click += buttonClickUtility.gameButtonClick;
            Button_5.Click += buttonClickUtility.gameButtonClick;
            Button_6.Click += buttonClickUtility.gameButtonClick;
            Button_7.Click += buttonClickUtility.gameButtonClick;
            Button_8.Click += buttonClickUtility.gameButtonClick;
            Button_9.Click += buttonClickUtility.gameButtonClick;
        }
    }
}
