using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        enum TipoFigura {Rectangulo,Circulo};

        private TipoFigura figura_actual;
        private List<Figura> rectangulos;

        //List<Figura> figuras

        //public Form1()
        //{
            //figuras = new List<Figura>();
            //InitializeComponent();
        //}

        public Form1()
        {
        figura_actual = TipoFigura.Circulo;
        InitializeComponent();
        circuloToolStripMenuItem.Checked = true;
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //if (e.Button == MouseButtons.Left)
        //{
        //Circulo c = new Circulo(e.X, e.Y);
        //c.Dibuja(this);
        //figuras.Add(c);
        //}
        //else if (e.Button == MouseButtons.Right)
        //{
        //Rectangulo r = new Rectangulo(e.X, e.Y);
        //r.Dibuja(this);
        //figuras.Add(r);
        //}
        //}

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
            else if (MouseButtons.Right == e.Button)
            {
                if (figura_actual == TipoFigura.Circulo)
                {
                    Circulo c = new Circulo(e.X, e.Y);
                    c.Dibuja(this);
                    rectangulos.Add(c);
                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    Rectangulo r = new Rectangulo(e.X, e.Y);
                    r.Dibuja(this);
                    rectangulos.Add(r);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Polimorfismo
            foreach (Figura r in rectangulos)
                r.Dibuja(this);
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Rectangulo;
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangulos.Sort();
            rectangulos.Reverse();
        }
    }
}
