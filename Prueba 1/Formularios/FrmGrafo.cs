using System;
using System.Windows.Forms;
using Prueba_1.Modelos;

namespace Prueba_1.Formularios
{
    public partial class FrmGrafo : Form
    {
        private readonly GrafoModel _grafo = new GrafoModel();

        public FrmGrafo()
        {
            InitializeComponent();
        }

        private void FrmGrafo_Load(object sender, EventArgs e)
        {
            // Asociar evento que no estaba conectado en el diseñador
            btnConexion.Click += btnConexion_Click;
            ActualizarLabel();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nombre = tbNodo.Text.Trim();
            if (_grafo.AgregarEdificio(nombre))
            {
                tbNodo.Clear();
                ActualizarLabel();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el edificio (vacío o ya existe).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            var origen = tbOrigen.Text.Trim();
            var destino = tbDestino.Text.Trim();
            int distancia;
            if (!int.TryParse(tbDistancia.Text.Trim(), out distancia))
            {
                MessageBox.Show("Distancia inválida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_grafo.Conectar(origen, destino, distancia))
            {
                tbOrigen.Clear();
                tbDestino.Clear();
                tbDistancia.Clear();
                ActualizarLabel();
            }
            else
            {
                MessageBox.Show("No se pudo conectar (verifique nombres, existencia y distancia > 0).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarLabel()
        {
            lblGrafo.Text = _grafo.RepresentacionTexto();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void lblGrafo_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
