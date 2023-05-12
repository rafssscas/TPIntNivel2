using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPFinalNivel2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuArticulo_Click(object sender, EventArgs e)
        {
            if(this.ActivateMdiChild != null)
            {
                this.ActivateMdiChild.Close();
            }

            frmArticulo frmArticulo = new frmArticulo();
            frmArticulo.MdiParent = this;
            frmArticulo.Show();
            
            
            /*frmArticulo formArticulo = new frmArticulo();
            formArticulo.TopLevel = false;
            formArticulo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formArticulo);
            formArticulo.Show();
            */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria formCategoria = new frmCategoria();
            formCategoria.TopLevel = false;
            formCategoria.Dock = DockStyle.Fill;
            panel1.Controls.Add(formCategoria);
            formCategoria.Show();
        }

        private void menuMarca_Click(object sender, EventArgs e)
        {
            frmMarca formMarca = new frmMarca();
            formMarca.TopLevel = false;
            formMarca.Dock = DockStyle.Fill;
            panel1.Controls.Add(formMarca);
            formMarca.Show();
        }
    }
}
