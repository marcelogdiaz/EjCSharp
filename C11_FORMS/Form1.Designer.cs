namespace C11_FORMS
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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.buttonHabilitarTab = new System.Windows.Forms.Button();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.groupBoxTitulo = new System.Windows.Forms.GroupBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.buttonTitulo = new System.Windows.Forms.Button();
            this.checkBoxTab = new System.Windows.Forms.CheckBox();
            this.radioButtonMontributista = new System.Windows.Forms.RadioButton();
            this.radioButtonRelDependencia = new System.Windows.Forms.RadioButton();
            this.radioButtonAutonomo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInformacion = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.groupBoxTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage2);
            this.tabControlPrincipal.Enabled = false;
            this.tabControlPrincipal.Location = new System.Drawing.Point(18, 23);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(444, 333);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Controls.Add(this.checkBoxTab);
            this.panelIzquierdo.Controls.Add(this.buttonHabilitarTab);
            this.panelIzquierdo.Controls.Add(this.tabControlPrincipal);
            this.panelIzquierdo.Location = new System.Drawing.Point(13, 13);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(478, 463);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // buttonHabilitarTab
            // 
            this.buttonHabilitarTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHabilitarTab.Location = new System.Drawing.Point(104, 388);
            this.buttonHabilitarTab.Name = "buttonHabilitarTab";
            this.buttonHabilitarTab.Size = new System.Drawing.Size(142, 56);
            this.buttonHabilitarTab.TabIndex = 2;
            this.buttonHabilitarTab.Text = "Habilitar Tab";
            this.buttonHabilitarTab.UseVisualStyleBackColor = true;
            this.buttonHabilitarTab.Click += new System.EventHandler(this.buttonHabilitarTab_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.Controls.Add(this.panel1);
            this.panelDerecho.Controls.Add(this.groupBoxTitulo);
            this.panelDerecho.Location = new System.Drawing.Point(497, 12);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(395, 463);
            this.panelDerecho.TabIndex = 2;
            // 
            // groupBoxTitulo
            // 
            this.groupBoxTitulo.Controls.Add(this.buttonTitulo);
            this.groupBoxTitulo.Controls.Add(this.textBoxTitulo);
            this.groupBoxTitulo.Controls.Add(this.labelTitulo);
            this.groupBoxTitulo.Location = new System.Drawing.Point(20, 23);
            this.groupBoxTitulo.Name = "groupBoxTitulo";
            this.groupBoxTitulo.Size = new System.Drawing.Size(359, 123);
            this.groupBoxTitulo.TabIndex = 0;
            this.groupBoxTitulo.TabStop = false;
            this.groupBoxTitulo.Text = "Informacion sobre titulo";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(20, 34);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(110, 20);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Ingrese Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(136, 34);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.Text = "...";
            // 
            // buttonTitulo
            // 
            this.buttonTitulo.Location = new System.Drawing.Point(84, 72);
            this.buttonTitulo.Name = "buttonTitulo";
            this.buttonTitulo.Size = new System.Drawing.Size(134, 46);
            this.buttonTitulo.TabIndex = 2;
            this.buttonTitulo.Text = "Cambiar Titulo";
            this.buttonTitulo.UseVisualStyleBackColor = true;
            this.buttonTitulo.Click += new System.EventHandler(this.buttonTitulo_Click);
            // 
            // checkBoxTab
            // 
            this.checkBoxTab.AutoSize = true;
            this.checkBoxTab.Location = new System.Drawing.Point(22, 362);
            this.checkBoxTab.Name = "checkBoxTab";
            this.checkBoxTab.Size = new System.Drawing.Size(119, 20);
            this.checkBoxTab.TabIndex = 3;
            this.checkBoxTab.Text = "Tab Habilitado";
            this.checkBoxTab.UseVisualStyleBackColor = true;
            // 
            // radioButtonMontributista
            // 
            this.radioButtonMontributista.AutoSize = true;
            this.radioButtonMontributista.Checked = true;
            this.radioButtonMontributista.Location = new System.Drawing.Point(22, 146);
            this.radioButtonMontributista.Name = "radioButtonMontributista";
            this.radioButtonMontributista.Size = new System.Drawing.Size(111, 20);
            this.radioButtonMontributista.TabIndex = 1;
            this.radioButtonMontributista.TabStop = true;
            this.radioButtonMontributista.Text = "Monotributista";
            this.radioButtonMontributista.UseVisualStyleBackColor = true;
            // 
            // radioButtonRelDependencia
            // 
            this.radioButtonRelDependencia.AutoSize = true;
            this.radioButtonRelDependencia.Location = new System.Drawing.Point(22, 172);
            this.radioButtonRelDependencia.Name = "radioButtonRelDependencia";
            this.radioButtonRelDependencia.Size = new System.Drawing.Size(186, 20);
            this.radioButtonRelDependencia.TabIndex = 2;
            this.radioButtonRelDependencia.Text = "Relacion de Dependencia";
            this.radioButtonRelDependencia.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutonomo
            // 
            this.radioButtonAutonomo.AutoSize = true;
            this.radioButtonAutonomo.Location = new System.Drawing.Point(22, 199);
            this.radioButtonAutonomo.Name = "radioButtonAutonomo";
            this.radioButtonAutonomo.Size = new System.Drawing.Size(89, 20);
            this.radioButtonAutonomo.TabIndex = 3;
            this.radioButtonAutonomo.Text = "Autonomo";
            this.radioButtonAutonomo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Edad,
            this.Domicilio});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(11, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(391, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 85;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 69;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 92;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownEdad);
            this.panel1.Controls.Add(this.textBoxDomicilio);
            this.panel1.Controls.Add(this.labelDomicilio);
            this.panel1.Controls.Add(this.labelEdad);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.buttonInformacion);
            this.panel1.Controls.Add(this.radioButtonMontributista);
            this.panel1.Controls.Add(this.radioButtonAutonomo);
            this.panel1.Controls.Add(this.radioButtonRelDependencia);
            this.panel1.Location = new System.Drawing.Point(21, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 293);
            this.panel1.TabIndex = 4;
            // 
            // buttonInformacion
            // 
            this.buttonInformacion.Location = new System.Drawing.Point(105, 237);
            this.buttonInformacion.Name = "buttonInformacion";
            this.buttonInformacion.Size = new System.Drawing.Size(130, 45);
            this.buttonInformacion.TabIndex = 4;
            this.buttonInformacion.Text = "Ver Informacion";
            this.buttonInformacion.UseVisualStyleBackColor = true;
            this.buttonInformacion.Click += new System.EventHandler(this.buttonInformacion_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(135, 18);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 22);
            this.textBoxNombre.TabIndex = 6;
            this.textBoxNombre.Text = "...";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(19, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(130, 20);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Ingrese Nombre";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(19, 51);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(88, 16);
            this.labelEdad.TabIndex = 7;
            this.labelEdad.Text = "Ingrese Edad";
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(135, 89);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(200, 22);
            this.textBoxDomicilio.TabIndex = 10;
            this.textBoxDomicilio.Text = "...";
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(19, 89);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(139, 20);
            this.labelDomicilio.TabIndex = 9;
            this.labelDomicilio.Text = "Ingrese Domicilio";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(138, 51);
            this.numericUpDownEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownEdad.TabIndex = 11;
            this.numericUpDownEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 504);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.Name = "Form1";
            this.Text = "Formulario Clase 11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdo.PerformLayout();
            this.panelDerecho.ResumeLayout(false);
            this.groupBoxTitulo.ResumeLayout(false);
            this.groupBoxTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button buttonHabilitarTab;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.GroupBox groupBoxTitulo;
        private System.Windows.Forms.Button buttonTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.CheckBox checkBoxTab;
        private System.Windows.Forms.RadioButton radioButtonRelDependencia;
        private System.Windows.Forms.RadioButton radioButtonMontributista;
        private System.Windows.Forms.RadioButton radioButtonAutonomo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonInformacion;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
    }
}

