using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoCine
{
    public partial class frmPrincipal : Form
    {
        conexion con;
        public frmPrincipal()
        {
            con = new conexion();
            InitializeComponent();
        }
        void cargarConexion(conexion con)
        {
        }
        private void btnConsulta1_Click(object sender, EventArgs e)
        {

            
                new frmClientes(con).ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool estado = con.verificarConexion();
            btnClientes.Enabled = estado;
            btnReservas.Enabled = estado;
            btnPeliculas.Enabled = estado;
            consultasToolStripMenuItem.Enabled = estado;
            aBMToolStripMenuItem.Enabled = estado;
            btnUsuarioDB.Enabled = estado;
          
            if (estado)
            {
                lblEstadoConexion.Text = "Conectado";
                lblEstadoConexion.ForeColor = Color.Black;
            }
            else
            {
                lblEstadoConexion.Text = "Desconectado";
                lblEstadoConexion.ForeColor = Color.Black;
                MessageBox.Show(con.pLog);
            }
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            new frmPeliculas(con).ShowDialog();
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            new frmReservas(con).ShowDialog();
        }

        private void aBMPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new abmPeliculas(con).ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void datosDelGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGrupo().ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmReservas(con).ShowDialog();
        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPeliculas(con).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
