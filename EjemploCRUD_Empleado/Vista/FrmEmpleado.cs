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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();

            //pagina = "Alta";
        }

        private void btnAltaGuardar_Click(object sender, EventArgs e)
        {
            //INSERT INTO empleado(nss, nombrep, apellido, fechan, direccion, sexo, salario, nd)
            string nss = txtAltaNSS.Text;
            string nom = txtAltaNombre.Text;
            string ape = txtAltaApe.Text;
            string dir = txtAltaDir.Text;
            DateTime fech = DateTime.Parse(textBox4.Text);
            char sexo = ' ';
            if (radioButton1.Checked)
                sexo = 'M';
            if (radioButton2.Checked)
                sexo = 'F';
            if (radioButton3.Checked)
                sexo = 'O';
            double salario = double.Parse(textBox7.Text);

            string gerente = lbGerente.SelectedValue.ToString().Substring(0, 9); // Obtengo el nss del gerente seleccionado

            int depto = int.Parse(cbDepartamento.SelectedValue.ToString());

            //Datos.Empleado emp = new Datos.Empleado(nss, nom, ape, fech, dir, sexo, salario, "", 1);
            Datos.EmpleadoEjemplo emp = 
                new Datos.EmpleadoEjemplo(nss, nom, ape, fech, dir, sexo, salario, gerente, depto);

            /* --- SIN modificar --- *
            emp.Alta();
            //dgvEmpleado.DataSource = emp.ListarDGV();
            dgvEmpleado.DataSource = emp.CargarDGV();
            /* --- SIN modificar ---FIN--- */

            /* --- con modificar --- */
            if (tabPage2.Text.Equals("Alta"))
            {
                emp.Alta();
            }
            else
            {
                emp.Modificar();
            }
            dgvEmpleado.DataSource = emp.CargarDGV();
            /* --- con modificar ---FIN--- */

            tabPage2.Text = "Alta";

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            //Datos.Empleado emp = new Datos.Empleado();
            Datos.EmpleadoEjemplo emp = new Datos.EmpleadoEjemplo();
            try
            {
                dgvEmpleado.DataSource = emp.CargarDGV();

                

                //Datos.Departamento dpto = new Datos.Departamento();
                //cbDepartamento.DataSource = dpto.ListarCBox();
                cbDepartamento.DataSource = (new Datos.Departamento()).ListarCBox();
                MessageBox.Show("asdasd " + cbDepartamento.Items.Count.ToString());
                cbDepartamento.ValueMember = "numerod";
                cbDepartamento.DisplayMember = "nombred";

                //lbGerente.DataSource = emp.ListarDGV();
                //lbGerente.DisplayMember = "apellido";
                //lbGerente.ValueMember = "nss";

                lbGerente.DataSource = CargarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }


            /* --- Para clase 31/08 --- *
            // SelectionMode: FullRowSelect
                /*DropDownStyle: DropDownList*
            Datos.Departamento dpto = new Datos.Departamento();

            cbDepartamento.ValueMember = "numerod";
            cbDepartamento.DisplayMember = "nombred";
            cbDepartamento.DataSource = dpto.ListarCBox();
            //---
            /* 1)
            lbGerente.ValueMember = "nss";
            lbGerente.DisplayMember = "nss";
            // lbGerente.DisplayMember = "apellido";
            lbGerente.DataSource = emp.ListarDGV();
            */
            // 2)
            //lbGerente.DataSource = LlenarListBox();

            /* --- Para clase 31/08 --- FIN --- */
        }

        private int fila;

        private void btnModEmp_Click(object sender, EventArgs e)
        {
            tabPage2.Text = "Modificar";
            tabControl1.SelectedIndex = 1;

            string nss = dgvEmpleado.Rows[fila].Cells[0].Value.ToString();
            txtAltaNSS.Text = nss;

            string nom = dgvEmpleado.Rows[fila].Cells[1].Value.ToString();
            txtAltaNombre.Text = nom;

            string ape = dgvEmpleado.Rows[fila].Cells[2].Value.ToString();
            txtAltaApe.Text = ape;

            DateTime fech = DateTime.Parse(dgvEmpleado.Rows[fila].Cells[3].Value.ToString());
            textBox4.Text = fech.ToString("dd/MM/yyyy");

            string dir = dgvEmpleado.Rows[fila].Cells[4].Value.ToString();
            txtAltaDir.Text = dir;

            char sexo = dgvEmpleado.Rows[fila].Cells[5].Value.ToString()[0];
            if (sexo == 'M')
                radioButton1.Checked = true;
            if (sexo == 'F')
                radioButton2.Checked = true;
            if (sexo == 'O')
                radioButton3.Checked = true;
            
            double salario = double.Parse(dgvEmpleado.Rows[fila].Cells[6].Value.ToString());
            textBox7.Text = salario.ToString();

            
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                fila = e.RowIndex;
            }
        }

        private void btnBajaEmp_Click(object sender, EventArgs e)
        {
            string nss = dgvEmpleado.Rows[fila].Cells[0].Value.ToString();

            Datos.Empleado emp = new Datos.Empleado();

            emp.Baja(nss);

            dgvEmpleado.DataSource = emp.ListarDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbDepartamento.SelectedValue.ToString());
            MessageBox.Show(lbGerente.SelectedValue.ToString());

            dgvEmpleado.DataSource = (new Datos.EmpleadoEjemplo()).
                ListarDGV_con_CB_3(int.Parse(cbDepartamento.SelectedValue.ToString()));

            for (int i = 0; i < dgvEmpleado.Columns.Count - 1; i++)
                dgvEmpleado.Columns[i].ReadOnly = true;
            //dgvEmpleado.Columns[8].ReadOnly = false;
        }

        private List<string> CargarListBox()
        {
            List<string> l = new List<string>();
            System.Data.DataTable dt = (new Datos.Empleado()).ListarDGV();

            foreach (DataRow item in dt.Rows)
            {
                string fila = $"{item[0].ToString()} {item[1].ToString()} {item[2].ToString()}";
                l.Add(fila);
            }
            

            return l;
        }






        /*

        private List<string> LlenarListBox()
        {
            Datos.Empleado emp = new Datos.Empleado();
            //System.Data.DataTable dt = emp.ListarDGV();
            List<string> l = new List<string>();

            foreach (DataRow item in (emp.ListarDGV()).Rows)
            {
                string fila = $"{item[0].ToString()} {item[1].ToString()} {item[2].ToString()}";
                l.Add(fila);
            }

            return l;
        }*/
    }
}
