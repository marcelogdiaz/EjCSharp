using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C11_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que habilita el control TAB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHabilitarTab_Click(object sender, EventArgs e)
        {
            tabControlPrincipal.Enabled = true;
            checkBoxTab.Checked = true;
        }

        /// <summary>
        /// Evento que me permite cambiar el titulo del FORMULARIO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTitulo_Click(object sender, EventArgs e)
        {
            this.Text = textBoxTitulo.Text;
        }

        /// <summary>
        /// Evento que muestra en MESSAGEBOX la informacion de la persona INGRESADA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInformacion_Click(object sender, EventArgs e)
        {
            string mensaje = "Edad: "+ numericUpDownEdad.Value + System.Environment.NewLine;
            mensaje += "Domicilio: "+textBoxDomicilio.Text + System.Environment.NewLine;
            
            if(radioButtonAutonomo.Checked ) { mensaje += "Autonomo"; }
            if (radioButtonMontributista.Checked) { mensaje += "Monotributista"; }
            if (radioButtonRelDependencia.Checked) { mensaje += "Relacion de Dependencia"; }


            var result = MessageBox.Show(mensaje,"Informacion de "+ textBoxNombre.Text, MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

            }
            else if (result == DialogResult.Cancel) { 

            }
        }
    }
}
