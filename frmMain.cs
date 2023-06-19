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
    public partial class frmMain : Form
    {
        //int AltoPantalla = Screen.PrimaryScreen.WorkingArea.Height;
        //int AnchoPantalla = Screen.PrimaryScreen.WorkingArea.Width;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            //Login.StartPosition = FormStartPosition.Manual;
            Login.StartPosition = FormStartPosition.CenterScreen;
            //Login.Top = AltoPantalla / 2;
            //Login.Left = AnchoPantalla / 2;
            //Login.Left = 830;
            //Login.Top = 330;
            Login.ShowDialog(); 
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp signUp = new frmSignUp();
            signUp.StartPosition = FormStartPosition.CenterScreen;
            signUp.ShowDialog();
        }
    }
}
