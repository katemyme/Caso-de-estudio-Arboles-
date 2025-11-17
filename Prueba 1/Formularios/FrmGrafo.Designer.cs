namespace Prueba_1.Formularios
{
    partial class FrmGrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarGrafo = new System.Windows.Forms.Button();
            this.tbNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConexiones = new System.Windows.Forms.GroupBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConexion = new System.Windows.Forms.Button();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGrafo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRutaOrigen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tnRutaDestino = new System.Windows.Forms.TextBox();
            this.btnCalcularDistancia = new System.Windows.Forms.Button();
            this.gbDistanca = new System.Windows.Forms.GroupBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbConexiones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDistanca.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarGrafo);
            this.groupBox1.Controls.Add(this.tbNodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edificios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregarGrafo
            // 
            this.btnAgregarGrafo.Location = new System.Drawing.Point(232, 31);
            this.btnAgregarGrafo.Name = "btnAgregarGrafo";
            this.btnAgregarGrafo.Size = new System.Drawing.Size(147, 42);
            this.btnAgregarGrafo.TabIndex = 3;
            this.btnAgregarGrafo.Text = "Agregar ";
            this.btnAgregarGrafo.UseVisualStyleBackColor = true;
            this.btnAgregarGrafo.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNodo
            // 
            this.tbNodo.Location = new System.Drawing.Point(7, 51);
            this.tbNodo.Name = "tbNodo";
            this.tbNodo.Size = new System.Drawing.Size(182, 22);
            this.tbNodo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre del edificio";
            // 
            // gbConexiones
            // 
            this.gbConexiones.Controls.Add(this.tbDistancia);
            this.gbConexiones.Controls.Add(this.label4);
            this.gbConexiones.Controls.Add(this.btnConexion);
            this.gbConexiones.Controls.Add(this.tbDestino);
            this.gbConexiones.Controls.Add(this.label3);
            this.gbConexiones.Controls.Add(this.tbOrigen);
            this.gbConexiones.Controls.Add(this.label2);
            this.gbConexiones.Location = new System.Drawing.Point(20, 199);
            this.gbConexiones.Name = "gbConexiones";
            this.gbConexiones.Size = new System.Drawing.Size(396, 200);
            this.gbConexiones.TabIndex = 1;
            this.gbConexiones.TabStop = false;
            this.gbConexiones.Text = "ConectarNodos";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(13, 152);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(198, 22);
            this.tbDistancia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ingrese la distancia entre los edificios  (Metros )";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(235, 42);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(137, 62);
            this.btnConexion.TabIndex = 4;
            this.btnConexion.Text = "Agregar Conexiones";
            this.btnConexion.UseVisualStyleBackColor = true;
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(13, 91);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(198, 22);
            this.tbDestino.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ingrese el destino";
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(10, 42);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(201, 22);
            this.tbOrigen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese el origen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGrafo);
            this.groupBox2.Location = new System.Drawing.Point(423, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 527);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafo";
            // 
            // lblGrafo
            // 
            this.lblGrafo.Location = new System.Drawing.Point(7, 31);
            this.lblGrafo.Name = "lblGrafo";
            this.lblGrafo.Size = new System.Drawing.Size(592, 493);
            this.lblGrafo.TabIndex = 0;
            this.lblGrafo.Text = "Grafo";
            this.lblGrafo.Click += new System.EventHandler(this.lblGrafo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(178, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Buscar ruta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nombre del edificio 1";
            // 
            // tbRutaOrigen
            // 
            this.tbRutaOrigen.Location = new System.Drawing.Point(22, 483);
            this.tbRutaOrigen.Name = "tbRutaOrigen";
            this.tbRutaOrigen.Size = new System.Drawing.Size(291, 22);
            this.tbRutaOrigen.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre del edificio 2";
            // 
            // tnRutaDestino
            // 
            this.tnRutaDestino.Location = new System.Drawing.Point(20, 545);
            this.tnRutaDestino.Name = "tnRutaDestino";
            this.tnRutaDestino.Size = new System.Drawing.Size(293, 22);
            this.tnRutaDestino.TabIndex = 8;
            // 
            // btnCalcularDistancia
            // 
            this.btnCalcularDistancia.Location = new System.Drawing.Point(20, 585);
            this.btnCalcularDistancia.Name = "btnCalcularDistancia";
            this.btnCalcularDistancia.Size = new System.Drawing.Size(153, 108);
            this.btnCalcularDistancia.TabIndex = 9;
            this.btnCalcularDistancia.Text = "Buscar ruta por BFS";
            this.btnCalcularDistancia.UseVisualStyleBackColor = true;
            // 
            // gbDistanca
            // 
            this.gbDistanca.Controls.Add(this.lblRuta);
            this.gbDistanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDistanca.Location = new System.Drawing.Point(423, 558);
            this.gbDistanca.Name = "gbDistanca";
            this.gbDistanca.Size = new System.Drawing.Size(605, 176);
            this.gbDistanca.TabIndex = 10;
            this.gbDistanca.TabStop = false;
            this.gbDistanca.Text = "Ruta";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(10, 27);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 16);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta";
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 746);
            this.Controls.Add(this.gbDistanca);
            this.Controls.Add(this.btnCalcularDistancia);
            this.Controls.Add(this.tnRutaDestino);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbRutaOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbConexiones);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrafo";
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.FrmGrafo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbConexiones.ResumeLayout(false);
            this.gbConexiones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbDistanca.ResumeLayout(false);
            this.gbDistanca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarGrafo;
        private System.Windows.Forms.TextBox tbNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConexiones;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGrafo;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRutaOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tnRutaDestino;
        private System.Windows.Forms.Button btnCalcularDistancia;
        private System.Windows.Forms.GroupBox gbDistanca;
        private System.Windows.Forms.Label lblRuta;
    }
}