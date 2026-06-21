using System.ComponentModel.Design;

namespace ejP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NumericService servicio = new NumericService();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormDatos datos = new FormDatos();
            if (datos.ShowDialog() == DialogResult.OK)
            {
                string patente = datos.tbPatente.Text;
                double km = Convert.ToDouble(datos.tbKilometros.Text);
                servicio.RegistrarVehi(patente, km);
                lsbPatentes.Items.Add(patente);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            FormDatos datos = new FormDatos();
            if (datos.ShowDialog() == DialogResult.OK)
            {
                string patente = datos.tbPatente.Text;
                int idx = servicio.BuscarPorPatente(patente);
                if (idx != -1)
                {
                    double km = Convert.ToDouble(datos.tbKilometros.Text);
                    servicio.CargarViaje(km, idx);
                    lbCantViajes.Text = Convert.ToString(servicio.CantidadViajes());
                }
                else MessageBox.Show("No existe");
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            servicio.Ordenar();
            FormResumen resumen=new FormResumen();
            for (int i = 0; i < servicio.CantidadVehiculos(); i++)
            {
                string linea = $"Patente: {servicio.VerPatente(i)}, KM: {servicio.VerKilometraje(i)}";
                resumen.lsbPatentes.Items.Add(linea);
            }
            double PromKM = Convert.ToDouble(servicio.PromKM());
            int cviajes = servicio.CantidadViajes();
            resumen.lsbPatentes.Items.Add($"Cantidad de viajes: {cviajes}, promedio de km: {PromKM}");
            resumen.ShowDialog();
        }
    }
}
