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
        string varTipo, varDetalle, varTareas, varTime, varInfo;
        string[] vecInfo = new string[3];   
        int i;





        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
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
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           


            if (dtpFecha.Value > DateTime.Now)
            {
                varTime = dtpFecha.Value.ToString();
                if (cboTipo.SelectedIndex != -1) 
                {
                    if(varDetalle != "")
                    {
                        varDetalle = txtDetalle.Text;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el detalle de la reunion");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el tipo de reunion");

                }
                varTipo = cboTipo.Text;
                varDetalle = txtDetalle.Text;

                if (rbSi.Checked == true)
                {
                    if (chkDebate.Checked)
                    {
                        varTareas += chkDebate.Text;
                    }
                    else
                    {
                        varTareas = "";
                    }
                    if (chkInvestigacion.Checked)
                    {
                        varTareas += chkInvestigacion.Text;
                    }
                    else
                    {
                        varTareas += "";
                    }
                    if (chkNotas.Checked)
                    {
                        varTareas += chkNotas.Text;
                    }
                    else
                    {
                        varTareas += "";
                    }
                    if (chkRepositorio.Checked)
                    {
                        varTareas += chkRepositorio.Text;
                    }
                    else
                    {
                        varTareas += "";
                    }
                    
                }
                else
                {
                    if (rbNo.Checked == true)
                    {
                        varTareas = "";
                    }
                    else
                    {
                        varTareas = "";
                    }
                }
                varInfo = varTime + varTipo + varDetalle + varTareas;
                vecInfo[i] = varInfo;



            }
            else
            {
                MessageBox.Show("La fecha seleccionada es incorrecta, selecciones una posterior a hoy","Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;

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

            lbl.Text = vecInfo[i];
            comboBox1.Items.Add(vecInfo[i]);
            i++;
        }

   
            


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrar mostrar = new frmMostrar();
            mostrar.ShowDialog();
        }

    }
        

        
    
    

}
