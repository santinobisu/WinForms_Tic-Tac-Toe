using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Tic_Tac_Toe
{
    public class ButtonUtility
    {

        private readonly Form targetForm;
        public Player player1;
        public Player player2;
        public GameState gameState;

        public ButtonUtility(Form targetForm, Player player1, Player player2, GameState gameState)
        {
            this.targetForm = targetForm;
            this.player1 = player1;
            this.player2 = player2;
            this.gameState = gameState;
        }

        public void gameButtonClick(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            clickedButton.Enabled = false;

            if(player1.getTurnValue())
            {
                playerTurn(player1, gameState, clickedButton);
                player2.setTurnValue(true);
            } else
            {
                playerTurn(player2, gameState, clickedButton);
                player1.setTurnValue(true);
            }
        }

        private void playerTurn(Player player, GameState gameState, Button button)
        {
            int buttonNumber = Convert.ToInt32(button.Tag);

            player.PlayerMovements.Add(buttonNumber);
            button.BackgroundImage = player.imageToUse;
            gameState.restantPositions.Remove(buttonNumber);
            
            foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(buttonNumber))
            {
                if (winningTable.IsSubsetOf(player.PlayerMovements))
                {
                    MessageBox.Show($"{player.playerName} is the winner!");
                    gameState.thereIsWinner = true;
                    targetForm.Close();
                }
            }

            if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
            {
                MessageBox.Show("Tie!");
                targetForm.Close();
            }

            player.setTurnValue(false);
        }
    }
}
