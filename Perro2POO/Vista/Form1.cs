using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perro2POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLarar_Click(object sender, EventArgs e)
        {
            ladrar();
        }

        private void ladrar()
        {
            MessageBox.Show("El perro ladro...");
        }

        private void btnChillar_Click(object sender, EventArgs e)
        {
            chillar();
        }

        public void chillar()
        {
            MessageBox.Show("El perro chillo...");
        }

        private void btnBañar_Click(object sender, EventArgs e)
        {
            bañar();
        }

        public void bañar()
        {
            MessageBox.Show("El perro fue bañado...");
        }

        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            abandonar();
        }

        public void abandonar()
        {
                MessageBox.Show("El perro fue abandonado...");
                limpiar();
            
        }

        public void limpiar()
        {
            txtRaza.Text = null;
            txtCodigo.Text = null;
            txtColor.Text = null;
            txtNombre.Text = null;
            txtAmo.Text = null;
            cbxPulgas.Text = null;
        }

        private void cbxPulgas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
