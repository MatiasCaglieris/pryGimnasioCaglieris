using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGimnasioCaglieris
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EventoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            cboCuotas.SelectedIndex = 0;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            rdbEfectivo.Checked = true;
            rdbTarjeta.Checked = false;
            btnCalcular.Enabled = false;


        }



        private void addItems(ComboBox cbo, params string[] items)
        {
            cbo.Items.AddRange(items);

        }

        private void frminscripcion_Load(object sender, EventArgs e)
        {
            addItems(cboCuotas, "1", "3", "6");

            EventoInicial();

        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void gpbPago_Enter(object sender, EventArgs e)
        {

        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
           
            }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EventoInicial();
        }
    }
    }

