using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmSignUp : Form
    {
        frmLogin objetoLogin = new frmLogin();
        string varNewUsuario, varNewContra, varRepetir;
        int indiceFila, f;

        private void chkVerContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerContra.Checked)
            {
                txtNewContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewContraseña.UseSystemPasswordChar = true;
            }
        }

        private void chkVerRepetir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerContra.Checked)
            {
                txtRepetir.UseSystemPasswordChar = false;
            }
            else
            {
                txtRepetir.UseSystemPasswordChar = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            objetoLogin.ShowDialog();
        }

        public frmSignUp()
        {
            InitializeComponent();
            //objetoLogin.matrizUsuario[0, 0] = "Benja";
            //objetoLogin.matrizUsuario[0, 1] = "Benja123";
            //for (int f = 1; f < objetoLogin.matrizUsuario.GetLength(0); f++)
            //{
            //    for (int c = 1; c < objetoLogin.matrizUsuario.GetLength(1); c++)
            //    {
            //        objetoLogin.matrizUsuario[f, c] = "";
            //    }
            //}
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            indiceFila = 0;
            if (txtNewUsuario.Text != "")
            {
                varNewUsuario = txtNewUsuario.Text;
                while (indiceFila < objetoLogin.matrizUsuario.GetLength(0))
                {
                    if (varNewUsuario == objetoLogin.matrizUsuario[indiceFila, 0])
                    {
                        lblUserError.Visible = false;
                        lblUsuarioExiste.Visible = true;
                        lblUsuarioExiste.Location = new Point(82, 60);
                        indiceFila++;
                        break;
                    }
                    else
                    {
                        if (objetoLogin.matrizUsuario[indiceFila, 0] == "")
                        {
                            objetoLogin.matrizUsuario[indiceFila, 0] = varNewUsuario;
                            if (txtNewContraseña.Text != "")
                            {
                                varNewContra = txtNewContraseña.Text;
                            }

                            if (txtRepetir.Text != "")
                            {
                                varRepetir = txtRepetir.Text;
                            }

                            if (varNewContra == varRepetir)
                            {
                                objetoLogin.matrizUsuario[indiceFila, 1] = varNewContra;
                            }
                            else
                            {
                                lblErrorRepetir.Visible = true;
                            }
                            break;
                        }
                        else
                        {
                            indiceFila++;
                        }
                    }
                }
            }
            else
            {
                lblUserError.Visible = true;
            }
            if (txtNewContraseña.Text != txtRepetir.Text)
            {
                lblErrorRepetir.Visible = true;
            }
            if (txtNewContraseña.Text == "")
            {
                lblErrorNewContra.Visible = true;
            }
            if (txtRepetir.Text == "")
            {
                lblErrorRepetir.Visible = true;
            }           
        }

    }
}
