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
    public partial class frmLogin : Form
    {
        public string[,] matrizUsuario = new string[5, 2] ;
        public frmLogin()
        {
            InitializeComponent();
            matrizUsuario[0, 0] = "Admin";
            matrizUsuario[0, 1] = "Admin";
            matrizUsuario[1, 0] = "Benjamin";
            matrizUsuario[1, 1] = "Benja123";
            for (int f = 1; f < matrizUsuario.GetLength(0); f++)
            {
                for (int c = 1; c < matrizUsuario.GetLength(1); c++)
                {
                    matrizUsuario[f, c] = "";
                }
            }
        }

        
        frmRegistrar mostar = new frmRegistrar();


        private void btnIngresar_Click(object sender, EventArgs e)
        {



            for (int f = 0; f < matrizUsuario.GetLength(0); f++)
            {
                if (txtUsuario.Text == matrizUsuario[f, 0] && txtContraseña.Text == matrizUsuario[f, 1])
                {
                    this.Hide();
                    mostar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            
            //switch (txtUsuario.Text)
            //{
            //    case "Benjamin":
            //        if(txtContraseña.Text == "benja123")
            //        {
            //            this.Hide();
            //            frmRegistrar mostar = new frmRegistrar();
            //            mostar.ShowDialog();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Contraseña incorrecta");

            //        }
            //        break;
            //    case "Hola":
            //        if (txtContraseña.Text == "hola123")
            //        {
            //            this.Hide();
            //            frmMain mostar = new frmMain();
            //            mostar.ShowDialog();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Contraseña incorrecta");

            //        }
            //        break;
            //    case "User":
            //        if (txtContraseña.Text == "User123")
            //        {
            //            this.Hide();
            //            frmMain mostar = new frmMain();
            //            mostar.ShowDialog();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Contraseña incorrecta");

            //        }
            //        break;case "Admin":
            //        if(txtContraseña.Text == "Admin")
            //        {
            //            this.Hide();
            //            frmMain mostar = new frmMain();
            //            mostar.ShowDialog();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Contraseña incorrecta");

            //        }
            //        break;
            //}
        }
    }
}
