using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubKazimierskiLab2
{
    public partial class FormMain : Form
    {
        private List<Vehicle> vehicleList = new List<Vehicle>();
        private Vehicle vehicle;
        private int listIndex;
        public FormMain()
        {
            
            InitializeComponent();
        }

        /// <summary>
        /// Implemented method of button "Dodaj nowy pojazd"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            if (TramwajRadioButton.Checked == true)
            {
                vehicle = new Tramwaj(Int32.Parse(NrVehicleTextBox.Text), Int32.Parse(YearOfProductionTextBox.Text), ModelOfVehicleTextBox.Text);
            }
            else
            {
                vehicle = new Bus(Int32.Parse(NrVehicleTextBox.Text), Int32.Parse(YearOfProductionTextBox.Text), ModelOfVehicleTextBox.Text);
            }

            //Add to vehicle list, new vehicle
            vehicleList.Add(vehicle);

            //clear textbox, after adding vehicle
            NrVehicleTextBox.Text = "";
            YearOfProductionTextBox.Text = "";
            ModelOfVehicleTextBox.Text = "";
        }

        /// <summary>
        /// Method to take previous element(Vehicle) from list of vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                vehicle = vehicleList[Math.Abs(listIndex-- % vehicleList.Count)];

                labelActualNumberDescription.Text = vehicle.GetVehicleNumber().ToString();
                labelActualYearOfProductionDescription.Text = vehicle.GetYearOfProduction().ToString();
                labelActuallModelDescription.Text = vehicle.GetName();

                //jesli vehicle "wskazuje" na Tramwaj;
                if (vehicle is Tramwaj)
                {
                    labelActualVechicleDescription.Text = "Tramwaj";
                }
                else
                {
                    labelActualVechicleDescription.Text = "Autobus";
                }
            }
            else
            {
                MessageBox.Show("Lista pojazdow jest pusta.");
            }
        }

        /// <summary>
        /// Method to take next element(vehicle) from list of vehicles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                vehicle = vehicleList[Math.Abs(listIndex++ % vehicleList.Count)];

                labelActualNumberDescription.Text = vehicle.GetVehicleNumber().ToString();
                labelActualYearOfProductionDescription.Text = vehicle.GetYearOfProduction().ToString();
                labelActuallModelDescription.Text = vehicle.GetName();

                //jesli vehicle "wskazuje" na Tramwaj;
                if (vehicle is Tramwaj)
                {
                    labelActualVechicleDescription.Text = "Tramwaj";
                }
                else
                {
                    labelActualVechicleDescription.Text = "Autobus";
                }
            }
            else
            {
                MessageBox.Show("Lista pojazdow jest pusta.");
            }
        }

        /// <summary>
        /// Method to run vehicle, by event of button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartVehicle_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                MessageBox.Show(vehicle.StartVehicle());//polimorfizm, metody zwroca inna wartosc zaleznie od klasy
            }
            else
            {
                MessageBox.Show("Vehicle is null!");
            }
        }

        /// <summary>
        /// Method to stop vehicle, by event of button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopVehicle_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                MessageBox.Show(vehicle.StopVehicle());
            }
            else
            {
                MessageBox.Show("Vehicle is null");
            }
        }

        /// <summary>
        /// Method to ring a bell in Vehicle, remember taht only tramwaj has this method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBell_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                if (vehicle is Tramwaj)
                {
                    Tramwaj tram = (Tramwaj)vehicle;//rzutowanie na konkretna klase i tworzenie konkretnego obiektu
                    MessageBox.Show(tram.Bell());
                }
                else
                {
                    MessageBox.Show("Obiekt nie jest tramwajem");
                }
            }
            else
            {
                MessageBox.Show("Vehicle is null");
            }
        }


        /// <summary>
        /// Method to refuel vehicle, remember that is method only for Bus Vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                //dodac if zabezpieczajace null
                if (vehicle is Bus)
                {
                    Bus bus = (Bus)vehicle;
                    MessageBox.Show(bus.Refuel());

                }
                else
                {
                    MessageBox.Show("Pojazd nie jest autobusem");
                }
            }
            else 
            {
                MessageBox.Show("Vehicle is null");
            }
        }

        /// <summary>
        /// Method to put panthogram down, REMEMBER "rzutowanie"!!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPanthographDown_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {


                if (vehicle is Tramwaj)
                {
                    Tramwaj tram = (Tramwaj)vehicle;
                    MessageBox.Show(tram.PantoghraphDown());
                }
                else
                {
                    MessageBox.Show("Pojazd nie jest Tramwajem");
                }
            }
            else 
            {
                MessageBox.Show("Vehicle is null");
            }
        }

        /// <summary>
        /// Method to put panthogram Up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPanthographUp_Click(object sender, EventArgs e)
        {
            if (vehicle != null)
            {
                if (vehicle is Tramwaj)
                {
                    Tramwaj tram = (Tramwaj)vehicle;
                    MessageBox.Show(tram.PantographUp());
                }
                else
                {
                    MessageBox.Show("Pojazd nie jest Tramwajem");
                }
            }
            else
            {
                MessageBox.Show("Vehicle is null");
            }
        }
    }
}
