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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        //spila leik
        private void ButPlayGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Form1 Play = new Form1();
            Play.Show();
        }


        //velja level
        private void Butlevel_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Level select = new Level();
            select.Show();
        }


        //skoda controls
        private void ButControls_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Controls keys = new Controls();
            keys.Show();
        }


        //hætta
        private void ButQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            MessageBox.Show("dfgdf");
        }
        }
}
