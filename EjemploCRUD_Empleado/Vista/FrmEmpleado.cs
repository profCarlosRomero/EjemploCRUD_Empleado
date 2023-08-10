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
            Datos.Empleado emp = new Datos.Empleado(nss, nom, ape, fech, dir, sexo, salario, "", 1);

            //Modelo.Empleado emp = new Modelo.Empleado(nss, nom, ape, dir);

            /*--- Utilizando Dictionary ---*/
            //Modelo.Diccio_Empleados.Instancia.Alta_Emp(emp);
            //dgvEmpleado.DataSource = Modelo.Diccio_Empleados.Instancia.ListarDGV_DiccioEmp;
            /*--- Utilizando Dictionary - FIN ---*/

            /*--- Utilizando List ---*
            Modelo.Lista_Empleados.Instancia.Emp_Alta(emp);
            /*--- Cargar dgv con List ---*
            dgvEmpleado.DataSource = Modelo.Lista_Empleados.Instancia.ListarDGV_ListEmp;
            /*--- Cargar dgv con List - FIN ---*/

            emp.Alta();
            dgvEmpleado.DataSource = emp.CargarDGV();

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            /*--- Cargar dgv con List ---*
            dgvEmpleado.DataSource = Modelo.Lista_Empleados.Instancia.ListarDGV_ListEmp;
            /*--- Cargar dgv con List - FIN ---*/

            /*--- Cargar dgv con Dictionary ---*/
            //dgvEmpleado.DataSource = Modelo.Diccio_Empleados.Instancia.ListarDGV_DiccioEmp;
            /*--- Cargar dgv con Dictionary - FIN ---*/
            Datos.Empleado emp = new Datos.Empleado();
            dgvEmpleado.DataSource = emp.CargarDGV();
        }
    }
}
