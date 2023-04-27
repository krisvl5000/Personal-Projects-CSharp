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
        }

        private void GameSetup()
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;

            gameTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {

        }
    }
}
