using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Ereditarieta
{
    internal class Cerchio(int raggio, int x, int y) : Forma(x, y)
    {
        public int Raggio = raggio;

        public override void Disegna(PaintEventArgs paintEventArgs)
        {
            Graphics g = paintEventArgs.Graphics;
            g.DrawEllipse(new Pen(Brushes.Blue), Posizione.X - Raggio, Posizione.Y - Raggio, Raggio * 2, Raggio * 2);
        }

    }
}