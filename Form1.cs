using System;
using System.Windows.Forms;

namespace Frenlly__Nomina_Quincenal
{
    public partial class Form1 : Form
    {
        // Constantes
        const int HORAS_BASE = 88;
        const double FACTOR_EXTRA = 1.35;
        const double INCENTIVO_TRANSPORTE = 1500;
        const double TASA_AFP = 0.0287;
        const double TASA_SFS = 0.0304;

        // Acumuladores 
        int totalEmpleados = 0;
        double totalBruto = 0;
        double totalDeducciones = 0;
        double totalNeto = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Valores por defecto
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbFijo.Checked = true;
            cmbCargo.SelectedIndex = -1;
            lblEmpleados.Text = "0";
            lblBruto.Text = "RD$ 0.00";
            lblDeducciones.Text = "RD$ 0.00";
            lblNeto.Text = "RD$ 0.00";
        }

        //Evento para registrar al empleado y calcular su nómina
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEmpleado.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del empleado.");
                return;
            }
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cargo.");
                return;
            }

            int horas = 0;
            if (!int.TryParse(txtHoras.Text, out horas) || horas < 1 || horas > 120)
            {
                MessageBox.Show("Las horas deben ser un número entero entre 1 y 120.");
                return;
            }

            // Tarifa según el cargo
            double tarifa = 0;
            if (cmbCargo.Text == "Auxiliar") { tarifa = 180; }
            else if (cmbCargo.Text == "Técnico") { tarifa = 250; }
            else if (cmbCargo.Text == "Supervisor") { tarifa = 350; }
            else if (cmbCargo.Text == "Gerente") { tarifa = 500; }

            // Cálculo de horas (regulares y extras)
            double salarioRegular = 0;
            double pagoExtra = 0;

            if (horas <= HORAS_BASE)
            {
                salarioRegular = horas * tarifa;
            }
            else
            {
                salarioRegular = HORAS_BASE * tarifa;
                int horasExtras = horas - HORAS_BASE;
                pagoExtra = horasExtras * tarifa * FACTOR_EXTRA;
            }

            //Incentivo
            double incentivo = 0;
            if (chkTransporte.Checked == true) { incentivo = INCENTIVO_TRANSPORTE; }

            //Bruto
            double bruto = salarioRegular + pagoExtra + incentivo;

            //Deducciones 
            double deducciones = 0;
            if (rdbFijo.Checked == true)
            {
            //Se descuenta sobre el salario regular más extra 
                double baseDeduccion = salarioRegular + pagoExtra;
                deducciones = (baseDeduccion * TASA_AFP) + (baseDeduccion * TASA_SFS);
            }

            //Neto
            double neto = bruto - deducciones;

            //Agregar a la lista
            string linea = txtEmpleado.Text + " - " + cmbCargo.Text + " - RD$ " + neto.ToString("N2");
            lstNomina.Items.Add(linea);

            //Actualizar acumuladores
            totalEmpleados = totalEmpleados + 1;
            totalBruto = totalBruto + bruto;
            totalDeducciones = totalDeducciones + deducciones;
            totalNeto = totalNeto + neto;

            //Limpiar para el siguiente
            txtEmpleado.Clear();
            txtHoras.Clear();
            cmbCargo.SelectedIndex = -1;
            chkTransporte.Checked = false;
            txtEmpleado.Focus();
        }

        //Evento para mostrar el resumen 
        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (totalEmpleados == 0)
            {
                MessageBox.Show("No hay empleados registrados para mostrar el resumen.");
                return;
            }

            lblEmpleados.Text = totalEmpleados.ToString();
            lblBruto.Text = "RD$ " + totalBruto.ToString("N2");
            lblDeducciones.Text = "RD$ " + totalDeducciones.ToString("N2");
            lblNeto.Text = "RD$ " + totalNeto.ToString("N2");
        }

        //Evento para limpiar todo
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        //Limpiar acumuladores
            totalEmpleados = 0;
            totalBruto = 0;
            totalDeducciones = 0;
            totalNeto = 0;

        //Limpiar controles
            lstNomina.Items.Clear();
            txtEmpleado.Clear();
            txtHoras.Clear();
            cmbCargo.SelectedIndex = -1;
            chkTransporte.Checked = false;
            rdbFijo.Checked = true;
            rdbTemporal.Checked = false;

        //Limpiar labels de resumen
            lblEmpleados.Text = "0";
            lblBruto.Text = "RD$ 0.00";
            lblDeducciones.Text = "RD$ 0.00";
            lblNeto.Text = "RD$ 0.00";

            txtEmpleado.Focus();
        }

        //Evento para cerrar la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
