using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab2Zadanie
{
    public partial class FormMain : Form
    {
        //Lista pojazdów
        private List<Vehicle> vehiclesList = new List<Vehicle>();
        private int listIndex;

        private Vehicle vehicle;

        public FormMain()
        {
            BackColor = Color.Black;
            InitializeComponent();
            groupBoxNewVehicle.BackColor = Color.ForestGreen;
            groupBoxList.BackColor = Color.Crimson;
            labelMyName.ForeColor = Color.DarkBlue;
            listIndex = 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            if(radioButtonTram.Checked == true)
            {
                //Utworzenie obiektu Vehicle, który bedzie tramwajem
                vehicle = new Tram(Int32.Parse(textBoxNumberOfVehicle.Text),
                    Int32.Parse(textBoxYearOfProduction.Text), textBoxName.Text);
            }
            else
            {
                //Utworzenie obiektu Vehicle, który bedzie autobusem
                vehicle = new Bus(Int32.Parse(textBoxNumberOfVehicle.Text),
                    Int32.Parse(textBoxYearOfProduction.Text), textBoxName.Text);
            }
            //Dodajemy nowo utworzony pojazd do listy pojazdów
            vehiclesList.Add(vehicle);

            textBoxNumberOfVehicle.Text = "";
            textBoxYearOfProduction.Text = "";
            textBoxName.Text = "";

        }
        /// <summary>
        /// Przejście na poprzedni element listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //pobieranie danych z listy
            vehicle = vehiclesList[Math.Abs(listIndex-- % vehiclesList.Count())];

            labelActualNumberOfVehicleDescription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearOfProductionDescription.Text = vehicle.GetYearOfProduction().ToString();
            labelActualNameOfVehicleDescription.Text = vehicle.GetName().ToString();
            // Jeśli vehicle "wskazuje: na Tramwaj
            if(vehicle is Tram)
            {
                labelActualVehicleDescription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDescription.Text = "Autobus";
            }
        }
        /// <summary>
        /// Przejście na następny element listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //pobieranie danych z listy
            vehicle = vehiclesList[Math.Abs(listIndex++ % vehiclesList.Count())];

            labelActualNumberOfVehicleDescription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearOfProductionDescription.Text = vehicle.GetYearOfProduction().ToString();
            labelActualNameOfVehicleDescription.Text = vehicle.GetName().ToString();
            // Jeśli vehicle "wskazuje: na Tramwaj
            if (vehicle is Tram)
            {
                labelActualVehicleDescription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDescription.Text = "Autobus";
            }
        }
        /// <summary>
        /// Ruszenie pojazdem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StartVehicle());
        }
        /// <summary>
        /// Zatrzymanie pojazdu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StopVehicle());
        }

        private void buttonBell_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.Bell());
            }
            else
            {
                MessageBox.Show("Obiekt nie jest tramwajem!");
            }
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if (vehicle is Bus)
            {
                Bus bus = (Bus)vehicle;
                MessageBox.Show(bus.Refuel());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest autobusem!");
            }
        }

        private void buttonPantographDown_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram t = (Tram)vehicle;
                MessageBox.Show(t.PantographDown());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest tramwajem!");
            }
        }

        private void buttonPantographUp_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram t = (Tram)vehicle;
                MessageBox.Show(t.PantographUp());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest tramwajem!");
            }
        }
    }
}
