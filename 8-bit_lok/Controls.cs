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
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void ButBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;//þetta felur formið sem er verið ad spila í 
            //anað form (victory) byrtist
            Menu back = new Menu();
            back.Show();
        }

        
    }
}
