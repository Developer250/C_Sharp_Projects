using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        // Variables to set the default speed, gravity and score
        int pipeSpeed = 6; 
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        //
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // link the flappy bird picture box to the gravity, += means it will add the speed of gravity to the picture boxes top location so it will move down
            pipeBottom.Left -= pipeSpeed; //The pipeBottom will go to left
            pipeTop.Left -= pipeSpeed; // The same thing to pipeTop
            scoreText.Text = " Score " + score; //Adding the score on the screen when passing the pipes

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds)
                )

            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }


            if (flappyBird.Top < -25)
            {
                endGame();
            }

        }


        private void endGame() // Stops the game
        {
            gameTimer.Stop();
            scoreText.Text += "Game Over! ";
        }
    }
}
