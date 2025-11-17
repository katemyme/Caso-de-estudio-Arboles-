namespace Prueba_1.Formularios
{
    partial class FrmArbol
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbHijo = new System.Windows.Forms.TextBox();
            this.TbNodo = new System.Windows.Forms.TextBox();
            this.gbJerarquizacion = new System.Windows.Forms.GroupBox();
            this.btnElimiarRama = new System.Windows.Forms.Button();
            this.btnBuscarRama = new System.Windows.Forms.Button();
            this.TbRama = new System.Windows.Forms.TextBox();
            this.Busc = new System.Windows.Forms.Label();
            this.btnAgregarHijo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRecorrer = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.cbRecorrerPor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbJerarquizacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHijo
            // 
            this.tbHijo.Location = new System.Drawing.Point(170, 110);
            this.tbHijo.Name = "tbHijo";
            this.tbHijo.Size = new System.Drawing.Size(225, 22);
            this.tbHijo.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tbHijo, "Se pueden seleccionar los hijos deseados a partir del nodo principal");
            // 
            // TbNodo
            // 
            this.TbNodo.Location = new System.Drawing.Point(170, 59);
            this.TbNodo.Name = "TbNodo";
            this.TbNodo.Size = new System.Drawing.Size(225, 22);
            this.TbNodo.TabIndex = 8;
            this.TbNodo.TabStop = false;
            this.toolTip1.SetToolTip(this.TbNodo, "Aqui se escribira el Nodo principal se recuerda que este nodo sera irremovible");
            // 
            // gbJerarquizacion
            // 
            this.gbJerarquizacion.Controls.Add(this.btnElimiarRama);
            this.gbJerarquizacion.Controls.Add(this.btnBuscarRama);
            this.gbJerarquizacion.Controls.Add(this.TbRama);
            this.gbJerarquizacion.Controls.Add(this.Busc);
            this.gbJerarquizacion.Controls.Add(this.btnAgregarHijo);
            this.gbJerarquizacion.Controls.Add(this.tbHijo);
            this.gbJerarquizacion.Controls.Add(this.label2);
            this.gbJerarquizacion.Controls.Add(this.btnAgregar);
            this.gbJerarquizacion.Controls.Add(this.tvArbol);
            this.gbJerarquizacion.Controls.Add(this.TbNodo);
            this.gbJerarquizacion.Controls.Add(this.label1);
            this.gbJerarquizacion.Location = new System.Drawing.Point(13, 24);
            this.gbJerarquizacion.Name = "gbJerarquizacion";
            this.gbJerarquizacion.Size = new System.Drawing.Size(570, 699);
            this.gbJerarquizacion.TabIndex = 0;
            this.gbJerarquizacion.TabStop = false;
            this.gbJerarquizacion.Text = "Jerarquizacio (Arbol)";
            this.gbJerarquizacion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnElimiarRama
            // 
            this.btnElimiarRama.Location = new System.Drawing.Point(445, 200);
            this.btnElimiarRama.Name = "btnElimiarRama";
            this.btnElimiarRama.Size = new System.Drawing.Size(75, 23);
            this.btnElimiarRama.TabIndex = 17;
            this.btnElimiarRama.Text = "Eliminar Rama";
            this.btnElimiarRama.UseVisualStyleBackColor = true;
            this.btnElimiarRama.Click += new System.EventHandler(this.btnElimiarRama_Click);
            // 
            // btnBuscarRama
            // 
            this.btnBuscarRama.Location = new System.Drawing.Point(445, 158);
            this.btnBuscarRama.Name = "btnBuscarRama";
            this.btnBuscarRama.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarRama.TabIndex = 16;
            this.btnBuscarRama.Text = "Buscar Rama";
            this.btnBuscarRama.UseVisualStyleBackColor = true;
            this.btnBuscarRama.Click += new System.EventHandler(this.btnBuscarRama_Click);
            // 
            // TbRama
            // 
            this.TbRama.Location = new System.Drawing.Point(170, 154);
            this.TbRama.Name = "TbRama";
            this.TbRama.Size = new System.Drawing.Size(225, 22);
            this.TbRama.TabIndex = 15;
            // 
            // Busc
            // 
            this.Busc.AutoSize = true;
            this.Busc.Location = new System.Drawing.Point(20, 161);
            this.Busc.Name = "Busc";
            this.Busc.Size = new System.Drawing.Size(89, 16);
            this.Busc.TabIndex = 14;
            this.Busc.Text = "Buscar Rama";
            // 
            // btnAgregarHijo
            // 
            this.btnAgregarHijo.Location = new System.Drawing.Point(445, 109);
            this.btnAgregarHijo.Name = "btnAgregarHijo";
            this.btnAgregarHijo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHijo.TabIndex = 13;
            this.btnAgregarHijo.Text = "Agregar";
            this.btnAgregarHijo.UseVisualStyleBackColor = true;
            this.btnAgregarHijo.Click += new System.EventHandler(this.btnAgregarHijo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese la rama";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(445, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(20, 227);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(305, 445);
            this.tvArbol.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese el nodo principal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContar);
            this.groupBox1.Location = new System.Drawing.Point(615, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblContar
            // 
            this.lblContar.AutoSize = true;
            this.lblContar.Location = new System.Drawing.Point(15, 30);
            this.lblContar.Name = "lblContar";
            this.lblContar.Size = new System.Drawing.Size(124, 16);
            this.lblContar.TabIndex = 0;
            this.lblContar.Text = "Numero de ramas : ";
            this.lblContar.Click += new System.EventHandler(this.lblContar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRecorrer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRecorrer);
            this.groupBox2.Controls.Add(this.cbRecorrerPor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(615, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 610);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbRecorrer
            // 
            this.lbRecorrer.FormattingEnabled = true;
            this.lbRecorrer.ItemHeight = 16;
            this.lbRecorrer.Location = new System.Drawing.Point(25, 90);
            this.lbRecorrer.Name = "lbRecorrer";
            this.lbRecorrer.Size = new System.Drawing.Size(481, 500);
            this.lbRecorrer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(293, 33);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 2;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // cbRecorrerPor
            // 
            this.cbRecorrerPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecorrerPor.FormattingEnabled = true;
            this.cbRecorrerPor.Items.AddRange(new object[] {
            "Preorden",
            "Postorden",
            "Por niveles"});
            this.cbRecorrerPor.Location = new System.Drawing.Point(139, 31);
            this.cbRecorrerPor.Name = "cbRecorrerPor";
            this.cbRecorrerPor.Size = new System.Drawing.Size(121, 24);
            this.cbRecorrerPor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Forma de recorrer";
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbJerarquizacion);
            this.Name = "FrmArbol";
            this.Text = "Arbol";
            this.Load += new System.EventHandler(this.FrmArbol_Load);
            this.TextChanged += new System.EventHandler(this.FrmArbol_TextChanged);
            this.gbJerarquizacion.ResumeLayout(false);
            this.gbJerarquizacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbJerarquizacion;
        private System.Windows.Forms.Button btnAgregarHijo;
        private System.Windows.Forms.TextBox tbHijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.TextBox TbNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElimiarRama;
        private System.Windows.Forms.Button btnBuscarRama;
        private System.Windows.Forms.TextBox TbRama;
        private System.Windows.Forms.Label Busc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRecorrerPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.ListBox lbRecorrer;
    }
}