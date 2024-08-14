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

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;

                
            }
                if (e.KeyCode == Keys.Up) {
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
