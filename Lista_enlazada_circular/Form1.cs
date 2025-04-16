using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_enlazada_circular
{
    public partial class Form1: Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        Lista li = new Lista();
        private void btnInsertFinal_Click(object sender, EventArgs e)
        {            
            if (li.Buscar(int.Parse(txtNuevo.Text)))           
                MessageBox.Show("El dato ya existe");           
            else
            {
                li.insertar_Final(int.Parse(txtNuevo.Text));
                txtNuevo.Clear();
                txtNuevo.Focus();               
            }               
        }

        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            li.listado(lstBox);
        }

        private void btnInsertInicio_Click(object sender, EventArgs e)
        {
            if (li.Buscar(int.Parse(txtNuevo.Text)))            
                MessageBox.Show("El dato ya existe");         
            else
            {
                li.insertar_inicio(int.Parse(txtNuevo.Text));
                txtNuevo.Clear();
                txtNuevo.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (li.Buscar(int.Parse(txtNuevo.Text)))
                MessageBox.Show("El dato existe");
            else
                MessageBox.Show("El dato no existe");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (li.Buscar(int.Parse(txtNuevo.Text)))
            {
                if (li.Buscar(int.Parse(txtModifica.Text)))
                    MessageBox.Show("El dato ya existe");
                else
                {
                    li.Modificar(int.Parse(txtNuevo.Text), int.Parse(txtModifica.Text));
                    txtModifica.Clear();
                    txtNuevo.Clear();
                }
            }
            else
                MessageBox.Show("Dato no existente");
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            li.contar();
        }
    }
}
