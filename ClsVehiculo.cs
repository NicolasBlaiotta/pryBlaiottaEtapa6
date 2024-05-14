using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBlaiottaEtapa6
{
    internal class ClsVehiculo
    {
        internal struct Celda
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Celda(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private List<Celda> celdasOcupadas = new List<Celda>();
        private int celdaSize = 100; // Tamaño de las celdas

        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }

        public void crearVehiculo(PictureBox pctVehiculo)
        {
            PictureBox vehiculo = new PictureBox();
            pctVehiculo.BackColor = Color.Transparent;
            Random rnd = new Random();

            // Obtener el número de celdas en el eje X y Y
            int numCeldasX = pctVehiculo.Width / celdaSize;
            int numCeldasY = pctVehiculo.Height / celdaSize;

            // Obtener una celda aleatoria que no esté ocupada
            Celda nuevaCelda;
            do
            {
                nuevaCelda = new Celda(rnd.Next(0, numCeldasX), rnd.Next(0, numCeldasY));
            } while (celdasOcupadas.Contains(nuevaCelda));

            celdasOcupadas.Add(nuevaCelda); // Agregar la celda ocupada a la lista

            // Calcular la posición del vehículo en función de la celda
            int posX = nuevaCelda.X * celdaSize;
            int posY = nuevaCelda.Y * celdaSize;

            switch (rnd.Next(1, 4))
            {
                case 1:
                    Nombre = "Peugeot";
                    Tipo = "Auto";
                    Imagen = Properties.Resources.auto;
                    break;
                case 2:
                    Nombre = "Bayliner";
                    Tipo = "Barco";
                    Imagen = Properties.Resources.barco;
                    break;
                case 3:
                    Nombre = "Iberia";
                    Tipo = "Avion";
                    Imagen = Properties.Resources.avion;
                    break;
            }
            vehiculo.Image = Imagen;
            vehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            vehiculo.Location = new Point(posX, posY);
            vehiculo.Size = new Size(celdaSize, celdaSize);


            pctVehiculo.Controls.Add(vehiculo);
            vehiculo.BringToFront();
        }

        public void crearVehiculoAleatorio(PictureBox pctVehiculo)
        {
            // Llamar al método crearVehiculo para generar un vehículo aleatorio
            crearVehiculo(pctVehiculo);
        }
    }
}