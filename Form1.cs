using MemoryGameAnimals.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameAnimals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public PictureBox firstSelected = null;
        public PictureBox secondSelected = null;
        int count = 0; 
        int counter = 60;

        bool CompareTwoImages(string Tag1, string Tag2)
        {   //we gonna compare them using the tags 
            return Tag1 == Tag2;
        }
        bool IsGameOver()
        {
            return counter == 16;
        }

        void DisabeledAllPics()
        {
            pictureBoxCat1.Enabled = false;
            pictureBoxCat2.Enabled = false;
            pictureBoxCow1.Enabled = false;
            pictureBoxCow2.Enabled = false;
            pictureBoxDuck1.Enabled = false;
            pictureBoxDuck2.Enabled = false;
            pictureBoxElephant1.Enabled = false;
            pictureBoxElephant2.Enabled = false;
            pictureBoxFrog1.Enabled = false;
            pictureBoxFrog2.Enabled = false;
            pictureBoxGiraffe1.Enabled = false;
            pictureBoxGiraffe2.Enabled = false;
            pictureBoxLion1.Enabled = false;
            pictureBoxLion2.Enabled = false;
            pictureBoxMonkey1.Enabled = false;
            pictureBoxMonkey2.Enabled = false;
            

        }
        void EnabelAllPics()
        {
            pictureBoxCat1.Enabled = true ;
            pictureBoxCat2.Enabled = true;
            pictureBoxCow1.Enabled = true;
            pictureBoxCow2.Enabled = true;
            pictureBoxDuck1.Enabled = true;
            pictureBoxDuck2.Enabled =   true;
            pictureBoxElephant1.Enabled = true;
            pictureBoxElephant2.Enabled = true;
            pictureBoxFrog1.Enabled = true;
            pictureBoxFrog2.Enabled = true;
            pictureBoxGiraffe1.Enabled = true;
            pictureBoxGiraffe2.Enabled = true;
            pictureBoxLion1.Enabled = true;
            pictureBoxLion2.Enabled = true;
            pictureBoxMonkey1.Enabled = true;
            pictureBoxMonkey2.Enabled = true;
        }
        async void ChangeImages(string Tag1, string Tag2)
        {
            if (CompareTwoImages(Tag1, Tag2))
            {
                firstSelected.BackColor = Color.LightGreen;
                secondSelected.BackColor = Color.LightGreen;
                int Score = int .Parse(lblScore.Text);
                Score += 1;
                count += 2;
                lblScore.Text = Score.ToString();
                if(count == 16)
                {
                    MessageBox.Show("You Won The Game ", "Game Over ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisabeledAllPics();
                    timer1.Stop();
                }
            }
            else
            {
                firstSelected.BackColor = Color.Red;
                secondSelected.BackColor = Color.Red;

                await Task.Delay(800);
                firstSelected.Image = Properties.Resources.Card2;
                secondSelected.Image = Properties.Resources.Card2;
                firstSelected.BackColor = Color.Transparent;
                secondSelected.BackColor = Color.Transparent;
            }
            firstSelected = null;
            secondSelected = null;
        }
        void ChangeImagesAndCompareThem(PictureBox firstSelected, PictureBox secondSelected)
        {
            ChangeImages(firstSelected.Tag.ToString(), secondSelected.Tag.ToString());
            firstSelected.Enabled = true;
            secondSelected.Enabled = true;
            return;
        }
        void PerformTheClick(PictureBox MyImage)
        {
            if (MyImage.Tag.ToString() == "1")
            {
                MyImage.Image = Resources.Cat;
                if(firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "2")
            {
                MyImage.Image = Resources.Monkey;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "3")
            {
                MyImage.Image = Resources.Lion;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "4")
            {
                MyImage.Image = Resources.Frog;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "5")
            {
                MyImage.Image = Resources.Giraffe;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "6")
            {
                MyImage.Image = Resources.Duck;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "7")
            {
                MyImage.Image = Resources.Elephant;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
            if (MyImage.Tag.ToString() == "8")
            {
                MyImage.Image = Resources.Cow;
                if (firstSelected == null)
                {
                    firstSelected = MyImage;
                    return;
                }
                else if (secondSelected == null)
                {
                    secondSelected = MyImage;
                    ChangeImagesAndCompareThem(firstSelected, secondSelected);
                }
                return;
            }
        }

        private void pictureBoxCat1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxCat2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxMonkey1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxMonkey2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxLion1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxLion2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxFrog1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxFrog2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxGiraffe1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxGiraffe2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxDuck1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxDuck2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxElephant1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxElephant2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxCow1_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }

        private void pictureBoxCow2_Click(object sender, EventArgs e)
        {
            PerformTheClick((PictureBox)sender);
        }
        void RestartTheGame(int Count1 =60)
        {
            if (MessageBox.Show("Do you want to restart the game", "Restart",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                lblScore.Text = "0";
                count = 0;
                counter = Count1;
                lblTime.Text = counter.ToString();

                pictureBoxCat1.Image = Resources.Card2; 
                pictureBoxCat2.Image = Resources.Card2; 
                pictureBoxCow1.Image = Resources.Card2; 
                pictureBoxCow2.Image = Resources.Card2; 
                pictureBoxDuck1.Image = Resources.Card2;
                pictureBoxDuck2.Image = Resources.Card2;
                pictureBoxElephant1.Image = Resources.Card2;
                pictureBoxElephant2.Image = Resources.Card2;
                pictureBoxFrog1.Image = Resources.Card2;
                pictureBoxFrog2.Image = Resources.Card2;
                pictureBoxGiraffe1.Image = Resources.Card2;
                pictureBoxGiraffe2.Image = Resources.Card2;
                pictureBoxLion1.Image = Resources.Card2;
                pictureBoxLion2.Image = Resources.Card2;
                pictureBoxMonkey1.Image = Resources.Card2;
                pictureBoxMonkey2.Image = Resources.Card2;

                pictureBoxCat1.BackColor = Color.Transparent;
                pictureBoxCat2.BackColor = Color.Transparent;
                pictureBoxCow1.BackColor = Color.Transparent;
                pictureBoxCow2.BackColor = Color.Transparent;
                pictureBoxDuck1.BackColor = Color.Transparent;
                pictureBoxDuck2.BackColor = Color.Transparent;
                pictureBoxElephant1.BackColor = Color.Transparent;
                pictureBoxElephant2.BackColor = Color.Transparent;
                pictureBoxFrog1.BackColor = Color.Transparent;
                pictureBoxFrog2.BackColor = Color.Transparent;
                pictureBoxGiraffe1.BackColor = Color.Transparent;
                pictureBoxGiraffe2.BackColor = Color.Transparent;
                pictureBoxLion1.BackColor = Color.Transparent;
                pictureBoxLion2.BackColor = Color.Transparent;
                pictureBoxMonkey1.BackColor = Color.Transparent;
                pictureBoxMonkey2.BackColor = Color.Transparent;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartTheGame(60);
        }
        void CloseApp()
        {

            if (MessageBox.Show("Are you sure you want to exit ?", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseApp();
        }
        void EndGame()
        {
            if (MessageBox.Show("Game Over you lose you want to play again ", "Game Over ",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                RestartTheGame();
            }
            else DisabeledAllPics();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(counter == 10)
            {
                lblTime.ForeColor = Color.Red;
            }
            counter--;
            lblTime.Text = counter.ToString();
            if(counter == 0)
            {
                EndGame();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if(guna2CircleButton1.Text == "Pause")
            {
                DisabeledAllPics();
                timer1.Stop();
                guna2CircleButton1.Text = "Resume";
            }
            else
            {
                EnabelAllPics();
                timer1.Start();
                guna2CircleButton1.Text = "Pause";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // BackgroundImage = Image.FromFile(@"D:\MemoryGame\Forest3.png");
           // BackgroundImage = Image.FromFile(@"D:\MemoryGame\Forest3.png");
            timer1.Enabled = true;
        }
    }
}
