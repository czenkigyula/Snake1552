using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace kepnezegeto
{
    public partial class Form1 : Form
    {

        Image file;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                if(file != null)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    }

                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    }

                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    }

                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "gif")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                    }
                }
                else
                {
                    MessageBox.Show("Először meg kell nyitnod egy képet!");
                }
            }
        }
    }
}
