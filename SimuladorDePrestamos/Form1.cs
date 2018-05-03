using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDePrestamos
{
    public partial class Form1 : Form
    {
        double MontoPrestamo = 0;
        double TasaPrestamo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMontoPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculaPrestamo()
        {
            double CapitalAcumulado = 0;
            double CapitalRestante = 0;
            double CapitalCuota = double.Parse(txtMontoPrestamo.Text) / (int)nudCuotas.Value;
            double interesCuota = (double.Parse(txtMontoPrestamo.Text) * (double.Parse(txtTasaPrestamo.Text) / 100) / 12);
            double MontoCuota = CapitalCuota + interesCuota;

            for (int i = 1; i <= (int) nudCuotas.Value ; i++)
            {
                CapitalAcumulado += CapitalCuota;
                CapitalRestante = double.Parse(txtMontoPrestamo.Text) - CapitalAcumulado;
                lstNumCuota.Items.Add(i);

                lstCapitalCuota.Items.Add(CapitalCuota.ToString("###,###,##0.0"));
                lstInteresCuota.Items.Add(interesCuota.ToString("###,###,##0.0"));
                lstMontoCuota.Items.Add(MontoCuota.ToString("###,###,##0.0"));
                lstCapitalAcumulado.Items.Add(CapitalAcumulado.ToString("###,###,##0.0"));
                lstCapitalRestante.Items.Add(CapitalRestante.ToString("###,###,##0.0"));
           
            }
        }
        private bool ValoresValidos()
        {
            try
            {
                MontoPrestamo = double.Parse(txtMontoPrestamo.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("El monto del prestamo no es valido");
                return false;
                throw;
            }
            try
            {
                TasaPrestamo = double.Parse(txtTasaPrestamo.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("La tasa del prestamo no es valida");
                return false;

                throw;
            }
            return true;
        }
        private void LimpiarResultados()
        {
            lstNumCuota.Items.Clear();
            lstCapitalCuota.Items.Clear();
            lstInteresCuota.Items.Clear();
            lstMontoCuota.Items.Clear();
            lstCapitalAcumulado.Items.Clear();
            lstCapitalRestante.Items.Clear();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            if (ValoresValidos())
            {
                LimpiarResultados();
                CalculaPrestamo();
            }
        }
    }
}
