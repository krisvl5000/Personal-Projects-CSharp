using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Form1 : Form
    {
        private bool goLeft;
        private bool goRight;
        private bool isGameOver;

        private int score;
        private int ballx;
        private int bally;
        private int playerSpeed;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            GameSetup();
        }

        private void GameSetup()
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;

            gameTimer.Start();

            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                }
            }
        }

        private void GameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            scoreBox.Text = "Score: " + score + " " + message;
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            scoreBox.Text = "Score: " + score;

            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight && player.Right < 680)
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 665)
            {
                ballx = -ballx;
            }

            if (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = random.Next(5, 12) * -1;

                if (ballx < 0)
                {
                    ballx = random.Next(5, 12) * -1;
                }
                else
                {
                    ballx = random.Next(5, 12);
                }
            }

            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                        bally = -bally;

                        Controls.Remove(x);
                    }
                }
            }

            if (score == 15)
            {
                GameOver("You win!");
            }

            if (ball.Top > 450)
            {
                GameOver("You lose!");
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
