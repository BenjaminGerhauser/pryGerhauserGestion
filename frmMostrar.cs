using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmMostrar : Form
    {
        public string[,] matrizDatos = new string[3, 5];
        int c = 0;
        

        public frmMostrar()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            
            
           if (c < 5) 
           {
                c = 0;
           }
            if(cboActividad.SelectedIndex != -1) 
            {
                dataGridViewMuestraTareas.Rows.Clear();
                c = 0;
            }
            
            for (int f = 0; f < matrizDatos.GetLength(0); f++)
            {
                if (cboActividad.SelectedIndex != -1)
                {
                    
                    if (matrizDatos[f, 1] == cboActividad.Text)
                    {
                        if (matrizDatos[f, c] != null)
                        {

                            dataGridViewMuestraTareas.Rows.Add(matrizDatos[f, 0], matrizDatos[f, 1], matrizDatos[f, 2], matrizDatos[f, 3], matrizDatos[f, 4]);
                            c++;
                        }
                    }
                }
                else
                {
                    if (matrizDatos[f, c] != null)
                    {

                        dataGridViewMuestraTareas.Rows.Add(matrizDatos[f, 0], matrizDatos[f, 1], matrizDatos[f, 2], matrizDatos[f, 3], matrizDatos[f, 4]);
                        c++;
                    }
                }
                //if (matrizDatos[f, c] != null)
                //{
                    
                //    dataGridViewMuestraTareas.Rows.Add(matrizDatos[f, 0], matrizDatos[f, 1], matrizDatos[f, 2], matrizDatos[f, 3], matrizDatos[f, 4]);
                //    c++;
                //}
             
            }
        }

        
    } 
}

