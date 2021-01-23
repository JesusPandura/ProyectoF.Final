using MenuDesplegable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(0);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();

            }



            if(circularProgressBar1.Value == 99)
            {

                string usuario = txtUsuario.Text;
                string password = txtPassword.Text;

                try
                {
                    Control ctrl = new Control();
                    string respuesta = ctrl.ctrlLogin(usuario, password);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        circularProgressBar1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show(respuesta = "Usuario  " + Session.usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuDesplegable.frmPrincipal frm = new MenuDesplegable.frmPrincipal();
                        frm.Visible = true;
                        this.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }









        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistro o = new frmRegistro();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
           
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
