namespace Arbol_Grafo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResultadosArbol = new System.Windows.Forms.TextBox();
            this.btnPorNiveles = new System.Windows.Forms.Button();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.txtBuscarNodo = new System.Windows.Forms.TextBox();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.btnInsertarNodo = new System.Windows.Forms.Button();
            this.txtPadreNodo = new System.Windows.Forms.TextBox();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.tvArbolOrganizacional = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.lstEdificios = new System.Windows.Forms.ListBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResultadosArbol);
            this.tabPage1.Controls.Add(this.btnPorNiveles);
            this.tabPage1.Controls.Add(this.btnPostorden);
            this.tabPage1.Controls.Add(this.btnPreorden);
            this.tabPage1.Controls.Add(this.txtBuscarNodo);
            this.tabPage1.Controls.Add(this.btnBuscarNodo);
            this.tabPage1.Controls.Add(this.btnEliminarNodo);
            this.tabPage1.Controls.Add(this.btnInsertarNodo);
            this.tabPage1.Controls.Add(this.txtPadreNodo);
            this.tabPage1.Controls.Add(this.txtNombreNodo);
            this.tabPage1.Controls.Add(this.tvArbolOrganizacional);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arbol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResultadosArbol
            // 
            this.txtResultadosArbol.Location = new System.Drawing.Point(18, 323);
            this.txtResultadosArbol.Name = "txtResultadosArbol";
            this.txtResultadosArbol.Size = new System.Drawing.Size(314, 20);
            this.txtResultadosArbol.TabIndex = 10;
            // 
            // btnPorNiveles
            // 
            this.btnPorNiveles.Location = new System.Drawing.Point(244, 213);
            this.btnPorNiveles.Name = "btnPorNiveles";
            this.btnPorNiveles.Size = new System.Drawing.Size(75, 23);
            this.btnPorNiveles.TabIndex = 9;
            this.btnPorNiveles.Text = "Niveles";
            this.btnPorNiveles.UseVisualStyleBackColor = true;
            // 
            // btnPostorden
            // 
            this.btnPostorden.Location = new System.Drawing.Point(244, 184);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(75, 23);
            this.btnPostorden.TabIndex = 8;
            this.btnPostorden.Text = "Postorden";
            this.btnPostorden.UseVisualStyleBackColor = true;
            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(244, 146);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(75, 23);
            this.btnPreorden.TabIndex = 7;
            this.btnPreorden.Text = "Preorden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNodo
            // 
            this.txtBuscarNodo.Location = new System.Drawing.Point(219, 23);
            this.txtBuscarNodo.Name = "txtBuscarNodo";
            this.txtBuscarNodo.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNodo.TabIndex = 6;
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.Location = new System.Drawing.Point(244, 49);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNodo.TabIndex = 5;
            this.btnBuscarNodo.Text = "Buscar";
            this.btnBuscarNodo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Location = new System.Drawing.Point(244, 86);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarNodo.TabIndex = 4;
            this.btnEliminarNodo.Text = "Eliminar";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            // 
            // btnInsertarNodo
            // 
            this.btnInsertarNodo.Location = new System.Drawing.Point(124, 23);
            this.btnInsertarNodo.Name = "btnInsertarNodo";
            this.btnInsertarNodo.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarNodo.TabIndex = 3;
            this.btnInsertarNodo.Text = "Insertar";
            this.btnInsertarNodo.UseVisualStyleBackColor = true;
            // 
            // txtPadreNodo
            // 
            this.txtPadreNodo.Location = new System.Drawing.Point(18, 51);
            this.txtPadreNodo.Name = "txtPadreNodo";
            this.txtPadreNodo.Size = new System.Drawing.Size(100, 20);
            this.txtPadreNodo.TabIndex = 2;
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(18, 23);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreNodo.TabIndex = 1;
            // 
            // tvArbolOrganizacional
            // 
            this.tvArbolOrganizacional.Location = new System.Drawing.Point(16, 86);
            this.tvArbolOrganizacional.Name = "tvArbolOrganizacional";
            this.tvArbolOrganizacional.Size = new System.Drawing.Size(183, 231);
            this.tvArbolOrganizacional.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbDestino);
            this.tabPage2.Controls.Add(this.cmbOrigen);
            this.tabPage2.Controls.Add(this.lstEdificios);
            this.tabPage2.Controls.Add(this.btnAgregarEdificio);
            this.tabPage2.Controls.Add(this.txtNombreEdificio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(47, 22);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEdificio.TabIndex = 0;
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(47, 48);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEdificio.TabIndex = 1;
            this.btnAgregarEdificio.Text = "Agregar";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            // 
            // lstEdificios
            // 
            this.lstEdificios.FormattingEnabled = true;
            this.lstEdificios.Location = new System.Drawing.Point(48, 110);
            this.lstEdificios.Name = "lstEdificios";
            this.lstEdificios.Size = new System.Drawing.Size(120, 95);
            this.lstEdificios.TabIndex = 2;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(48, 227);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 3;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(48, 264);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView tvArbolOrganizacional;
        private System.Windows.Forms.TextBox txtBuscarNodo;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Button btnInsertarNodo;
        private System.Windows.Forms.TextBox txtPadreNodo;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.TextBox txtResultadosArbol;
        private System.Windows.Forms.Button btnPorNiveles;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ListBox lstEdificios;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.TextBox txtNombreEdificio;
    }
}

