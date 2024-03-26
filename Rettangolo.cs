using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Ereditarieta
{
    internal class Rettangolo(int larghezza, int altezza, int x, int y) : Forma(x, y)
    {
        public int Larghezza = larghezza;
        public int Altezza = altezza;

        public override void Disegna(PaintEventArgs paintEventArgs)
        {
            Graphics g = paintEventArgs.Graphics;
            g.DrawRectangle(new Pen(Brushes.Blue), Posizione.X, Posizione.Y, Larghezza, Altezza);
        }

    }
}