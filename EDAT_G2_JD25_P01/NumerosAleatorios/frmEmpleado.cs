using System;
using System.Windows.Forms;

namespace NumerosAleatorios
{
    public partial class frmEmpleado : Form
    {
        private Random rnd = new Random();

        public frmEmpleado()
        {
            InitializeComponent();
           
            cmbGrupo.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            string[] nombres = { "Carlos", "Ana", "Luis", "María", "Pedro", "Lucía", "José", "Fernanda" };

            
            int numero = rnd.Next(1, 1000);
            string nombre = nombres[rnd.Next(nombres.Length)];
            DateTime fechaNacimiento = DateTime.Now.AddYears(-rnd.Next(18, 65)).AddDays(rnd.Next(365));
            string sexo = rnd.Next(2) == 0 ? "Masculino" : "Femenino";
            char grupo = (char)('A' + rnd.Next(0, 5));
            double sueldo = Math.Round(rnd.NextDouble() * 50000 + 10000, 2);
            bool seguroMedico = rnd.Next(2) == 1;

         
            Empleado emp = new Empleado(numero, nombre, fechaNacimiento, sexo, grupo, sueldo, seguroMedico);

           
            txtNumero.Text = emp.Numero.ToString();
            txtNombre.Text = emp.Nombre;
            dtpFechaNacimiento.Value = emp.FechaNacimiento;

            if (emp.Sexo == "Masculino")
                rbMasculino.Checked = true;
            else
                rbFemenino.Checked = true;

            cmbGrupo.SelectedItem = emp.Grupo.ToString();
            txtSueldo.Text = emp.Sueldo.ToString("F2");
            chkSeguroMedico.Checked = emp.SeguroMedico;

            
            MessageBox.Show(emp.ToString(), "Empleado Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}