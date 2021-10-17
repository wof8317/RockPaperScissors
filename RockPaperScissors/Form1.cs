using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string Computer;//What the computer selects
        string[] computer = { "Rock", "Paper", "Scissor" };//A list of strings to pick randomly
        Random random = new Random();
        int RandomType;
        string PlayerPicks;//What the user picks

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayerPicks = "Rock";//User picks rock
            RandomType = random.Next(0, 3);//Random selection for computer
            Computer = computer[RandomType];//FINALLY, Computer selects Rock, paper, or scissor at random.
            Game();//Where the real fun begins
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayerPicks = "Paper";//Same as Rock
            RandomType = random.Next(0, 3);//Same as Rock
            Computer = computer[RandomType];//Same as Rock
            Game();//Where the real fun begins
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            PlayerPicks = "Scissor";// Same as Rock and Paper
            RandomType = random.Next(0, 3);
            Computer = computer[RandomType];
            Game();
        }

        void Game()
        {
            /*
             * This function calculates the outcome of the game and who wins, loses, or if there is a tie, occurs.
             * Example: if user chooses Rock, and the Computer randomly chooses Paper, both choices will be printed and
             * print the outcome of "You Lose".
             */
            if (PlayerPicks == "Rock" && Computer == "Paper")
            {
                btnUserChoice.Text = PlayerPicks;
                btnComputerChoice.Text = Computer;
                txtBoxOutcome.Text = "You Lose";
            }
            else if (PlayerPicks == "Rock" && Computer == "Scissor")
            {
                btnUserChoice.Text = PlayerPicks;
                btnComputerChoice.Text = Computer;
                txtBoxOutcome.Text = "You Win";
            }
            else if (PlayerPicks == "Paper" && Computer == "Scissor")
            {
                btnUserChoice.Text = PlayerPicks;
                btnComputerChoice.Text = Computer;
                txtBoxOutcome.Text = "You Lose";
            }
            else if (PlayerPicks == "Paper" && Computer == "Rock")
            {
                btnUserChoice.Text = PlayerPicks;
                btnComputerChoice.Text = Computer;
                txtBoxOutcome.Text = "You Win";
            }
            else if (PlayerPicks == "Scissor" && Computer == "Rock")
            {
                btnUserChoice.Text = PlayerPicks;
                btnComputerChoice.Text = Computer;
                txtBoxOutcome.Text = "You Lose";
            }
            else if (PlayerPicks == "Scissor" && Computer == "Paper")
            {
                btnUserChoice.Text = PlayerPicks;
                btnComputerChoice.Text = Computer;
                txtBoxOutcome.Text = "You Win";
            }
            else
            {
                if (PlayerPicks == "Rock" && Computer == "Rock")
                {
                    btnUserChoice.Text = PlayerPicks;
                    btnComputerChoice.Text = Computer;
                    txtBoxOutcome.Text = "Tie";
                }
                else if (PlayerPicks == "Paper" && Computer == "Paper")
                {
                    btnUserChoice.Text = PlayerPicks;
                    btnComputerChoice.Text = Computer;
                    txtBoxOutcome.Text = "Tie";
                }
                else if (PlayerPicks == "Scissor" && Computer == "Scissor")
                {
                    btnUserChoice.Text = PlayerPicks;
                    btnComputerChoice.Text = Computer;
                    txtBoxOutcome.Text = "Tie";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnComputerChoice.Text = "";
            btnUserChoice.Text = "";
            txtBoxOutcome.Clear();
        }
    }
}
