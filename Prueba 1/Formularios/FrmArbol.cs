using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_1.Formularios
{
    public partial class FrmArbol : Form
    {
        public FrmArbol()
        {
            InitializeComponent();
        }

        private void FrmArbol_Load(object sender, EventArgs e)
        {

        }

        private void FrmArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();

        }

        private void Agregar()
        {

            if (tvArbol.Nodes.Count <= 0)
            {
                tvArbol.Nodes.Add(TbNodo.Text);
            }
            else
            {
                MessageBox.Show("No se puede seleccionar mas que un solo mas de un Nodo Padre");
            }
            tvArbol.ExpandAll();
            TbNodo.Clear();
            TbNodo.Focus();

        }

        private void btnAgregarHijo_Click(object sender, EventArgs e)
        {
            string texto = tbHijo.Text.Trim();
            if (texto.Length == 0) return;

            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Nodes.Add(texto);
                tvArbol.SelectedNode.Expand();
            }
            else
            {
                MessageBox.Show("Seleccione un Nodo Padre");
            }
            tvArbol.ExpandAll();
            tbHijo.Clear();
            tbHijo.Focus();

        }


        }
    }
}

