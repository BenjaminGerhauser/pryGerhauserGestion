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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            switch (txtUsuario.Text)
            {
                case "Benjamin¨":
                    if(txtContraseña.Text == "benja123")
                    {
                        this.Hide();
                        frmRegistrar mostar = new frmRegistrar();
                        mostar.ShowDialog();
                    }
                    break;
                case "Benjamin":
                    if (txtContraseña.Text == "benja123")
                    {
                        this.Hide();
                        frmMain mostar = new frmMain();
                        mostar.ShowDialog();
                    }
                    break;
                case "User":
                    if (txtContraseña.Text == "User123")
                    {
                        this.Hide();
                        frmMain mostar = new frmMain();
                        mostar.ShowDialog();
                    }
                    break;case "Admin":
                    if(txtContraseña.Text == "Admin")
                    {
                        this.Hide();
                        frmMain mostar = new frmMain();
                        mostar.ShowDialog();
                    }
                    break;
            }
        }
    }
}
