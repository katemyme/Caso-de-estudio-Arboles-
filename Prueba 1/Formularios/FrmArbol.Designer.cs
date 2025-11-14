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
            this.label1 = new System.Windows.Forms.Label();
            this.TbNodo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nodo principal";
            // 
            // TbNodo
            // 
            this.TbNodo.Location = new System.Drawing.Point(199, 36);
            this.TbNodo.Name = "TbNodo";
            this.TbNodo.Size = new System.Drawing.Size(225, 22);
            this.TbNodo.TabIndex = 1;
            this.TbNodo.TabStop = false;
            this.toolTip1.SetToolTip(this.TbNodo, "Aqui se escribira el Nodo principal se recuerda que este nodo sera irremovible");
            this.TbNodo.TextChanged += new System.EventHandler(this.TbNodo_TextChanged);
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbNodo);
            this.Controls.Add(this.label1);
            this.Name = "FrmArbol";
            this.Text = "Arbol";
            this.Load += new System.EventHandler(this.FrmArbol_Load);
            this.TextChanged += new System.EventHandler(this.FrmArbol_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNodo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}