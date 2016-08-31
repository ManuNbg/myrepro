using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MeinErstesForms
{
    class Fenster : Form
    {
        public Fenster()
        {
            BackColor = Color.DeepSkyBlue;
            Text = "Emanuele";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int zahl = 0;
            int pos1 = 0;
            Graphics gra = e.Graphics;
            for (int i = 0; i < 100; i++)
            {
                gra.DrawString("Zeile " + zahl, Font, Brushes.White, 0, pos1);
                zahl++;
                pos1 += 10;

            }
            //Pen pe = new Pen(Color.Red, 5);
            //Rectangle rec = new Rectangle();
            //rec.Height = 100;
            //rec.Width = 100;
            //rec.X = 100;
            //rec.Y = 100;
            //gra.DrawLine(pe, 10, 10, 100, 100);

            //gra.DrawRectangle(pe, rec);
            //gra.DrawEllipse(new Pen(Color.GreenYellow, 4), rec);
            //gra.FillPie(Brushes.Indigo, 150, 150, 100, 100, 0, 90);
        }

    }
}
