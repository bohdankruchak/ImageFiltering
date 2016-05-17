using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Filetering
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        Bitmap imageInBitMap;
        Bitmap imageOutBitMap;
        int heightOfKernel = 3;
        int widthOfKernel = 3;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 11; i++)
            {
                KernelMatrix.Add(new List<double>());
                for (int j = 0; j < 11; j++)
                {
                    KernelMatrix[i].Add(0);
                }
            }
            UpdateGrid();
            //UpdateListOfFilters();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.gif )|*.png;*.jpeg;*.jpg;*.gif|All files (*.*)|*.*";
            imageInBitMap = new Bitmap("default.jpg");
            imageOutBitMap = new Bitmap("default.jpg");
            openFileDialog.FileName = "default.jpg";
            pictureBox1.Image = imageInBitMap;
            pictureBox2.Image = imageOutBitMap;

        }
        List<List<double>> KernelMatrix = new List<List<double>>();
        public void UpdateGrid()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = (int)numericUpDown_height.Value;
            dataGridView1.Columns[0].Width = 30;
            for (int i = 1; i < (int)numericUpDown_height.Value; i++)
            {
                dataGridView1.Columns[i].Width = 30;
            }
            for (int i = 0; i < (int)numericUpDown_width.Value; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < (int)numericUpDown_width.Value; i++)
            {

                for (int j = 0; j < (int)numericUpDown_height.Value; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = KernelMatrix[i][j].ToString();
                }
            }
            dataGridView1.Update();
        }

        private void numericUpDown_width_ValueChanged(object sender, EventArgs e)
        {
            UpdateKernel();
            UpdateGrid();
            widthOfKernel = (int)numericUpDown_width.Value;
        }

        private void numericUpDown_height_ValueChanged(object sender, EventArgs e)
        {
            UpdateKernel();
            UpdateGrid();
            heightOfKernel = (int)numericUpDown_height.Value;
        }

        private void UpdateKernel()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    KernelMatrix[i][j] = 0;
                }
            }
            for (int i = 0; i < (int)numericUpDown_width.Value; i++)
            {
                for (int j = 0; j < (int)numericUpDown_height.Value; j++)
                {
                    if (i < dataGridView1.Rows.Count && j < dataGridView1.Rows[i].Cells.Count)
                    {
                        try
                        {
                            KernelMatrix[i][j] = double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        catch
                        {
                            KernelMatrix[i][j] = 0;
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                    }

                }
            }
        }
        private void button_open_Click(object sender, EventArgs e)
        {

        }

        public static Bitmap Apply_N(Bitmap input,
            List<List<double>> filter,
            int filterWidth,
            int filterHeight,
            double div, double
            offset,
            bool isRed,
            bool isGreen,
            bool isBlue)
        {
            Bitmap Output = new Bitmap(input.Width, input.Height);

            if (div == 0)
            {
                div = 0.0001;
            }

            int width = input.Width;
            int height = input.Height;

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
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

        public static Bitmap Apply_N_for_pixel(Bitmap input,
           List<List<double>> filter,
           int filterWidth,
           int filterHeight,
           double div, double
           offset,
           bool isRed,
           bool isGreen,
           bool isBlue,
           int x,
           int y)
        {
            Bitmap Output = new Bitmap(input.Width, input.Height);

            if (div == 0)
            {
                div = 0.0001;
            }

            int width = input.Width;
            int height = input.Height;


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

            return Output;
        }

        private void button_apply_filter_Click(object sender, EventArgs e)
        {
            UpdateKernel();
            double div = (double)numericUpDown_div.Value;
            double offset = (double)numericUpDown_offset.Value;
            imageOutBitMap = new Bitmap(imageInBitMap);
            imageOutBitMap = Apply_N(imageOutBitMap,
                KernelMatrix,
                widthOfKernel,
                heightOfKernel,
                div,
                offset,
                checkBox_r.Checked,
                checkBox_g.Checked,
                checkBox_b.Checked);
            pictureBox2.Image = imageOutBitMap;
        }


        private void button_save_Click(object sender, EventArgs e)
        {

        }


        //public static Bitmap ConvolutionFilter<T>(this Bitmap sourceBitmap, T filter)
        //                        where T : ConvolutionFilterBase
        //{
        //    BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
        //                                sourceBitmap.Width, sourceBitmap.Height),
        //                                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);


        //    byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
        //    byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];


        //    Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);


        //    sourceBitmap.UnlockBits(sourceData);


        //    double blue = 0.0;
        //    double green = 0.0;
        //    double red = 0.0;


        //    int filterWidth = filter.FilterMatrix.GetLength(1);
        //    int filterHeight = filter.FilterMatrix.GetLength(0);


        //    int filterOffset = (filterWidth - 1) / 2;
        //    int calcOffset = 0;


        //    int byteOffset = 0;


        //    for (int offsetY = filterOffset; offsetY <
        //         sourceBitmap.Height - filterOffset; offsetY++)
        //    {
        //        for (int offsetX = filterOffset; offsetX <
        //             sourceBitmap.Width - filterOffset; offsetX++)
        //        {
        //            blue = 0;
        //            green = 0;
        //            red = 0;


        //            byteOffset = offsetY *
        //                            sourceData.Stride +
        //                            offsetX * 4;


        //            for (int filterY = -filterOffset;
        //                 filterY <= filterOffset; filterY++)
        //            {
        //                for (int filterX = -filterOffset;
        //                     filterX <= filterOffset; filterX++)
        //                {


        //                    calcOffset = byteOffset +
        //                                 (filterX * 4) +
        //                                 (filterY * sourceData.Stride);


        //                    blue += (double)(pixelBuffer[calcOffset]) *
        //                             filter.FilterMatrix[filterY + filterOffset,
        //                             filterX + filterOffset];


        //                    green += (double)(pixelBuffer[calcOffset + 1]) *
        //                              filter.FilterMatrix[filterY + filterOffset,
        //                              filterX + filterOffset];


        //                    red += (double)(pixelBuffer[calcOffset + 2]) *
        //                            filter.FilterMatrix[filterY + filterOffset,
        //                            filterX + filterOffset];
        //                }
        //            }


        //            blue = filter.Factor * blue + filter.Bias;
        //            green = filter.Factor * green + filter.Bias;
        //            red = filter.Factor * red + filter.Bias;


        //            if (blue > 255)
        //            { blue = 255; }
        //            else if (blue < 0)
        //            { blue = 0; }


        //            if (green > 255)
        //            { green = 255; }
        //            else if (green < 0)
        //            { green = 0; }


        //            if (red > 255)
        //            { red = 255; }
        //            else if (red < 0)
        //            { red = 0; }


        //            resultBuffer[byteOffset] = (byte)(blue);
        //            resultBuffer[byteOffset + 1] = (byte)(green);
        //            resultBuffer[byteOffset + 2] = (byte)(red);
        //            resultBuffer[byteOffset + 3] = 255;
        //        }
        //    }


        //    Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);


        //    BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
        //                            resultBitmap.Width, resultBitmap.Height),
        //                            ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);


        //    Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
        //    resultBitmap.UnlockBits(resultData);


        //    return resultBitmap;
        //}

        private void button_add_filter_Click(object sender, EventArgs e)
        {
            UpdateKernel();
            dataGridView1.ClearSelection();

            string newName;
            if (new_filter_name_textBox1.Text == "")
            {
                newName = "new";
            }
            else
            {
                newName = new_filter_name_textBox1.Text;
            }
            treeView1.Nodes[1].Nodes.Add(newName);

            string output = "";
            StreamReader sr;
            string file = "saved";
            if (!File.Exists(file))
                File.Create(file);
            else
            {
                sr = new StreamReader(file);
                output = sr.ReadToEnd();
                sr.Close();
            }

            output += "[name]" + newName + "[name]"
                + "[kernel]";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    output += " " + KernelMatrix[i][j];
                }
            }
            output += "[kernel]";
            output += "[opt]" + numericUpDown_div.Value + " " + numericUpDown_offset.Value + "[opt]";
            output += "[size]" + heightOfKernel + " " + widthOfKernel + "[size]";
            output += "[end]\n";
            File.WriteAllText(file, output);
        }


        private void button_del_filter_Click(object sender, EventArgs e)
        {
            string input = "";
            string output = "";

            int currentRootNodeIndex = treeView1.SelectedNode.Parent.Index;
            int currentNodeIndex = treeView1.SelectedNode.Index;
            TreeNode SelectNext = treeView1.Nodes[1].Nodes[currentNodeIndex - 1];

            treeView1.Nodes[1].Nodes[currentNodeIndex].Remove();
            if (currentRootNodeIndex == 0)
            {
                return;
            }

            StreamReader sr;

            string file = "saved";
            if (!File.Exists(file))
                return;
            else
            {
                sr = new StreamReader(file);
                input = sr.ReadToEnd();
                sr.Close();
            }
            string[] separators = { "[end]\n" };
            string[] AllRules = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (currentNodeIndex < AllRules.Length)
            {
                separators[0] = "[name]";
                string[] name = AllRules[currentNodeIndex].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < AllRules.Length; i++)
                {
                    if (i != currentNodeIndex)
                    {
                        output += AllRules[i] + "[end]\n";
                    }
                }
                File.WriteAllText(file, output);
            }
            treeView1.SelectedNode = SelectNext;
        }



        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            imageInBitMap = new Bitmap(openFileDialog.FileName);
            imageOutBitMap = new Bitmap(openFileDialog.FileName);
            pictureBox1.Image = imageInBitMap;
            pictureBox2.Image = imageOutBitMap;
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(saveFileDialog.FileName, format);
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            UpdateTree(0);
            UpdateTree(1);
        }

        private void UpdateTree(int index)
        {
            treeView1.Nodes[index].Nodes.Clear();
            string input = "";
            StreamReader sr;
            string file = "";
            if (index == 1)
            {
                file = "saved";
            }
            else
            {
                file = "standard";
            }
            if (!File.Exists(file))
                return;
            else
            {
                sr = new StreamReader(file);
                input = sr.ReadToEnd();
                sr.Close();
            }
            string[] separators = { "[end]\n" };
            string[] AllRules = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < AllRules.Length; i++)
            {
                separators[0] = "[name]";
                string[] name = AllRules[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                treeView1.Nodes[index].Nodes.Add(name[0]);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                int currentRootNodeIndex = treeView1.SelectedNode.Parent.Index;
                int currentNodeIndex = treeView1.SelectedNode.Index;

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        KernelMatrix[i][j] = 0;
                    }
                }
                string input = "";
                //int nSelectedItem = dataGridView_list_of_filters.CurrentRow.Index;
                StreamReader sr;
                string file = "";
                if (currentRootNodeIndex == 1)
                {
                    file = "saved";
                }
                else
                {
                    file = "standard";
                }
                if (!File.Exists(file))
                    return;
                else
                {
                    sr = new StreamReader(file);
                    input = sr.ReadToEnd();
                    sr.Close();
                }
                string[] separators = { "[end]\n" };
                string[] AllRules = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (currentNodeIndex < AllRules.Length)
                {
                    separators[0] = "[kernel]";
                    string[] CurrentRule = AllRules[currentNodeIndex].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    separators[0] = " ";

                    separators[0] = "[size]";
                    string[] temp1 = CurrentRule[2].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    separators[0] = " ";
                    string[] size = temp1[1].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    heightOfKernel = int.Parse(size[0]);
                    widthOfKernel = int.Parse(size[1]);

                    numericUpDown_height.Value = heightOfKernel;
                    numericUpDown_width.Value = widthOfKernel;

                    separators[0] = "[opt]";
                    string[] temp2 = CurrentRule[2].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    separators[0] = " ";
                    string[] options = temp2[0].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    numericUpDown_div.Value = decimal.Parse(options[0]);
                    numericUpDown_offset.Value = decimal.Parse(options[1]);

                    string[] kernel = CurrentRule[1].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            KernelMatrix[i][j] = double.Parse(kernel[(i) * (10) + j]);
                        }
                    }
                    UpdateGrid();
                }
            }
            catch
            {

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FullScreenImage form = new FullScreenImage(imageOutBitMap);
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FullScreenImage form = new FullScreenImage(imageInBitMap);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageInBitMap = new Bitmap(imageOutBitMap);
            pictureBox1.Image = imageInBitMap;
        }

        private void pointModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateKernel();
            double div = (double)numericUpDown_div.Value;
            double offset = (double)numericUpDown_offset.Value;
            PointMode form = new PointMode(ref imageInBitMap, ref imageOutBitMap, KernelMatrix, widthOfKernel,
                heightOfKernel,
                div,
                offset,
                checkBox_r.Checked,
                checkBox_g.Checked,
                checkBox_b.Checked);
            form.ShowDialog();
        }
    }
}
