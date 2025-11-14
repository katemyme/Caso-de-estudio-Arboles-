using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_1.Formularios;

namespace Prueba_1
{
    public partial class FrnPrincipal : Form
    {
        public FrnPrincipal()
        {
            InitializeComponent();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmArbol().Show();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGrafo().Show();
        }

        private void FrnPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
