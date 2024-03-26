namespace Ereditarieta
{
    internal class Forma(int x, int y)
    {
        public Point Posizione = new Point(x, y);

        public virtual void Disegna(PaintEventArgs paintEventArgs) { }

    }
}