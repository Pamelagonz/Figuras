using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Figura
    {
        protected int X, Y;
        protected Pen pluma;
        protected SolidBrush brocha;
         
        protected Color color;
        protected int ancho;
        protected int largo;

        public Figura(int x,int y)
        {
            X=x;
            Y=y;
            brocha = new SolidBrush(Color.Orange);
            pluma=new Pen(Color.Red,2);
            //Random red = new Random();
            

            Random ra = new Random();
            ancho = ra.Next(10, 60);
            largo = ancho;
        }

        public abstract void Dibuja(Form f);

        public int CompareTo(object obj)
        {
            return this.largo.CompareTo(((Figura)obj).largo);
        }
    }

    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y)
            : base(x, y)
        {
        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
            g.FillRectangle(brocha, this.X, this.Y, ancho, largo);
        }
    }

class Circulo:Figura
    {
        public Circulo(int x, int y):base(x,y)
        {
        }
            public override void Dibuja(Form f)
        {
            Graphics g=f.CreateGraphics();
            g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
            g.FillEllipse(brocha, this.X, this.Y, ancho, largo);
    }
}
}

