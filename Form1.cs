using System.Collections;

namespace Ereditarieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList _forme = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            _forme.Add(new Cerchio(50, 100, 300));
            _forme.Add(new Cerchio(50, 230, 300));
            _forme.Add(new Rettangolo(50, 160, 140, 50));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Forma f in _forme)
                f.Disegna(e);
        }


    }
}
