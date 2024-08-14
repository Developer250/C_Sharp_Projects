namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            ball = new PictureBox();
            computer = new PictureBox();
            GameTicker = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computer).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = Properties.Resources.player;
            player.Location = new Point(79, 132);
            player.Name = "player";
            player.Size = new Size(30, 120);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Click += pictureBox1_Click;
            // 
            // ball
            // 
            ball.Image = Properties.Resources.ball;
            ball.Location = new Point(391, 179);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 1;
            ball.TabStop = false;
            ball.Click += ball_Click;
            // 
            // computer
            // 
            computer.Image = Properties.Resources.computer;
            computer.Location = new Point(712, 132);
            computer.Name = "computer";
            computer.Size = new Size(30, 120);
            computer.SizeMode = PictureBoxSizeMode.StretchImage;
            computer.TabIndex = 2;
            computer.TabStop = false;
            // 
            // GameTicker
            // 
            GameTicker.Interval = 20;
            GameTicker.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(computer);
            Controls.Add(ball);
            Controls.Add(player);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)computer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox player;
        private PictureBox ball;
        private PictureBox computer;
        private System.Windows.Forms.Timer GameTicker;
    }
}
