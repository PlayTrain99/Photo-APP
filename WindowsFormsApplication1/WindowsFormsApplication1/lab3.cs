using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image myImage = Image.FromFile(@"C:\Users\harno\OneDrive\Desktop\csgo.jpg"); //obrazek csgo

            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; //automatyczne sklaowanie obrazka do okienka

            pictureBox1.Image = myImage;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\harno\OneDrive\Desktop\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            pictureBox1.Image.Save(@"C:\Users\harno\OneDrive\Desktop\test.png", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.Image.Save(@"C:\Users\harno\OneDrive\Desktop\test.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            pictureBox1.Image.Save(@"C:\Users\harno\OneDrive\Desktop\test.gif", System.Drawing.Imaging.ImageFormat.Gif);
            pictureBox1.Image.Save(@"C:\Users\harno\OneDrive\Desktop\test.tif", System.Drawing.Imaging.ImageFormat.Tiff);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog button3 = new OpenFileDialog();
            button3.InitialDirectory = "e:\\image";
            button3.Filter = "*.bmp|*.bmp|*.jpg|*.jpg|*.png|*.png|*.tiff|*.tiff|All files (*.*)|*.*";
            button3.RestoreDirectory = true;

            if (button3.ShowDialog() == DialogResult.OK)
            {

                if ((myStream = button3.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        string fileName;
                        fileName = button3.FileName;

                        Image myImage = Image.FromFile(fileName);
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                        pictureBox1.Image = myImage;







                    }
                }
            }
        }
    }
}
            