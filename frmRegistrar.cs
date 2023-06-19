using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{

    public partial class frmRegistrar : Form
    {
        string varTipo, varDetalle, varTareas, varTime, varInfo, varReunion;
        int i, indicefila;

        frmMostrar objetoMostrar = new frmMostrar();


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.StartPosition = FormStartPosition.CenterScreen;
            frmMain.ShowDialog();
        }

        private void rbNo_Click(object sender, EventArgs e)
        {
            chkDebate.Enabled = false;
            chkInvestigacion.Enabled = false;
            chkNotas.Enabled = false;
            chkRepositorio.Enabled = false;
        }

        private void rbSi_Click(object sender, EventArgs e)
        {
            chkDebate.Enabled = true;
            chkInvestigacion.Enabled = true;
            chkNotas.Enabled = true;
            chkRepositorio.Enabled = true;
        }


       

        public frmRegistrar()
        {
            InitializeComponent();
            i = 0;
            indicefila = 0;
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           


            if (dtpFecha.Value > DateTime.Now)
            {
                varTime = dtpFecha.Value.ToString();
                if (cboTipo.SelectedIndex != -1) 
                {
                    varTipo = cboTipo.Text;

                    if (txtDetalle.Text != "")
                    {
                        varDetalle = txtDetalle.Text;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el detalle de la reunion");
                        //indicefila--;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el tipo de reunion");
                    //indicefila--;

                }
                //varTipo = cboTipo.Text;
                //varDetalle = txtDetalle.Text;

                if (rbSi.Checked == true)
                {
                    varReunion = "Si";
                    if (chkDebate.Checked)
                    {
                        varTareas += chkDebate.Text + " ";
                    }
                    
                    if (chkInvestigacion.Checked)
                    {
                        varTareas += chkInvestigacion.Text + " ";
                    }

                    if (chkNotas.Checked)
                    {
                        varTareas += chkNotas.Text + " ";
                        
                    }
                    
                    if (chkRepositorio.Checked)
                    {
                        varTareas += chkRepositorio.Text + " ";
                    }
                   
                }
                else
                {
                    if (rbNo.Checked == true)
                    {
                        varReunion = "No";
                    }
                    else
                    {
                        MessageBox.Show("Ingrece SI o NO");
                        //indicefila--;
                    }
                }
                //varInfo = varTime + varTipo + varDetalle + varTareas;
                objetoMostrar.matrizDatos[indicefila, 0] = varTime;
                objetoMostrar.matrizDatos[indicefila, 1] = varTipo;
                objetoMostrar.matrizDatos[indicefila, 2] = varDetalle;
                objetoMostrar.matrizDatos[indicefila, 3] = varReunion;
                objetoMostrar.matrizDatos[indicefila, 4] = varTareas;
                indicefila++;
                if (indicefila == 3)
                {
                    MessageBox.Show("Maximo de tareas registradas");
                    dtpFecha.Enabled = false;
                    cboTipo.Enabled = false;
                    txtDetalle.Enabled = false;
                    rbNo.Enabled = false;
                    rbSi.Enabled = false;
                    btnRegistrar.Enabled = false;

                }
       
            }
            else
            {
                MessageBox.Show("La fecha seleccionada es incorrecta, selecciones una posterior a hoy","Fecha incorrecta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning) ;

            }
            

            txtDetalle.Text = "";
            rbSi.Checked = false;
            rbNo.Checked = false;
            chkDebate.Checked = false;
            chkRepositorio.Checked = false;
            chkNotas.Checked = false;
            chkInvestigacion.Checked = false;
            chkDebate.Enabled = false;
            chkInvestigacion.Enabled = false;
            chkNotas.Enabled = false;
            chkRepositorio.Enabled = false;
            varTime = "";
            varTipo = "";
            varDetalle = "";
            varReunion = "";
            varTareas = "";

            
        }

   
            


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            objetoMostrar.StartPosition = FormStartPosition.CenterScreen;
            objetoMostrar.ShowDialog();
        }

    }
        

        
    
    

}
