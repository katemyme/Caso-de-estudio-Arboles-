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

        private void btnBuscarRama_Click(object sender, EventArgs e)
        {
            string textoBuscar = TbRama.Text.Trim();
            if (textoBuscar.Length == 0) return;

            TreeNode nodoEncontrado = BuscarNodo(tvArbol.Nodes, textoBuscar);

            if (nodoEncontrado != null)
            {
                tvArbol.SelectedNode.BackColor = tvArbol.BackColor;
                tvArbol.SelectedNode = nodoEncontrado;
                tvArbol.SelectedNode.Expand();
                nodoEncontrado.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("Nodo no encontrado");
            }
        }

        private TreeNode BuscarNodo(TreeNodeCollection nodos, string textoBuscar)
        {
            foreach (TreeNode nodo in nodos)
            {
                if (nodo.Text.Equals(textoBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    return nodo;
                }

                TreeNode nodoEncontrado = BuscarNodo(nodo.Nodes, textoBuscar);
                if (nodoEncontrado != null)
                {
                    return nodoEncontrado;
                }
            }
            return null;
        }

        private void btnElimiarRama_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Seleccione un Nodo para eliminar");
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lblContar_Click(object sender, EventArgs e)
        {
            int contador = tvArbol.GetNodeCount(true);
            lblContar.Text = "El arbol tiene " + contador + " nodos";
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (cbRecorrerPor.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de recorrido");
                return;
            }

            string tipo = cbRecorrerPor.SelectedItem.ToString();
            List<string> recorrido = new List<string>();

            switch (tipo)
            {
                case "Preorden":
                    RecorridoPreOrden(tvArbol.Nodes[0], recorrido);
                    break;

                case "Postorden":
                    RecorridoPostOrden(tvArbol.Nodes[0], recorrido);
                    break;

                case "Por niveles":
                    recorrido = RecorridoPorNiveles();
                    break;

                default:
                    MessageBox.Show("Opción inválida");
                    return;
            }

            MostrarEnListBox(recorrido);

            MessageBox.Show(
                string.Join(" → ", recorrido),
                "Recorrido: " + tipo
            );
        }

        private void RecorrerNodos(TreeNodeCollection nodos, StringBuilder sb, int nivel)
        {
            foreach (TreeNode nodo in nodos)
            {
                sb.AppendLine(new string(' ', nivel * 2) + nodo.Text);
                RecorrerNodos(nodo.Nodes, sb, nivel + 1);
            }
        }

        private void RbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void MostrarEnListBox(List<string> recorrido)
        {
            lbRecorrer.Items.Clear();
            foreach (string nodo in recorrido)
                lbRecorrer.Items.Add(nodo);
        }

        private void RecorridoPreOrden(TreeNode nodo, List<string> lista)
        {
            if (nodo == null) return;

            lista.Add(nodo.Text);

            foreach (TreeNode hijo in nodo.Nodes)
                RecorridoPreOrden(hijo, lista);
        }

        private void RecorridoPostOrden(TreeNode nodo, List<string> lista)
        {
            if (nodo == null) return;

            foreach (TreeNode hijo in nodo.Nodes)
                RecorridoPostOrden(hijo, lista);

            lista.Add(nodo.Text);
        }

        private List<string> RecorridoPorNiveles()
        {
            List<string> recorrido = new List<string>();

            if (tvArbol.Nodes.Count == 0) return recorrido;

            Queue<TreeNode> cola = new Queue<TreeNode>();
            cola.Enqueue(tvArbol.Nodes[0]);

            while (cola.Count > 0)
            {
                TreeNode actual = cola.Dequeue();
                recorrido.Add(actual.Text);

                foreach (TreeNode hijo in actual.Nodes)
                    cola.Enqueue(hijo);
            }

            return recorrido;
        }
    }
}
