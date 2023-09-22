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
    public partial class FormDepot : Form
    {
        private ControleurGuichet _controleurGuichet;

        public FormDepot(ControleurGuichet controleurGuichet)
        {
            InitializeComponent();
            _controleurGuichet = controleurGuichet;
        }

        private void btnDeposer_Click(object sender, EventArgs e)
        {
            Deposer(numMontant.Value);
        }

        private void Deposer(decimal montant)
        {
            MessageBox.Show($"Vous avez déposé {montant.ToString("C")} avec succès.");
            Close();
        }
    }
}
