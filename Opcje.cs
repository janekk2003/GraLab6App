using System;
using System.Windows.Forms;

namespace GraLab6App
{
    public partial class Opcje : Form
    {
        private Form1 parentForm;

        public Opcje(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            int x = (int)numPlanszaX.Value;
            int y = (int)numPlanszaY.Value;
            int czas = (int)numCzas.Value;
            int dydelfCount = (int)numDydelfy.Value;
            int krokodyle = (int)numKrokodyle.Value;
            int szopy = (int)numSzopy.Value;


            parentForm.NoweOpcje(x, y, czas, dydelfCount, krokodyle, szopy);
            this.Close();
        }
        private void numCzas_ValueChanged(object sender, EventArgs e)
        {
            if (numCzas.Value < 10)
            {
                numCzas.Value = 10;
            }
        }
    }
}
