using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Filetering
{
    public partial class FullScreenImage : Form
    {
        public FullScreenImage(Bitmap Picture)
        {
            InitializeComponent();
            pictureBox1.Image = Picture;
        }

        private void FullScreenImage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
