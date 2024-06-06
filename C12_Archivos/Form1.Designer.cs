namespace C12_Archivos
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.buttonDirectorioActual = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelDesktop = new System.Windows.Forms.Label();
            this.buttonEscritorio = new System.Windows.Forms.Button();
            this.labelDesktopRelativo = new System.Windows.Forms.Label();
            this.labelCombinado = new System.Windows.Forms.Label();
            this.labelNombreDirectorio = new System.Windows.Forms.Label();
            this.textBoxDirectorio = new System.Windows.Forms.TextBox();
            this.buttonCrearDirectorio = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.buttonCrearArchivo = new System.Windows.Forms.Button();
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.labelNombreArchivo = new System.Windows.Forms.Label();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.labelContenido = new System.Windows.Forms.Label();
            this.groupBoxArchivo = new System.Windows.Forms.GroupBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.buttonDirectorios = new System.Windows.Forms.Button();
            this.textBoxMultilineaDirectorio = new System.Windows.Forms.TextBox();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.radioButtonJSON = new System.Windows.Forms.RadioButton();
            this.panelPrincipal.SuspendLayout();
            this.groupBoxArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.radioButtonJSON);
            this.panelPrincipal.Controls.Add(this.radioButtonTXT);
            this.panelPrincipal.Controls.Add(this.textBoxMultilineaDirectorio);
            this.panelPrincipal.Controls.Add(this.buttonDirectorios);
            this.panelPrincipal.Controls.Add(this.groupBoxArchivo);
            this.panelPrincipal.Controls.Add(this.labelMensaje);
            this.panelPrincipal.Controls.Add(this.buttonCrearDirectorio);
            this.panelPrincipal.Controls.Add(this.textBoxDirectorio);
            this.panelPrincipal.Controls.Add(this.labelNombreDirectorio);
            this.panelPrincipal.Controls.Add(this.labelCombinado);
            this.panelPrincipal.Controls.Add(this.labelDesktopRelativo);
            this.panelPrincipal.Controls.Add(this.labelDesktop);
            this.panelPrincipal.Controls.Add(this.buttonEscritorio);
            this.panelPrincipal.Controls.Add(this.labelPath);
            this.panelPrincipal.Controls.Add(this.buttonDirectorioActual);
            this.panelPrincipal.Location = new System.Drawing.Point(19, 17);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(852, 689);
            this.panelPrincipal.TabIndex = 0;
            // 
            // buttonDirectorioActual
            // 
            this.buttonDirectorioActual.Location = new System.Drawing.Point(27, 21);
            this.buttonDirectorioActual.Name = "buttonDirectorioActual";
            this.buttonDirectorioActual.Size = new System.Drawing.Size(205, 64);
            this.buttonDirectorioActual.TabIndex = 0;
            this.buttonDirectorioActual.Text = "Mostrar Directorio Actual";
            this.buttonDirectorioActual.UseVisualStyleBackColor = true;
            this.buttonDirectorioActual.Click += new System.EventHandler(this.buttonDirectorioActual_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(295, 45);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(44, 16);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "PATH";
            // 
            // labelDesktop
            // 
            this.labelDesktop.AutoSize = true;
            this.labelDesktop.Location = new System.Drawing.Point(295, 120);
            this.labelDesktop.Name = "labelDesktop";
            this.labelDesktop.Size = new System.Drawing.Size(150, 20);
            this.labelDesktop.TabIndex = 3;
            this.labelDesktop.Text = "PATH ABSOLUTO";
            // 
            // buttonEscritorio
            // 
            this.buttonEscritorio.Location = new System.Drawing.Point(27, 120);
            this.buttonEscritorio.Name = "buttonEscritorio";
            this.buttonEscritorio.Size = new System.Drawing.Size(205, 64);
            this.buttonEscritorio.TabIndex = 2;
            this.buttonEscritorio.Text = "Mostrar Escritorio";
            this.buttonEscritorio.UseVisualStyleBackColor = true;
            this.buttonEscritorio.Click += new System.EventHandler(this.buttonEscritorio_Click);
            // 
            // labelDesktopRelativo
            // 
            this.labelDesktopRelativo.AutoSize = true;
            this.labelDesktopRelativo.Location = new System.Drawing.Point(295, 168);
            this.labelDesktopRelativo.Name = "labelDesktopRelativo";
            this.labelDesktopRelativo.Size = new System.Drawing.Size(141, 20);
            this.labelDesktopRelativo.TabIndex = 4;
            this.labelDesktopRelativo.Text = "PATH RELATIVO";
            // 
            // labelCombinado
            // 
            this.labelCombinado.AutoSize = true;
            this.labelCombinado.Location = new System.Drawing.Point(295, 215);
            this.labelCombinado.Name = "labelCombinado";
            this.labelCombinado.Size = new System.Drawing.Size(160, 20);
            this.labelCombinado.TabIndex = 5;
            this.labelCombinado.Text = "PATH COMBINADO";
            // 
            // labelNombreDirectorio
            // 
            this.labelNombreDirectorio.AutoSize = true;
            this.labelNombreDirectorio.Location = new System.Drawing.Point(54, 291);
            this.labelNombreDirectorio.Name = "labelNombreDirectorio";
            this.labelNombreDirectorio.Size = new System.Drawing.Size(142, 16);
            this.labelNombreDirectorio.TabIndex = 6;
            this.labelNombreDirectorio.Text = "Nombre del Directorio:";
            // 
            // textBoxDirectorio
            // 
            this.textBoxDirectorio.Location = new System.Drawing.Point(214, 288);
            this.textBoxDirectorio.Name = "textBoxDirectorio";
            this.textBoxDirectorio.Size = new System.Drawing.Size(197, 22);
            this.textBoxDirectorio.TabIndex = 7;
            // 
            // buttonCrearDirectorio
            // 
            this.buttonCrearDirectorio.Location = new System.Drawing.Point(430, 270);
            this.buttonCrearDirectorio.Name = "buttonCrearDirectorio";
            this.buttonCrearDirectorio.Size = new System.Drawing.Size(161, 40);
            this.buttonCrearDirectorio.TabIndex = 8;
            this.buttonCrearDirectorio.Text = "Crear Directorio";
            this.buttonCrearDirectorio.UseVisualStyleBackColor = true;
            this.buttonCrearDirectorio.Click += new System.EventHandler(this.buttonCrearDirectorio_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(656, 291);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 20);
            this.labelMensaje.TabIndex = 9;
            // 
            // buttonCrearArchivo
            // 
            this.buttonCrearArchivo.Location = new System.Drawing.Point(459, 57);
            this.buttonCrearArchivo.Name = "buttonCrearArchivo";
            this.buttonCrearArchivo.Size = new System.Drawing.Size(161, 40);
            this.buttonCrearArchivo.TabIndex = 12;
            this.buttonCrearArchivo.Text = "Crear Archivo";
            this.buttonCrearArchivo.UseVisualStyleBackColor = true;
            this.buttonCrearArchivo.Click += new System.EventHandler(this.buttonCrearArchivo_Click);
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(183, 23);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(197, 22);
            this.textBoxNombreArchivo.TabIndex = 11;
            // 
            // labelNombreArchivo
            // 
            this.labelNombreArchivo.AutoSize = true;
            this.labelNombreArchivo.Location = new System.Drawing.Point(23, 26);
            this.labelNombreArchivo.Name = "labelNombreArchivo";
            this.labelNombreArchivo.Size = new System.Drawing.Size(129, 16);
            this.labelNombreArchivo.TabIndex = 10;
            this.labelNombreArchivo.Text = "Nombre del Archivo:";
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(183, 101);
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(197, 22);
            this.textBoxContenido.TabIndex = 14;
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Location = new System.Drawing.Point(23, 104);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(141, 16);
            this.labelContenido.TabIndex = 13;
            this.labelContenido.Text = "Contenido del Archivo:";
            // 
            // groupBoxArchivo
            // 
            this.groupBoxArchivo.Controls.Add(this.labelExtension);
            this.groupBoxArchivo.Controls.Add(this.textBoxExtension);
            this.groupBoxArchivo.Controls.Add(this.labelNombreArchivo);
            this.groupBoxArchivo.Controls.Add(this.textBoxContenido);
            this.groupBoxArchivo.Controls.Add(this.textBoxNombreArchivo);
            this.groupBoxArchivo.Controls.Add(this.labelContenido);
            this.groupBoxArchivo.Controls.Add(this.buttonCrearArchivo);
            this.groupBoxArchivo.Location = new System.Drawing.Point(36, 328);
            this.groupBoxArchivo.Name = "groupBoxArchivo";
            this.groupBoxArchivo.Size = new System.Drawing.Size(656, 151);
            this.groupBoxArchivo.TabIndex = 15;
            this.groupBoxArchivo.TabStop = false;
            this.groupBoxArchivo.Text = "ARCHIVO";
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(23, 66);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(173, 20);
            this.labelExtension.TabIndex = 15;
            this.labelExtension.Text = "Extension del Archivo:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(183, 66);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(197, 22);
            this.textBoxExtension.TabIndex = 16;
            // 
            // buttonDirectorios
            // 
            this.buttonDirectorios.Location = new System.Drawing.Point(36, 501);
            this.buttonDirectorios.Name = "buttonDirectorios";
            this.buttonDirectorios.Size = new System.Drawing.Size(177, 61);
            this.buttonDirectorios.TabIndex = 16;
            this.buttonDirectorios.Text = "Mostrar Contenido Directorio STORES";
            this.buttonDirectorios.UseVisualStyleBackColor = true;
            this.buttonDirectorios.Click += new System.EventHandler(this.buttonDirectorios_Click);
            // 
            // textBoxMultilineaDirectorio
            // 
            this.textBoxMultilineaDirectorio.Location = new System.Drawing.Point(235, 501);
            this.textBoxMultilineaDirectorio.Multiline = true;
            this.textBoxMultilineaDirectorio.Name = "textBoxMultilineaDirectorio";
            this.textBoxMultilineaDirectorio.Size = new System.Drawing.Size(588, 135);
            this.textBoxMultilineaDirectorio.TabIndex = 17;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Checked = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(62, 579);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(68, 25);
            this.radioButtonTXT.TabIndex = 18;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // radioButtonJSON
            // 
            this.radioButtonJSON.AutoSize = true;
            this.radioButtonJSON.Location = new System.Drawing.Point(62, 605);
            this.radioButtonJSON.Name = "radioButtonJSON";
            this.radioButtonJSON.Size = new System.Drawing.Size(80, 25);
            this.radioButtonJSON.TabIndex = 19;
            this.radioButtonJSON.Text = "JSON";
            this.radioButtonJSON.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 718);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.groupBoxArchivo.ResumeLayout(false);
            this.groupBoxArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonDirectorioActual;
        private System.Windows.Forms.Label labelDesktop;
        private System.Windows.Forms.Button buttonEscritorio;
        private System.Windows.Forms.Label labelDesktopRelativo;
        private System.Windows.Forms.Label labelCombinado;
        private System.Windows.Forms.Label labelNombreDirectorio;
        private System.Windows.Forms.TextBox textBoxDirectorio;
        private System.Windows.Forms.Button buttonCrearDirectorio;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button buttonCrearArchivo;
        private System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.Label labelNombreArchivo;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.GroupBox groupBoxArchivo;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.TextBox textBoxMultilineaDirectorio;
        private System.Windows.Forms.Button buttonDirectorios;
        private System.Windows.Forms.RadioButton radioButtonJSON;
        private System.Windows.Forms.RadioButton radioButtonTXT;
    }
}

