using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WForms.Formulario;

namespace WForms
{
    public partial class Hola : Form
    {
        public Hola()
        {
            InitializeComponent();
        }

        private void Hola_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Bienvenido a mi App");
        }

        private void Hola_Activated(object sender, EventArgs e)
        {
            // MessageBox.Show("Bienvenido a mi App");
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegi = new FrmRegistro();
            frmRegi.Show();

        }

        private int intentos = 0;
        private void Login_Click(object sender, EventArgs e)
        {
            string usr = textBoxUsuario.Text.ToLower();
            string pwd = textBoxContraseña.Text.ToLower();
          

            if (usr == "" || pwd == "")
            {
                MessageBox.Show("No se puede dejar en blanco");

            }
            else if (usr.Equals("admin") && pwd.Equals("admin"))
            {
                FrmRegistro registro = new FrmRegistro();
                registro.Show();

            }
            else
            {
                if (intentos >= 3)
                {
                    MessageBox.Show("Has excedido el número de intentos permitidos. El botón ha sido bloqueado.");
                    Login.Enabled = false;
                    textBoxUsuario.Clear();
                    textBoxContraseña.Clear();
                }
                else
                {
                    intentos++;
                    MessageBox.Show("Usuario y contraseña Erroneos. Intento " + intentos + "/3");
                    textBoxUsuario.Clear();
                    textBoxContraseña.Clear();

                }
            }
        }
    }
}

