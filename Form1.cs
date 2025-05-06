using System;
using System.Windows.Forms;

namespace GraLab6App
{
    public partial class Form1 : Form
    {
        private int x = 5;
        private int y = 5;
        private int czas = 30;
        private int dydelfCount = 1;
        private int liczbaKrokodyli = 0;
        private int liczbaSzopow = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start startForm = new Start(x, y, czas, dydelfCount, liczbaSzopow, liczbaKrokodyli);
            startForm.Show();
        }

        private void btnOpcje_Click(object sender, EventArgs e)
        {
            Opcje opcjeForm = new Opcje(this);
            opcjeForm.Show();
        }

        public void NoweOpcje(int noweX, int noweY, int nowyCzas, int noweDydelfy, int noweSzopy, int krokodyle)
        {
            x = noweX;
            y = noweY;
            czas = nowyCzas;
            dydelfCount = noweDydelfy;
            liczbaSzopow = noweSzopy; // nowy parametr
            liczbaKrokodyli = krokodyle;
            MessageBox.Show($"Nowe opcje: {x}x{y}, czas: {czas}s, dydelfy: {dydelfCount}, krokodyle: {liczbaKrokodyli}, szopy: {liczbaSzopow}");
        }
        private void btnOpusc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
