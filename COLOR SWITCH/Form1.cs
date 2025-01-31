using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


//This was made purely in C# Windows Forms without the use of any other engine like unity so please consider voting!


namespace COLOR_SWITCH
{

    public partial class Form1
        : Form
    {

        List<Color> colors;
        Random rand = new Random();
        Random blockPosition = new Random();

        int i;
        int speed = 5;
        int score = 0;

        int location;
        int blockcolor;
        bool GameOver = false;


        public Form1()
        {







            InitializeComponent();
            RestarGame();


        }



        private void MainTimerEvent(object sender, EventArgs e)
        {

            label1.Text = "Score: " + score;


            foreach (Control x in panel1.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "block")
                {
                    x.Top += speed;
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        location = blockPosition.Next(400, 600) + (3 * blockPosition.Next(150, 250));
                        x.Top = location * -1;
                        blockcolor = rand.Next(0, colors.Count);
                        x.BackColor = colors[blockcolor];

                        score += 1;

                    }


                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (player.BackColor != x.BackColor)
                        {
                            GameTimer.Stop();
                            GameOver = true;
                            GameEndScreen.Visible = true;
                            EndScore.Text = "Score: " + score;
                        }

                    }

                }

            }
            if (score > 5)
            {
                speed = 10;
            }




        }



        private void KeyIsPressed(object sender, KeyPressEventArgs e)

        {
            if (e.KeyChar == (char)Keys.Space && GameOver == false)
            {
                i++;
                if (i > colors.Count - 1)
                {
                    i = 0;
                }



                player.BackColor = colors[i];


            }

            if (e.KeyChar == (char)Keys.R || e.KeyChar == char.ToLower((char)Keys.R) && GameOver == true)

            {
                RestarGame();
            }





        }








        private void RestarGame()
        {

            block1.Top = -200;
            block2.Top = -750;
            GameOver = false;
            colors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow };
            i = 0;
            speed = 8;
            score = 0;
            label1.Text = "Score: " + score;
            GameEndScreen.Visible = false;
            GameTimer.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
