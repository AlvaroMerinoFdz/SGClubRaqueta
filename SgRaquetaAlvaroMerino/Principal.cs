using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SgRaquetaAlvaroMerino
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void abrirInformes()
        {
            frmInformes informes = new frmInformes();
            informes.MdiParent = this;
            informes.Dock = DockStyle.Fill;
            informes.Show();

        }
        private void abrirReservas()
        {
            Reserva informes = new Reserva();
            informes.MdiParent = this;
            informes.Dock = DockStyle.Fill;
            informes.Show();

        }
        private void abrirPistas()
        {
            AdminPista informes = new AdminPista();
            informes.MdiParent = this;
            informes.Dock = DockStyle.Fill;
            informes.Show();

        }
        private void abrirSocios()
        {
            AdminSocio informes = new AdminSocio();
            informes.MdiParent = this;
            informes.Dock = DockStyle.Fill;
            informes.Show();

        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comprobamos si tiene otra pestaña abierta
            if(this.MdiChildren.Length > 0)
            {
                //Comprobamos si esa pestaña es el formulario que queremos abrir
                if (this.MdiChildren[0].Name != "frmInformes")
                {
                    this.MdiChildren[0].Close();
                    //el formulario padre abre el hijo
                    abrirInformes();
                }
            }
            else abrirInformes();
            
        }

        private void pISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comprobamos si tiene otra pestaña abierta
            if (this.MdiChildren.Length > 0)
            {
                //Comprobamos si esa pestaña es el formulario que queremos abrir
                if (this.MdiChildren[0].Name != "AdminPista")
                {
                    this.MdiChildren[0].Close();
                    //el formulario padre abre el hijo
                    abrirPistas();
                }
            }
            else abrirPistas();
        }

        private void rESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comprobamos si tiene otra pestaña abierta
            if (this.MdiChildren.Length > 0)
            {
                //Comprobamos si esa pestaña es el formulario que queremos abrir
                if (this.MdiChildren[0].Name != "Reserva")
                {
                    this.MdiChildren[0].Close();
                    //el formulario padre abre el hijo
                    abrirReservas();
                }
            }
            else abrirReservas();  
        }

        private void sOCIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AdminSocio
            //Comprobamos si tiene otra pestaña abierta
            if (this.MdiChildren.Length > 0)
            {
                //Comprobamos si esa pestaña es el formulario que queremos abrir
                if (this.MdiChildren[0].Name != "AdminSocio")
                {
                    this.MdiChildren[0].Close();
                    //el formulario padre abre el hijo
                    abrirSocios();
                }
            }
            else abrirSocios();
        }
    }
}
