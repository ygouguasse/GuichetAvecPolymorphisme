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
    public partial class FormMenu : Form
    {
        private ControleurGuichet _controleurGuichet;

        public FormMenu(ControleurGuichet controleurGuichet)
        {
            InitializeComponent();
            _controleurGuichet = controleurGuichet;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            FormDepot formDepot = new FormDepot(_controleurGuichet);
            formDepot.ShowDialog();
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            FormRetrait formRetrait = new FormRetrait(_controleurGuichet);
            formRetrait.ShowDialog();
        }
    }
}
