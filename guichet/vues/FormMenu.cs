using guichet.controleurs;
using guichet.modeles;
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
        private ControleurMenu _controleurMenu;

        public FormMenu(Utilisateur utilisateur)
        {
            InitializeComponent();
            _controleurMenu = new ControleurMenu(utilisateur);
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
            FormDepot formDepot = new FormDepot(_controleurMenu.Utilisateur);
            formDepot.ShowDialog();
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            FormRetrait formRetrait = new FormRetrait(_controleurMenu.Utilisateur);
            formRetrait.ShowDialog();
        }
    }
}
