namespace Image_Filetering
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Стандартні");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Збережені");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_apply_filter = new System.Windows.Forms.Button();
            this.numericUpDown_div = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_offset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_r = new System.Windows.Forms.CheckBox();
            this.checkBox_g = new System.Windows.Forms.CheckBox();
            this.checkBox_b = new System.Windows.Forms.CheckBox();
            this.button_add_filter = new System.Windows.Forms.Button();
            this.button_del_filter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImage = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.pointModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersGrBox = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.KernelGroupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.new_filter_name_textBox1 = new System.Windows.Forms.TextBox();
            this.ImageGroupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_offset)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.filtersGrBox.SuspendLayout();
            this.KernelGroupBox1.SuspendLayout();
            this.ImageGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(5, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(312, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Location = new System.Drawing.Point(6, 60);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_width.TabIndex = 1;
            this.numericUpDown_width.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_width.ValueChanged += new System.EventHandler(this.numericUpDown_width_ValueChanged);
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Location = new System.Drawing.Point(55, 60);
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_height.TabIndex = 1;
            this.numericUpDown_height.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Висота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Початкове зображення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Відфільтроване зображення";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_apply_filter
            // 
            this.button_apply_filter.Location = new System.Drawing.Point(6, 17);
            this.button_apply_filter.Name = "button_apply_filter";
            this.button_apply_filter.Size = new System.Drawing.Size(212, 23);
            this.button_apply_filter.TabIndex = 4;
            this.button_apply_filter.Text = "Застосувати фільтр";
            this.button_apply_filter.UseVisualStyleBackColor = true;
            this.button_apply_filter.Click += new System.EventHandler(this.button_apply_filter_Click);
            // 
            // numericUpDown_div
            // 
            this.numericUpDown_div.DecimalPlaces = 3;
            this.numericUpDown_div.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_div.Location = new System.Drawing.Point(104, 60);
            this.numericUpDown_div.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_div.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_div.Name = "numericUpDown_div";
            this.numericUpDown_div.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown_div.TabIndex = 1;
            this.numericUpDown_div.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_offset
            // 
            this.numericUpDown_offset.DecimalPlaces = 1;
            this.numericUpDown_offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_offset.Location = new System.Drawing.Point(164, 60);
            this.numericUpDown_offset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_offset.Name = "numericUpDown_offset";
            this.numericUpDown_offset.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown_offset.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дільник";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Зміщення";
            // 
            // checkBox_r
            // 
            this.checkBox_r.AutoSize = true;
            this.checkBox_r.Checked = true;
            this.checkBox_r.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_r.Location = new System.Drawing.Point(224, 17);
            this.checkBox_r.Name = "checkBox_r";
            this.checkBox_r.Size = new System.Drawing.Size(82, 17);
            this.checkBox_r.TabIndex = 5;
            this.checkBox_r.Text = "Red Chanel";
            this.checkBox_r.UseVisualStyleBackColor = true;
            // 
            // checkBox_g
            // 
            this.checkBox_g.AutoSize = true;
            this.checkBox_g.Checked = true;
            this.checkBox_g.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_g.Location = new System.Drawing.Point(224, 40);
            this.checkBox_g.Name = "checkBox_g";
            this.checkBox_g.Size = new System.Drawing.Size(91, 17);
            this.checkBox_g.TabIndex = 5;
            this.checkBox_g.Text = "Green Chanel";
            this.checkBox_g.UseVisualStyleBackColor = true;
            // 
            // checkBox_b
            // 
            this.checkBox_b.AutoSize = true;
            this.checkBox_b.Checked = true;
            this.checkBox_b.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_b.Location = new System.Drawing.Point(224, 63);
            this.checkBox_b.Name = "checkBox_b";
            this.checkBox_b.Size = new System.Drawing.Size(83, 17);
            this.checkBox_b.TabIndex = 5;
            this.checkBox_b.Text = "Blue Chanel";
            this.checkBox_b.UseVisualStyleBackColor = true;
            // 
            // button_add_filter
            // 
            this.button_add_filter.Location = new System.Drawing.Point(6, 363);
            this.button_add_filter.Name = "button_add_filter";
            this.button_add_filter.Size = new System.Drawing.Size(152, 23);
            this.button_add_filter.TabIndex = 4;
            this.button_add_filter.Text = "Додати фільтр";
            this.button_add_filter.UseVisualStyleBackColor = true;
            this.button_add_filter.Click += new System.EventHandler(this.button_add_filter_Click);
            // 
            // button_del_filter
            // 
            this.button_del_filter.Location = new System.Drawing.Point(164, 363);
            this.button_del_filter.Name = "button_del_filter";
            this.button_del_filter.Size = new System.Drawing.Size(153, 23);
            this.button_del_filter.TabIndex = 4;
            this.button_del_filter.Text = "Видалити фільтр";
            this.button_del_filter.UseVisualStyleBackColor = true;
            this.button_del_filter.Click += new System.EventHandler(this.button_del_filter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pointModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImage,
            this.SaveImage,
            this.Close});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openImage
            // 
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(124, 22);
            this.openImage.Text = "Відкрити";
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(124, 22);
            this.SaveImage.Text = "Зберегти";
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(124, 22);
            this.Close.Text = "Вийти";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pointModeToolStripMenuItem
            // 
            this.pointModeToolStripMenuItem.Name = "pointModeToolStripMenuItem";
            this.pointModeToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.pointModeToolStripMenuItem.Text = "Точковий режим";
            this.pointModeToolStripMenuItem.Click += new System.EventHandler(this.pointModeToolStripMenuItem_Click);
            // 
            // filtersGrBox
            // 
            this.filtersGrBox.Controls.Add(this.treeView1);
            this.filtersGrBox.Location = new System.Drawing.Point(12, 30);
            this.filtersGrBox.Name = "filtersGrBox";
            this.filtersGrBox.Size = new System.Drawing.Size(182, 452);
            this.filtersGrBox.TabIndex = 7;
            this.filtersGrBox.TabStop = false;
            this.filtersGrBox.Text = "Фільтри";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Standart";
            treeNode1.Text = "Стандартні";
            treeNode2.Name = "Saved";
            treeNode2.Text = "Збережені";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(170, 433);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // KernelGroupBox1
            // 
            this.KernelGroupBox1.Controls.Add(this.label7);
            this.KernelGroupBox1.Controls.Add(this.new_filter_name_textBox1);
            this.KernelGroupBox1.Controls.Add(this.dataGridView1);
            this.KernelGroupBox1.Controls.Add(this.checkBox_r);
            this.KernelGroupBox1.Controls.Add(this.checkBox_b);
            this.KernelGroupBox1.Controls.Add(this.button_del_filter);
            this.KernelGroupBox1.Controls.Add(this.numericUpDown_width);
            this.KernelGroupBox1.Controls.Add(this.button_add_filter);
            this.KernelGroupBox1.Controls.Add(this.checkBox_g);
            this.KernelGroupBox1.Controls.Add(this.numericUpDown_div);
            this.KernelGroupBox1.Controls.Add(this.numericUpDown_height);
            this.KernelGroupBox1.Controls.Add(this.numericUpDown_offset);
            this.KernelGroupBox1.Controls.Add(this.label1);
            this.KernelGroupBox1.Controls.Add(this.button_apply_filter);
            this.KernelGroupBox1.Controls.Add(this.label5);
            this.KernelGroupBox1.Controls.Add(this.label2);
            this.KernelGroupBox1.Controls.Add(this.label6);
            this.KernelGroupBox1.Location = new System.Drawing.Point(200, 30);
            this.KernelGroupBox1.Name = "KernelGroupBox1";
            this.KernelGroupBox1.Size = new System.Drawing.Size(323, 452);
            this.KernelGroupBox1.TabIndex = 8;
            this.KernelGroupBox1.TabStop = false;
            this.KernelGroupBox1.Text = "Ядро";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Назва";
            // 
            // new_filter_name_textBox1
            // 
            this.new_filter_name_textBox1.Location = new System.Drawing.Point(48, 337);
            this.new_filter_name_textBox1.Name = "new_filter_name_textBox1";
            this.new_filter_name_textBox1.Size = new System.Drawing.Size(269, 20);
            this.new_filter_name_textBox1.TabIndex = 6;
            // 
            // ImageGroupBox1
            // 
            this.ImageGroupBox1.Controls.Add(this.button1);
            this.ImageGroupBox1.Controls.Add(this.pictureBox1);
            this.ImageGroupBox1.Controls.Add(this.label3);
            this.ImageGroupBox1.Controls.Add(this.pictureBox2);
            this.ImageGroupBox1.Controls.Add(this.label4);
            this.ImageGroupBox1.Location = new System.Drawing.Point(529, 30);
            this.ImageGroupBox1.Name = "ImageGroupBox1";
            this.ImageGroupBox1.Size = new System.Drawing.Size(315, 452);
            this.ImageGroupBox1.TabIndex = 9;
            this.ImageGroupBox1.TabStop = false;
            this.ImageGroupBox1.Text = "Зображення";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Застосувати до початкового";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 491);
            this.Controls.Add(this.ImageGroupBox1);
            this.Controls.Add(this.KernelGroupBox1);
            this.Controls.Add(this.filtersGrBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Фільтрація зображень";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_offset)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filtersGrBox.ResumeLayout(false);
            this.KernelGroupBox1.ResumeLayout(false);
            this.KernelGroupBox1.PerformLayout();
            this.ImageGroupBox1.ResumeLayout(false);
            this.ImageGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_apply_filter;
        private System.Windows.Forms.NumericUpDown numericUpDown_div;
        private System.Windows.Forms.NumericUpDown numericUpDown_offset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_r;
        private System.Windows.Forms.CheckBox checkBox_g;
        private System.Windows.Forms.CheckBox checkBox_b;
        private System.Windows.Forms.Button button_add_filter;
        private System.Windows.Forms.Button button_del_filter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImage;
        private System.Windows.Forms.ToolStripMenuItem SaveImage;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem pointModeToolStripMenuItem;
        private System.Windows.Forms.GroupBox filtersGrBox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox KernelGroupBox1;
        private System.Windows.Forms.GroupBox ImageGroupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox new_filter_name_textBox1;
        private System.Windows.Forms.Button button1;
    }
}

