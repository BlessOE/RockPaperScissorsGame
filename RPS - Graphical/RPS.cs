using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RPS___Graphical
{
    public partial class RPS : Form
    {
        // Data
        Image rock, rock45, paper, scissors, rockC, paperC, scissorsC;

        int compScore = 0;
        int playerScore = 0;

        // int i = 0;

        public RPS(string name)
        {
            InitializeComponent();

            rock = Image.FromFile("Rock_normal.jpg");
            rockC = Image.FromFile("Rock_comp.jpg");
            rock45 = Image.FromFile("Rock_45.jpg");
            paper = Image.FromFile("Paper_normal.jpg");
            paperC = Image.FromFile("Paper_comp.jpg");
            scissors = Image.FromFile("Scissors_normal.jpg");
            scissorsC = Image.FromFile("Scissors_comp.jpg");

            ClientSize = new Size(2000, 1500);

            lblPlayerScore.Text = Convert.ToString(playerScore);
            lblCompScore.Text = Convert.ToString(compScore);

            lblPlayer.Text = name;

            lblComments.Text = ("This game is best of 5");

            lblStatus.Text = name + " pick between Rock, Paper or Scissors";
        }

        // player choice: rock
        private void btnRock_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = rock;
            int num = new Random().Next(1, 4);

            if (num == 1)
            {
                pbComputer.Image = rockC;
                Draw();
            }
            else if (num == 2)
            {
                pbComputer.Image = paperC;
                CompWins();
                
            }
            else if (num == 3)
            {
                pbComputer.Image = scissorsC;
                PlayerWins();
            }

            comments();

            bestOf5();

        }

        // player choice: paper
        private void btnPaper_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = paper;
            int num = new Random().Next(1, 4);

            if (num == 2)
            {
                pbComputer.Image = paperC;
                Draw();
            }
            else if (num == 3)
            {
                pbComputer.Image = scissorsC;
                CompWins();
            }
            else if (num == 1)
            {
                pbComputer.Image = rockC;
                PlayerWins();
            }

            comments();

            bestOf5();

        }

        // player choice: scissors
        private void btnScissors_Click(object sender, EventArgs e)
        {
            pbPlayer.Image = scissors;
            int num = new Random().Next(1, 4);


            if (num == 3)
            {
                pbComputer.Image = scissorsC;
                Draw();
            }
            else if (num == 1)
            {
                pbComputer.Image = rockC;
                CompWins();
            }
            else if (num == 2)
            {
                pbComputer.Image = paperC;
                PlayerWins();
            }

            comments();

            bestOf5();
        }
        
        // where both players tie
        void Draw()
        {
            lblStatus.Text = "It's a draw!";
        }

        // when the computer wins
        void CompWins()
        {
            lblStatus.Text = "I win, you loose!";
            lblCompScore.Text = Convert.ToString(compScore += 1);
        }

        // when the player wins
        void PlayerWins()
        {
            lblStatus.Text = "You win!";
            lblPlayerScore.Text = Convert.ToString(playerScore += 1);
        }

        // when the game is reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            compScore = 0;
            playerScore = 0;

            lblCompScore.Text = Convert.ToString(compScore);
            lblPlayerScore.Text = Convert.ToString(playerScore);

            btnReset.Text = ("Reset");
            lblComments.Text = "";
            lblStatus.Text = "";
            show();
        }

        void bestOf5()
        {
            if (compScore == 5)
            {
                MessageBox.Show("Better luck next time." + Environment.NewLine + "Computer's Score: " + compScore + Environment.NewLine + "Players Score: " + playerScore);
                lblComments.Text = "";
                lblStatus.Text = "";
                btnReset.Text = ("New Game");

                hide();
            }
            else if (playerScore == 5)
            {
                MessageBox.Show("************" + Environment.NewLine + "* WINNER *" + Environment.NewLine + "************" + Environment.NewLine + "Player's Score: " + playerScore + Environment.NewLine + "Computer's Score: " + compScore);
                lblComments.Text = "";
                lblStatus.Text = "";
                btnReset.Text = ("New Game");

                hide();
            }
        }

        void comments()
        {
            if (compScore > playerScore)
            {
                lblComments.Text = ("Ha Ha, I'm gonna win this game!");
            }
            else if (compScore < playerScore)
            {
                lblComments.Text = ("Seems like your better at this game than me!");
            }
            else
            {
                lblComments.Text = ("Better watch out, because we wont be at a tie for long");
            }
        }

        void hide()
        {
            pbComputer.Hide();
            btnPaper.Hide();
            btnRock.Hide();
            btnScissors.Hide();
        }

        void show()
        {
            pbComputer.Show();
            btnPaper.Show();
            btnRock.Show();
            btnScissors.Show();
        }

        //void Shake()
        //{
        //    while (i < 4)
        //    {
        //        pbPlayer.Image = rock;
        //        Thread.Sleep(1000);

        //        pbPlayer.Image = rock45;
        //        Thread.Sleep(1000);

        //        i += 1;
        //    }
        //}
    }
    
}
