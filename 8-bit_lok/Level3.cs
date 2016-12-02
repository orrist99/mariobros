using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_bit_lok
{
    public partial class Level3 : Form
    {
        bool right;
        bool left;
        bool jump;
        int G = 25;//hversu hátt mario fer up þegar hann hoppar
        int force;
        int index = 0;

        public Level3()
        {
            InitializeComponent();
        }



        public void Blokk(PictureBox x)//aðferð fyrir block
        {

            if (player.Left + player.Width > x.Left && player.Left + player.Width < x.Left + x.Width + player.Width && player.Top + player.Height >= x.Top && player.Top < x.Top)
            {

                //player.Top = screen.Height - player.Height;
                jump = false;
                force = 0;
                player.Top = x.Location.Y - player.Height;

            }


            //block head
            if (player.Left + player.Width > x.Left && player.Left + player.Width < x.Left + x.Width + player.Width && player.Top - x.Bottom <= 10 && player.Top - x.Top > -10)
            {
                force = -1;
            }

            if (player.Right > x.Left && player.Left < x.Right - player.Width / 2 && player.Bottom > x.Top)
            {
                right = false;
            }

            //vinstri vegur
            if (player.Left < x.Right && player.Right > x.Left + player.Width / 2 && player.Bottom > x.Top)
            {
                left = false;
            }
        }







        private void time1_Tick(object sender, EventArgs e)
        {
            //hlaupa gif spilar replayar
            index++;
            if (right == true && index % 15 == 0)
            {
                player.Image = Image.FromFile("marioandyoshi.gif");
            }

            if (left == true && index % 15 == 0)
            {
                player.Image = Image.FromFile("marioandyoshi2.gif");
            }

            //mario move
            if (right == true)
            {
                player.Left += 3;
            }
            if (left == true)
            {
                player.Left -= 3;
            }
            //jump

            if (jump == true)
            {
                //ef player hefur hopad adur
                player.Top -= force;
                force -= 1;
            }




            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;//fall hættir á bottinum
                if (jump == true)
                {
                    player.Image = Image.FromFile("marioyoshi.png");//mynd breytist þegar player er buinn ad hoppa og stendur kyrr
                }
                jump = false;

            }

            else
            {
                player.Top += 5;
            }


            //þegar player dettur í hraunið
            if (player.Left + player.Width - 1 > lava.Left && player.Left + player.Width + 5 < lava.Left + lava.Width + player.Width && player.Top + player.Height >= lava.Top && player.Top < lava.Top)
            {
                player.Top = screen.Height - lava.Height - player.Height;



                if (player.Bounds.IntersectsWith(lava.Bounds)) ;
                {
                    this.Visible = false;//þetta felur formið sem er verið ad spila í 
                    //anað form (victory) byrtist
                    time1.Stop();//stopa time one svo kodin runnar ekki þvi annars koma 100x forms
                    Form2 rip = new Form2();
                    rip.Show();
                }

            }

                //þetta ef fyrir þegar hann nær að klára levelið
                if (player.Left + player.Width - 1 > endpoint.Left && player.Left + player.Width + 5 < endpoint.Left + endpoint.Width + player.Width && player.Top + player.Height >= endpoint.Top && player.Top < endpoint.Top)
                {
                    player.Top = screen.Height - endpoint.Height - player.Height;



                    if (player.Bounds.IntersectsWith(endpoint.Bounds)) ;
                    {
                        this.Visible = false;//þetta felur formið sem er verið ad spila í 
                        //anað form (victory) byrtist
                        time1.Stop();//stopa time one svo kodin runnar ekki þvi annars koma 100x forms
                        Win end = new Win();
                        end.Show();
                    }
                }

                //þetta ef fyrir þegar hann nær að klára levelið
                //þetta ef fyrir þegar hann nær að klára levelið
                if (player.Left + player.Width - 1 > endpoint.Left && player.Left + player.Width + 5 < endpoint.Left + endpoint.Width + player.Width && player.Top + player.Height >= endpoint.Top && player.Top < endpoint.Top)
                {
                    player.Top = screen.Height - endpoint.Height - player.Height;



                    if (player.Bounds.IntersectsWith(lava.Bounds)) ;
                    {
                        this.Visible = false;//þetta felur formið sem er verið ad spila í 
                        //anað form (victory) byrtist
                        time1.Stop();//stopa time one svo kodin runnar ekki þvi annars koma 100x forms
                        Form2 end = new Form2();
                        end.Show();
                    }
                }


                Blokk(pictureBox1);
                Blokk(block2);
                Blokk(block3);
                Blokk(block4);
                Blokk(block5);
                Blokk(block6);
                Blokk(block7);
                Blokk(block8);
                Blokk(block9);
                Blokk(block10);

            }
        

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                //player.Image = Image.FromFile("marioandyosi.gif");//þessi mynd kemur þegar mario fer til hægri
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
                //player.Image = Image.FromFile("walk_l.gif");//þessi mynd kemur þegar mario fer til vinstri
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();//hætta
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = G;
                    player.Image = Image.FromFile("marioyoshi.png");//þegar mario jumpar kemur þessi mynd
                }


            }

        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                player.Image = Image.FromFile("marioyoshi.png");//þegar mario fer til hægri og stoppar birtist mynd af honum standa

            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;

                player.Image = Image.FromFile("marioyoshi.png");//þegar mario fer til vinstri og stoppar birtist mynd af honum standa
            }


        }



        


            

        

        
     

   
    }
}


