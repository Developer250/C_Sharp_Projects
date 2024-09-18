namespace PingPong
{
    public partial class Form1 : Form
    {
        int speed = 2;
        int bsllXSpeed = 4;
        int bsllYSpeed = 4;
        Random rand = new Random();
        bool goDown, goUp;
        int computer_speed_change = 50;
        int player_speed = 8;
        int computerScore = 0;
        int playerScore = 0;

        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 11, 12 };


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //Ball goes off the top edge and bottom edge.
            ball.Top -= bsllYSpeed;
            ball.Left -= bsllXSpeed;


            this.Text = "Playerscore: ", + playerScore + "-- Computerscore ", +computerScore;

            if(ball.Top > 0 || ball.bottom > this.ClientSize.Height) //Ball goes off the top edge downwards
            {
                bsllYSpeed = -bsllYSpeed;
            }

            //Checking if the ball goes left or right. When it goes by the computer or player, the other gets a point
            if (ball.Left < -2)
            {
                ball.Left = 300;
                bsllXSpeed = -bsllXSpeed;
                computerScore++;
            }

            if (ball.Right < +2)
            {
                ball.Right = 300;
                bsllXSpeed = -bsllXSpeed;
                playerScore++;

                if (computer.Top <= 1) // Computer movement from the top. reseting the computer the computer
                {
                    computer.Top = 0;
                }

                else if (computer.Bottom >= this.ClientSize.Height)
                {
                    computerScore.Top = this.ClientSize.Height - computer.Height;
                }

                if (ball.Top < computer.Top + (computerHeight / 2) && ball.Left > 300)
                {
                    computer.Top -= speed;
                }
                if (ball.Top > computer.Top + (computerHeight / 2) && ball.Left > 300)
                {
                    computer.Top += speed;
                }

                computer_speed_change -= 1; //Slowing the speed

                if (computer_speed_change < 0) // Checking the speed
                {
                    speed = i[rand.Next(i.Lenght)]; //Taking a new random speed for the comp
                    computer_speed_change = 50;
                }

                //Checking if the player is moving towards top of the form ---> adding speed or reducing (depends if it's more than 0 or not)
                if (goDown && playerScore.Top + playerScore.Height < this.ClientSize.Height) 
                {
                    player.Top += playerSpeed;
                }

                if (goUp && playerScore.Top > 0)
                {
                    player.Top -= playerSpeed;
                }

                //Checking is the playr's picturebox or comp's picbox glitching.
                CheckCollission(ball, player, player.Right + 5);
                CheckCollission(ball, computer, computer.Left - 35);

                if (computerScore > 5)
                {
                    GameOver("Sorry you lost the game");
                }

                else if (playerScore > 5)
                {
                    GameOver("You wont the game");
                }


                private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;

            }
                if (e.KeyCode == Keys.Up) 
            {
                goUp = true;
            }
            
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) {
                goDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void CheckCollission(PictureBox picOne, PictureBox picTwo, int offset)
        {
            if (picOne.Bounds.IntersectsWith(picTwo.Bounds))
            {
                picOne.Left = offset;


                int x = j[rand.Next(j.Length)]; //Takes randomly ball's speed from the j-array
                int y = j[rand.Next(j.Length)]; //Takes randomly ball's speed from the j-array

                if (bsllXSpeed < 0) //If the ball's speed is less than 0, it goes right direction
                {
                    bsllXSpeed = x;
                }
                else
                {
                    bsllXSpeed = -x;
                }

                if (bsllXSpeed < 0) //If the ball's speed is less than 0, it goes right direction
                {
                    bsllYSpeed = y;
                }
                else
                {
                    bsllYSpeed = -y;
                }
            }
        }



        private void GameOver(string message)
        {
            GameTimer.Stop();
            MessageBox.Show(message, "You loose");
            computerScore = 0;
            playerScore = 0;
            bsllXSpeed = bsllYSpeed = 4;
            GameTimer.Start();
        }
    }
}
