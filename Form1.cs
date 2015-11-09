using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private float x=0;
        private float y = 0;
        private float speedx = 10;
        private float speedy = 0;
        private int radius = 15;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics(); 
            Color c = Color.FromArgb(szinR, szinG, szinB); 
            Pen p = new PenPen(Color.Blue, 2); 

            Point po = new Point(30, 60); 
            Size s = new Size(50, 80); // méret létrehozása
            Rectangle t = new Rectangle(po, s); // téglalap létrehozása 
            g.DrawRectangle(p, t); 
// a g grafika megrajzolása, p tollal, t téglalapot
            g.DrawLine(p,x1,y1,x2,y2);
            g.FillRectangle(Brushes.Red, t); // kitöltött t téglalap rajzolása pirossal
            g.FillEllipse(Brushes.Green, t); // kitöltött t befoglaló méretű e
            ellipszis rajzolása SolidBrush b = new SolidBrush(c); // RGB színek
            label1.Font = New Font("Calibri", 8, FontStyle.Bold); // font megadása
            FontDialog fdg = new FontDialog(); // font dialógus objektum létrehozása
            fdg.ShowDialog(); 
// mutatás
            label1.Font = fdg.Font; 
// értékadás
            ColorDialog clg = new ColorDialog(); // font dialógus objektum létrehozása 
            clg.ShowDialog(); 
// mutatás
            label1.ForeColor = clg.Color; 
// értékadás
            Image kep = new Bitmap(@"c:\001.jpg"); // kép deklarálása
            pictureBox1.Image = kep;
            x = this.Width / 2 - radius;
            y = this.Height / 2 - radius;
            Random r = new Random();
            speedx = (float)r.NextDouble() * 6 - 3;
            speedy = (float)r.NextDouble() * 6 - 3;
            radius = 15;

            timer1.Interval = 1;
            timer1.Enabled = true;
            System.Threading.Thread.Sleep(1000);// várakozás 
            Application.DoEvents();
        }

    }
}
