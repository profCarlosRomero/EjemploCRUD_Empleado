using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCRUD_Empleado
{
    public partial class Form1 : Form
    {
        private Vista.FrmEmpleado frmEmp;
        private Vista.FrmDepartamento frmDpto;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmEmp == null || frmEmp.IsDisposed)
                frmEmp = new Vista.FrmEmpleado();
            frmEmp.Show();
            frmEmp.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmDpto == null || frmDpto.IsDisposed)
                frmDpto = new Vista.FrmDepartamento();
            frmDpto.Show();
            frmDpto.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            Datos.Usuario u = new Datos.Usuario(user, pass);

            if(u.Login())
                MessageBox.Show("Login successful");
            else
                MessageBox.Show("NO");
        }
    }
}
