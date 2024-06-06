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
        }

        GameState gameState = new GameState();
        Player1 player1 = new Player1(true);
        Player2 player2 = new Player2(false);

        private void Button_1_Click(object sender, EventArgs e)
        {
            Button_1.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(1);
                Button_1.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(1);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(1))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_1.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(1);
                gameState.restantPositions.Remove(1);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(1))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }
        private void Button_2_Click_1(object sender, EventArgs e)
        {
            Button_2.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(2);
                Button_2.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(2);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(2))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_2.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(2);
                gameState.restantPositions.Remove(2);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(2))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner) 
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }
        private void Button_3_Click_1(object sender, EventArgs e)
        {
            Button_3.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(3);
                Button_3.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(3);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(3))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_3.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(3);
                gameState.restantPositions.Remove(3);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(3))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }
        private void Button_4_Click(object sender, EventArgs e)
        {
            Button_4.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(4);
                Button_4.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(4);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(4))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_4.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(4);
                gameState.restantPositions.Remove(4);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(4))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }
        private void Button_5_Click(object sender, EventArgs e)
        {
            Button_5.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(5);
                Button_5.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(5);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(5))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_5.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(5);
                gameState.restantPositions.Remove(5);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(5))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            Button_6.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(6);
                Button_6.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(6);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(6))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_6.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(6);
                gameState.restantPositions.Remove(6);


                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(6))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            Button_7.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(7);
                Button_7.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(7);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(7))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_7.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(7);
                gameState.restantPositions.Remove(7);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(7))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            Button_8.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(8);
                Button_8.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(8);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(8))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_8.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(8);
                gameState.restantPositions.Remove(8);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(8))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            Button_9.Enabled = false;

            if (player1.getTurnValue())
            {
                player1.PlayerMovements.Add(9);
                Button_9.BackgroundImage = Properties.Resources.X;
                gameState.restantPositions.Remove(9);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(9))
                {
                    if (winningTable.IsSubsetOf(player1.PlayerMovements))
                    {
                        MessageBox.Show("Player 1 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player1.setTurnValue(false);
                player2.setTurnValue(true);
            }
            else
            {
                Button_9.BackgroundImage = Properties.Resources.O;
                player2.PlayerMovements.Add(9);
                gameState.restantPositions.Remove(9);

                foreach (HashSet<int> winningTable in WinningMovements.winningMovementsWithN(9))
                {
                    if (winningTable.IsSubsetOf(player2.PlayerMovements))
                    {
                        MessageBox.Show("Player 2 is the Winner!");
                        gameState.thereIsWinner = true;
                        this.Close();
                    }
                }

                if (gameState.restantPositions.Count == 0 && !gameState.thereIsWinner)
                {
                    MessageBox.Show("Tie!");
                    this.Close();
                }

                player2.setTurnValue(false);
                player1.setTurnValue(true);
            }
        }
    }
}
