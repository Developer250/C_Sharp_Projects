namespace FlappyBird
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
            pipeTop = new PictureBox();
            flappyBird = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            pipeBottom = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(700, -6);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(125, 227);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(173, 132);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(58, 52);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-16, 574);
            ground.Name = "ground";
            ground.Size = new Size(943, 78);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(59, 584);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(106, 33);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(521, 329);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(125, 249);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 3;
            pipeBottom.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(925, 618);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(flappyBird);
            Controls.Add(pipeTop);
            Controls.Add(pipeBottom);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private PictureBox ground;
        private Label scoreText;
        private PictureBox pipeBottom;
        private System.Windows.Forms.Timer gameTimer;
    }
}
