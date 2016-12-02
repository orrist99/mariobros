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
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private void ButLevel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Form1 level1 = new Form1();
            level1.Show();
        }

        private void ButLevel2_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Level2 level2 = new Level2();
            level2.Show();
        }

        private void ButBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Menu back = new Menu();
            back.Show();
        }

        private void ButLevel3_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Level3 back = new Level3();
            back.Show();
        }
    }
}
