using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PairPicturesGame
{
    public partial class Form1 : Form
    {
        private List<Image> uniqueImages;
        private Image cardCover;

        private PictureBox[] pictureBoxes = new PictureBox[16];
        private int[] boardPositions = new int[16];

        private PictureBox firstClicked = null;
        private PictureBox secondClicked = null;

        private Stopwatch gameStopwatch = new Stopwatch();

        private int timerState = 0;

        public Form1()
        {
            InitializeComponent();
            LoadGameResources();
            InitializeGameBoard();

            btnNewGame.Click += BtnNewGame_Click;
            btnExit.Click += BtnExit_Click;
            activityTimer.Tick += ActivityTimer_Tick;
        }

        private void LoadGameResources()
        {
            uniqueImages = new List<Image>
            {
                Properties.Resources.img1, Properties.Resources.img2,
                Properties.Resources.img3, Properties.Resources.img4,
                Properties.Resources.img5, Properties.Resources.img6,
                Properties.Resources.img7, Properties.Resources.img8
            };
            cardCover = Properties.Resources.cover;
        }

        private void InitializeGameBoard()
        {
            int size = 100;    
            int margin = 10;  
            int startX = 25;   
            int startY = 25;   

            for (int i = 0; i < 16; i++)
            {
                int row = i / 4;
                int col = i % 4;

                pictureBoxes[i] = new PictureBox
                {
                    Width = size,
                    Height = size,
                    Left = startX + col * (size + margin),
                    Top = startY + row * (size + margin),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = i 
                };

                pictureBoxes[i].MouseDown += PictureBox_MouseDown;
                this.Controls.Add(pictureBoxes[i]);
            }
        }

        private void StartNewGame()
        {
            firstClicked = null;
            secondClicked = null;

            List<int> numbers = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                numbers.Add(i);
                numbers.Add(i);
            }

            Random rand = new Random();
            boardPositions = numbers.OrderBy(x => rand.Next()).ToArray();

            for (int i = 0; i < 16; i++)
            {
                int imgIndex = boardPositions[i];
                pictureBoxes[i].Image = uniqueImages[imgIndex];
                pictureBoxes[i].Visible = true;
                pictureBoxes[i].Enabled = false; 
            }

            timerState = 1;
            activityTimer.Interval = 3000;
            activityTimer.Start();
        }

        private void ActivityTimer_Tick(object sender, EventArgs e)
        {
            activityTimer.Stop();

            if (timerState == 1) 
            {
                for (int i = 0; i < 16; i++)
                {
                    pictureBoxes[i].Image = cardCover;
                    pictureBoxes[i].Enabled = true; 
                }
                gameStopwatch.Restart(); 
            }
            else if (timerState == 2) 
            {
                firstClicked.Image = cardCover;
                secondClicked.Image = cardCover;

                ToggleGridInteraction(true);
                firstClicked = null;
                secondClicked = null;
            }
            else if (timerState == 3) 
            {
                firstClicked.Visible = false;
                secondClicked.Visible = false;
                ToggleGridInteraction(true);
                firstClicked = null;
                secondClicked = null;

                CheckGameCompletion(); 
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            if (activityTimer.Enabled) return;

            PictureBox clickedBox = (PictureBox)sender;

            if (clickedBox == firstClicked) return;

            int index = (int)clickedBox.Tag;
            int imgIndex = boardPositions[index];

            clickedBox.Image = uniqueImages[imgIndex];

            if (firstClicked == null)
            {
                firstClicked = clickedBox;
            }
            else
            {
                secondClicked = clickedBox;
                ToggleGridInteraction(false); 

                int firstImgIndex = boardPositions[(int)firstClicked.Tag];
                int secondImgIndex = boardPositions[(int)secondClicked.Tag];

                if (firstImgIndex == secondImgIndex)
                {
                    timerState = 3;
                    activityTimer.Interval = 100;
                    activityTimer.Start();
                }
                else
                {
                    timerState = 2;
                    activityTimer.Interval = 1500;
                    activityTimer.Start();
                }
            }
        }

        private void ToggleGridInteraction(bool enable)
        {
            foreach (var box in pictureBoxes)
            {
                if (box.Visible) box.Enabled = enable;
            }
        }

        private void CheckGameCompletion()
        {
            if (pictureBoxes.All(p => !p.Visible))
            {
                gameStopwatch.Stop();
                TimeSpan ts = gameStopwatch.Elapsed;
                string gameTime = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

                MessageBox.Show($"Поздравляем с победой!\nВремя игры: {gameTime}",
                                "Игра завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
