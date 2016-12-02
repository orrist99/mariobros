using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace _8_bit_lok
{
    public partial class Form1 : Form
    {  
        bool right;
        bool left;
        bool jump;
        int G = 25;//hversu hátt mario fer up þegar hann hoppar
        int force;
        int index = 0;
        
        

        public Form1()
        {
            InitializeComponent();
            
           

        }



        public void Blokk(PictureBox x)//aðferð fyrir block
          {
              
             if (player.Left + player.Width > x.Left && player.Left + player.Width<x.Left + x.Width + player.Width && player.Top + player.Height >= x.Top && player.Top<x.Top)
             {
  
             //player.Top = screen.Height - player.Height;
                 jump = false;
                 force = 0;
                 player.Top = x.Location.Y - player.Height;
  
             }
             
 
             //block head
             if (player.Left + player.Width > x.Left && player.Left + player.Width<x.Left + x.Width + player.Width && player.Top - x.Bottom <= 10 && player.Top - x.Top> -10)
             {
                 force = -1;
             }
           }




private void time1_Tick(object sender, EventArgs e)
        {

            //test test
            //hlaupa gif spilar replayar
            index++;
            if (right == true && index % 15 == 0)
            {
                player.Image = Image.FromFile("marioandyoshi.gif");
            }

            if (left == true && index % 15 == 0 )
            {
                player.Image = Image.FromFile("marioandyoshi2.gif");
            }

            //vinstri hlið á pipu
            if (player.Right > pipe.Left && player.Left < pipe.Right - player.Width / 2 && player.Bottom > pipe.Top)
            {
                right = false;
            }

            //vinstri vegur
            if (player.Left < WallLeft.Right && player.Right > WallLeft.Left + player.Width / 2 && player.Bottom > WallLeft.Top)
            {
                left = false;
            }

            

            //hægri hlið á wall
            if (player.Left < pipe.Right && player.Right > pipe.Left + player.Width / 2 && player.Bottom > pipe.Top)
            {
                left = false;
            }

            //hægri hlið á wall
            if (player.Right > WallRight.Left && player.Left < WallRight.Right - player.Width / 2 && player.Bottom > WallRight.Top)
            {
                right = false;
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
              player.Top  = screen.Height - player.Height;//fall hættir á bottinum
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

          //top á pipu
          if (player.Left + player.Width > pipe.Left && player.Left + player.Width < pipe.Left + pipe.Width + player.Width && player.Top + player.Height >= pipe.Top && player.Top < pipe.Top)
          {

              jump = false;
              force = 0;
              player.Top = pipe.Location.Y - player.Height;
              player.Image = Image.FromFile("marioyoshi.png");//nuna kemur mynd af mario standa þegar hann hefur hoppad ofan á pipuna

             
          }

            //blcok top
            if (player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {

                jump = false;
                force = 0;
                player.Top = block.Location.Y - player.Height;
               
            }

            


                if (block4.Left < this.Width)
                {
                    block4.Left = block4.Left + 3;
                }

               else
                 {
                     block4.Left = 0;
                }

            //Level2
            //þegar player kemur við hlut
            if (player.Left + player.Width - 1 > win.Left && player.Left + player.Width + 5 < win.Left + win.Width + player.Width && player.Top + player.Height >= win.Top && player.Top < win.Top)
            {
                player.Top = screen.Height - win.Height - player.Height;



                if (player.Bounds.IntersectsWith(win.Bounds)) ;
                 {
                     this.Visible = false;//þetta felur formið sem er verið ad spila í 
                     //anað form (victory) byrtist
                     time1.Stop();//stopa time one svo kodin runnar ekki þvi annars koma 100x forms
                     Level2 level2 = new Level2();
                    level2.Show();
                 }
            }




            //death
            //þegar player kemur við hlut
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
            Blokk(block1);
            Blokk(block2);
            Blokk(block3);
            Blokk(block4);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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
 