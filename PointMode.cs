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
    public partial class PointMode : Form
    {
        Bitmap m_InPicture;
        Bitmap m_OutPicture;
        List<List<double>> m_filter;
        int m_filterWidth;
        int m_filterHeight;
        double m_div;
        double m_offset;
        bool m_isRed;
        bool m_isGreen;
        bool m_isBlue;
        public PointMode(ref Bitmap InPicture, ref Bitmap OutPicture,
            List<List<double>> filter,
            int filterWidth,
            int filterHeight,
            double div,
            double offset,
            bool isRed,
            bool isGreen,
            bool isBlue)
        {
            InitializeComponent();
            m_InPicture = InPicture;
            m_OutPicture = OutPicture;
            pictureBox1.Image = m_InPicture;

            m_filter = filter;
            m_filterWidth = filterWidth;
             m_filterHeight = filterHeight;
             m_div = div;
             m_offset = offset;
             m_isRed = isRed;
             m_isGreen = isGreen;
             m_isBlue = isBlue;


        }

        private void PointMode_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var X = e.X;
            var Y = e.Y;
            m_OutPicture = new Bitmap(m_InPicture);
            m_OutPicture = Apply_N_for_pixel(m_OutPicture,
                m_filter,
                m_filterWidth,
                m_filterHeight,
                m_div,
                m_offset,
               m_isRed,
                m_isGreen,
                m_isBlue,
                X,
                Y);
            pictureBox1.Image = m_OutPicture;
        }

        public static Bitmap Apply_N_for_pixel(Bitmap input,
   List<List<double>> filter,
   int filterWidth,
   int filterHeight,
   double div, double
   offset,
   bool isRed,
   bool isGreen,
   bool isBlue,
   int x_1,
   int y_1)
        {
            Bitmap Output = new Bitmap(input.Width, input.Height);

            if (div == 0)
            {
                div = 0.0001;
            }

            int width = input.Width;
            int height = input.Height;

            for (int x = x_1 - 10; x < x_1 + 10; x++)
                for (int y = y_1 - 10; y_1 < y_1 + 10; y++)
                {
                    if(x < 0 || y < 0 || x >= width || y >= height)
                    {
                        continue;
                    }
                    double red = 0.0, green = 0.0, blue = 0.0;
                    Color CurrentCenterPixel = input.GetPixel(x, y);
                    Color CurrentPixel = input.GetPixel(x, y);
                    //multiply every value of the filter with corresponding image pixel
                    for (int filterY = 0; filterY < filterHeight; filterY++)
                        for (int filterX = 0; filterX < filterWidth; filterX++)
                        {

                            int imageX = x + (filterX - (filterWidth / 2));
                            int imageY = y + (filterY - (filterHeight / 2));
                            if ((imageX < 0) ||
                              (imageX >= width) ||
                              (imageY < 0) ||
                              (imageY >= height)) continue;

                            CurrentPixel = input.GetPixel(imageX, imageY);

                            red += CurrentPixel.R * filter[filterY][filterX];
                            green += CurrentPixel.G * filter[filterY][filterX];
                            blue += CurrentPixel.B * filter[filterY][filterX];
                        }

                    //truncate values smaller than zero and larger than 255
                    int r = 0;
                    int g = 0;
                    int b = 0;
                    if (isRed)
                        r = Math.Min(Math.Abs((int)((1 / div) * red + offset)), 255);
                    else
                        r = CurrentCenterPixel.R;
                    if (isGreen)
                        g = Math.Min(Math.Abs((int)((1 / div) * green + offset)), 255);
                    else
                        g = CurrentCenterPixel.G;
                    if (isBlue)
                        b = Math.Min(Math.Abs((int)((1 / div) * blue + offset)), 255);
                    else
                        b = CurrentCenterPixel.B;

                    Color OutputColorPixel = Color.FromArgb(r, g, b);
                    Output.SetPixel(x, y, OutputColorPixel);
                }
            return Output;
        }

    }
}
