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
            this.txtDistanciaTotal = new System.Windows.Forms.TextBox();
            this.txtRutaCorta = new System.Windows.Forms.TextBox();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.cmbDestinoRuta = new System.Windows.Forms.ComboBox();
            this.cmbOrigenRuta = new System.Windows.Forms.ComboBox();
            this.txtResultadoConexo = new System.Windows.Forms.TextBox();
            this.btnEsConexo = new System.Windows.Forms.Button();
            this.txtAdyacencias = new System.Windows.Forms.TextBox();
            this.btnMostrarAdyacencias = new System.Windows.Forms.Button();
            this.lstConexiones = new System.Windows.Forms.ListBox();
            this.btnAgregarConexion = new System.Windows.Forms.Button();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lstEdificios = new System.Windows.Forms.ListBox();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 389);
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
            this.tabPage1.Size = new System.Drawing.Size(449, 363);
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
            this.tabPage2.Controls.Add(this.txtDistanciaTotal);
            this.tabPage2.Controls.Add(this.txtRutaCorta);
            this.tabPage2.Controls.Add(this.btnCalcularRuta);
            this.tabPage2.Controls.Add(this.cmbDestinoRuta);
            this.tabPage2.Controls.Add(this.cmbOrigenRuta);
            this.tabPage2.Controls.Add(this.txtResultadoConexo);
            this.tabPage2.Controls.Add(this.btnEsConexo);
            this.tabPage2.Controls.Add(this.txtAdyacencias);
            this.tabPage2.Controls.Add(this.btnMostrarAdyacencias);
            this.tabPage2.Controls.Add(this.lstConexiones);
            this.tabPage2.Controls.Add(this.btnAgregarConexion);
            this.tabPage2.Controls.Add(this.nudPeso);
            this.tabPage2.Controls.Add(this.cmbDestino);
            this.tabPage2.Controls.Add(this.cmbOrigen);
            this.tabPage2.Controls.Add(this.lstEdificios);
            this.tabPage2.Controls.Add(this.btnAgregarEdificio);
            this.tabPage2.Controls.Add(this.txtNombreEdificio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDistanciaTotal
            // 
            this.txtDistanciaTotal.Location = new System.Drawing.Point(22, 316);
            this.txtDistanciaTotal.Name = "txtDistanciaTotal";
            this.txtDistanciaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaTotal.TabIndex = 16;
            // 
            // txtRutaCorta
            // 
            this.txtRutaCorta.Location = new System.Drawing.Point(22, 290);
            this.txtRutaCorta.Name = "txtRutaCorta";
            this.txtRutaCorta.Size = new System.Drawing.Size(100, 20);
            this.txtRutaCorta.TabIndex = 15;
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.Location = new System.Drawing.Point(22, 261);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularRuta.TabIndex = 14;
            this.btnCalcularRuta.Text = "Calcular ruta";
            this.btnCalcularRuta.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoRuta
            // 
            this.cmbDestinoRuta.FormattingEnabled = true;
            this.cmbDestinoRuta.Location = new System.Drawing.Point(22, 234);
            this.cmbDestinoRuta.Name = "cmbDestinoRuta";
            this.cmbDestinoRuta.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinoRuta.TabIndex = 13;
            // 
            // cmbOrigenRuta
            // 
            this.cmbOrigenRuta.FormattingEnabled = true;
            this.cmbOrigenRuta.Location = new System.Drawing.Point(22, 207);
            this.cmbOrigenRuta.Name = "cmbOrigenRuta";
            this.cmbOrigenRuta.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenRuta.TabIndex = 12;
            // 
            // txtResultadoConexo
            // 
            this.txtResultadoConexo.Location = new System.Drawing.Point(343, 332);
            this.txtResultadoConexo.Name = "txtResultadoConexo";
            this.txtResultadoConexo.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoConexo.TabIndex = 11;
            // 
            // btnEsConexo
            // 
            this.btnEsConexo.Location = new System.Drawing.Point(350, 286);
            this.btnEsConexo.Name = "btnEsConexo";
            this.btnEsConexo.Size = new System.Drawing.Size(84, 36);
            this.btnEsConexo.TabIndex = 10;
            this.btnEsConexo.Text = "Verificar si es conexo";
            this.btnEsConexo.UseVisualStyleBackColor = true;
            // 
            // txtAdyacencias
            // 
            this.txtAdyacencias.Location = new System.Drawing.Point(222, 332);
            this.txtAdyacencias.Name = "txtAdyacencias";
            this.txtAdyacencias.Size = new System.Drawing.Size(100, 20);
            this.txtAdyacencias.TabIndex = 9;
            // 
            // btnMostrarAdyacencias
            // 
            this.btnMostrarAdyacencias.Location = new System.Drawing.Point(219, 286);
            this.btnMostrarAdyacencias.Name = "btnMostrarAdyacencias";
            this.btnMostrarAdyacencias.Size = new System.Drawing.Size(84, 36);
            this.btnMostrarAdyacencias.TabIndex = 8;
            this.btnMostrarAdyacencias.Text = "Mostrar Adyacencias";
            this.btnMostrarAdyacencias.UseVisualStyleBackColor = true;
            // 
            // lstConexiones
            // 
            this.lstConexiones.FormattingEnabled = true;
            this.lstConexiones.Location = new System.Drawing.Point(292, 49);
            this.lstConexiones.Name = "lstConexiones";
            this.lstConexiones.Size = new System.Drawing.Size(120, 108);
            this.lstConexiones.TabIndex = 7;
            // 
            // btnAgregarConexion
            // 
            this.btnAgregarConexion.Location = new System.Drawing.Point(354, 11);
            this.btnAgregarConexion.Name = "btnAgregarConexion";
            this.btnAgregarConexion.Size = new System.Drawing.Size(80, 34);
            this.btnAgregarConexion.TabIndex = 6;
            this.btnAgregarConexion.Text = "Agregar Conexion";
            this.btnAgregarConexion.UseVisualStyleBackColor = true;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(219, 260);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(120, 20);
            this.nudPeso.TabIndex = 5;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(292, 207);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 4;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(292, 175);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 3;
            // 
            // lstEdificios
            // 
            this.lstEdificios.FormattingEnabled = true;
            this.lstEdificios.Location = new System.Drawing.Point(22, 51);
            this.lstEdificios.Name = "lstEdificios";
            this.lstEdificios.Size = new System.Drawing.Size(181, 108);
            this.lstEdificios.TabIndex = 2;
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(128, 11);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(75, 34);
            this.btnAgregarEdificio.TabIndex = 1;
            this.btnAgregarEdificio.Text = "Agregar Edificio";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(22, 22);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEdificio.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
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
        private System.Windows.Forms.TextBox txtDistanciaTotal;
        private System.Windows.Forms.TextBox txtRutaCorta;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.ComboBox cmbDestinoRuta;
        private System.Windows.Forms.ComboBox cmbOrigenRuta;
        private System.Windows.Forms.TextBox txtResultadoConexo;
        private System.Windows.Forms.Button btnEsConexo;
        private System.Windows.Forms.TextBox txtAdyacencias;
        private System.Windows.Forms.Button btnMostrarAdyacencias;
        private System.Windows.Forms.ListBox lstConexiones;
        private System.Windows.Forms.Button btnAgregarConexion;
        private System.Windows.Forms.NumericUpDown nudPeso;
    }
}

