namespace pryBlaiottaEtapa6
{
    public partial class Form1 : Form
    {
        private ClsVehiculo vehiculoManager = new ClsVehiculo();
        private System.Windows.Forms.Timer timerMover = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            timerMover.Interval = 200;
            timerMover.Tick += TimerMover_Tick;
        }

        private void TimerMover_Tick(object? sender, EventArgs e)
        {
            mover();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad de vehículos a generar desde el TextBox
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                // Limpiar PictureBox antes de cargar nuevos vehículos
                pctVehiculos.Controls.Clear();

                // Generar la cantidad de vehículos especificada
                for (int i = 0; i < cantidad; i++)
                {
                    vehiculoManager.crearVehiculoAleatorio(pctVehiculos);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido en el campo de cantidad de vehículos.");
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            timerMover.Start();
            btnMover.Enabled = false;
        }
        private void mover()
        {
            // Mover los vehículos dentro del PictureBox
            foreach (Control control in pctVehiculos.Controls)
            {
                PictureBox vehiculo = control as PictureBox;
                if (vehiculo != null)
                {
                    // Mover el vehículo
                    Random rnd = new Random();
                    int offsetX = rnd.Next(-10, 11); // Movimiento horizontal aleatorio
                    int offsetY = rnd.Next(-10, 11); // Movimiento vertical aleatorio
                    vehiculo.Location = new Point(vehiculo.Location.X + offsetX, vehiculo.Location.Y + offsetY);
                    // Verificar si el vehículo se superpone a otros y eliminarlos
                    foreach (Control otroControl in pctVehiculos.Controls)
                    {
                        if (otroControl != vehiculo && vehiculo.Bounds.IntersectsWith(otroControl.Bounds))
                        {
                            pctVehiculos.Controls.Remove(otroControl);
                            otroControl.Dispose(); // Liberar recursos de la imagen eliminada
                        }
                    }
                }
            }
        }
    }
}