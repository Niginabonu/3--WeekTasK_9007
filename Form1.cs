using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3__WeekTasK_9007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Tomato);
            Graphics g = panel1.CreateGraphics();
            g.FillPie(sb, 100, 100, 100, 100, 200, 570);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 10, 255, 10), 400);
            e.Graphics.DrawRectangle(pen, 100, 100, 100, 100);
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics plain = panel3.CreateGraphics();
            SolidBrush solidBrush = new SolidBrush(Color.Violet);
            Point[] points = { new Point(10, 10), new Point(100, 10), new Point(50, 200) };
            plain.FillPolygon(solidBrush, points);
        }
    }
}
