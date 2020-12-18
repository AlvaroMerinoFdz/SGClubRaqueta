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
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblConsulta.Text="Mostrar nombre y apellidos de los socios, que tengan mayor número de reservas hechas.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblConsulta.Text = "Mostrar nombre y apellidos de los socio que nunca han hecho ninguna reserva de pista.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblConsulta.Text = "Mostra el nombre de la pista y del socio, de la reserva más antigua.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblConsulta.Text = "Mostrar los nombres de los socios que tienen menos nº de reservas que la media hechas por todos los socios";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblConsulta.Text = "Mostrar el DNI,nombre y apellidos de los socios que se ha gastado más dinero en reservas de pistas.";
        }
    }
}
