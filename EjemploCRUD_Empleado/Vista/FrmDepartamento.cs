using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCRUD_Empleado.Vista
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDepartemento.DataSource = (new Datos.Departamento()).ListarDGV();

                Datos.EmpleadoEjemplo emp = new Datos.EmpleadoEjemplo();
                cbGteDpto.DataSource = emp.CargarDGV();
                cbGteDpto.ValueMember = "nss";
                cbGteDpto.DisplayMember = "nss";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int numd = int.Parse(txtNumDpto.Text);
            string nomd = txtNomDpto.Text;
            string gte = cbGteDpto.SelectedValue.ToString();
            DateTime fech = dtpFechInicGte.Value;

            Datos.Departamento dpto = new Datos.Departamento(numd, nomd, gte, fech);
            dpto.Alta();

            dgvDepartemento.DataSource = (new Datos.Departamento()).ListarDGV();
        }

        private int fila;

        private void dgvDepartemento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                fila = e.RowIndex;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int numd = int.Parse(dgvDepartemento.Rows[fila].Cells[0].Value.ToString());

            Datos.Departamento d = new Datos.Departamento();
            d.Baja(numd);

            dgvDepartemento.DataSource = d.ListarDGV();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            int numd = int.Parse(dgvDepartemento.Rows[fila].Cells[0].Value.ToString());

            // numerod as NumDpto, nombred as NombreDpto, nssgte as Gerente, fechainicgte as InicioGte

            string nombred = dgvDepartemento.Rows[fila].Cells[1].Value.ToString();
            string gte = dgvDepartemento.Rows[fila].Cells[2].Value.ToString();
            DateTime inic_gte = DateTime.Parse(dgvDepartemento.Rows[fila].Cells[3].Value.ToString());

            txtNumDpto.Text = numd.ToString();
            txtNomDpto.Text = nombred.ToString();
            dtpFechInicGte.Value = inic_gte;

            tpFormulario.Text = "Modificar";
            tabControl1.SelectedIndex = 1;

        }
    }
}
