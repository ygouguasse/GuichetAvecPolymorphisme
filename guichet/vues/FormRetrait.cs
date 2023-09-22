using guichet.controleurs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guichet.vues
{
    public partial class FormRetrait : Form
    {
        private ControleurGuichet _controleurGuichet;

        public FormRetrait(ControleurGuichet controleurGuichet)
        {
            InitializeComponent();
            _controleurGuichet = controleurGuichet;
        }

        private void Retirer(decimal montant)
        {
            MessageBox.Show("Veuillez prendre votre argent!");
            Close();
        }

        private void btnRetraitAutre_Click(object sender, EventArgs e)
        {
            Retirer(numRetraitAutre.Value);
        }

        private void btnRetrait20_Click(object sender, EventArgs e)
        {
            Retirer(20);
        }

        private void btnRetrait40_Click(object sender, EventArgs e)
        {
            Retirer(40);
        }

        private void btnRetrait60_Click(object sender, EventArgs e)
        {
            Retirer(60);
        }

        private void btnRetrait80_Click(object sender, EventArgs e)
        {
            Retirer(80);
        }

        private void btnRetrait100_Click(object sender, EventArgs e)
        {
            Retirer(100);
        }

        private void btnRetrait200_Click(object sender, EventArgs e)
        {
            Retirer(200);
        }
    }
}
