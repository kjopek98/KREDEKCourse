using KrzysztofJopekLab4Zadanie.Models;
using KrzysztofJopekLab4Zadanie.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab4Zadanie
{
    public partial class FlightStore : Form
    {
        private readonly IFlightStoreGeneric<Passenger> _passengers;
        private readonly IFlightStoreGeneric<Flight> _flights;
        private readonly IFlightStoreGeneric<Address> _adresses;
        /// <summary>
        /// Konstruktor okna i załadowanie DataGridView danymi z bazy danych
        /// </summary>
        public FlightStore()
        {
            InitializeComponent();
            _passengers = new FlightStoreGeneric<Passenger>();
            _flights = new FlightStoreGeneric<Flight>();
            _adresses = new FlightStoreGeneric<Address>();
            LoadPassengers();
            LoadFlights();
        }

        /// <summary>
        /// Wczytanie pasażerów z bazy danych
        /// </summary>
        private void LoadPassengers()
        {
            dataGridViewPassengers.DataSource = _passengers.GetAll();
        }

        /// <summary>
        /// Wczytanie lotów z bazy danych
        /// </summary>
        private void LoadFlights()
        {
            dataGridViewFlights.DataSource = _flights.GetAll();
        }
        /// <summary>
        /// Otworzenie okna z obsługą biletów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTicketShow_Click(object sender, EventArgs e)
        {
            BuyTicket buyTicket = new BuyTicket();
            buyTicket.Show();
        }
        /// <summary>
        /// Wyświetlenie dostępnych adresów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddressShow_Click(object sender, EventArgs e)
        {
            ShowAddresses showAddresses = new ShowAddresses();
            showAddresses.Show();
        }
        /// <summary>
        /// Wyświetlenie dostępnych pakietów bagażu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLuggageShow_Click(object sender, EventArgs e)
        {
            ShowLuggage showLuggage = new ShowLuggage();
            showLuggage.Show();
        }
        /// <summary>
        /// Dodanie nowego pasażera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassengerAdd_Click(object sender, EventArgs e)
        {
            var passengerName = textBoxPassengerName.Text;
            var passengerSurname = textBoxPassengerSurname.Text;
            var passengerEmail = textBoxPassengerEmail.Text;
            var passengerPhone = textBoxPassengerPhone.Text;
            var addressId = textBoxPassengerAddressId.Text;

            Passenger newPassenger = new Passenger
            {
                Name = passengerName,
                Surname = passengerSurname,
                Email = passengerEmail,
                Phone = passengerPhone,
                AddressId = Int32.Parse(addressId)
            };

            _passengers.Create(newPassenger);
            _passengers.Save();

            LoadPassengers();
        }
        /// <summary>
        /// Usuwanie wybranego pasażera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassengerDelete_Click(object sender, EventArgs e)
        {
            var selectedPassengerIndex = Int32.Parse(dataGridViewPassengers.SelectedRows[0].Cells[0].Value.ToString());
            var deletePassenger = _passengers.GetById(selectedPassengerIndex);

            _passengers.DeleteById(deletePassenger.Id);
            _passengers.Save();

            LoadPassengers();
        }
        /// <summary>
        /// Wypełnienie danymi do edycji wybranego pasażera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassengerUpdate_Click(object sender, EventArgs e)
        {
            var selectedPassengerIndex = Int32.Parse(dataGridViewPassengers.SelectedRows[0].Cells[0].Value.ToString());
            var updatePassenger = _passengers.GetById(selectedPassengerIndex);

            textBoxUpdatePassengerId.Text = updatePassenger.Id.ToString();
            textBoxUpdatePassengerName.Text = updatePassenger.Name;
            textBoxUpdatePassengerSurname.Text = updatePassenger.Surname;
            textBoxUpdatePassengerEmail.Text = updatePassenger.Email;
            textBoxUpdatePassengerPhone.Text = updatePassenger.Phone;
            textBoxUpdatePassengerAddressId.Text = updatePassenger.AddressId.ToString();
        }
    
        /// <summary>
        /// Wyświetlenie adresu przypisanego do wybranego pasażera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassengerAddressShow_Click(object sender, EventArgs e)
        {
            var selectedPassengerIndex = Int32.Parse(dataGridViewPassengers.SelectedRows[0].Cells[0].Value.ToString());

            var showPassenger = _passengers.GetById(selectedPassengerIndex);
            var address = _adresses.GetById(showPassenger.AddressId);

            MessageBox.Show("Adres pasażera: Kraj - " + address.Country + ", Województwo - " + 
                address.Province+ ", Powiat - " + address.District + ", Miasto - " + address.City +
                ", Ulica - "+ address.Street+ ", Numer domu - "+ address.House_number+ ", Numer lokalu - "+ address.Local_number);
        }
        /// <summary>
        /// Edycja danych wybranego pasażera i zapisanie zmian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassengerSaveChanges_Click(object sender, EventArgs e)
        {
            int passengerUpdatedId = Int32.Parse(textBoxUpdatePassengerId.Text);
            var passengerUpdatedName = textBoxUpdatePassengerName.Text;
            var passengerUpdatedSurname = textBoxUpdatePassengerSurname.Text;
            var passengerUpdatedEmail = textBoxUpdatePassengerEmail.Text;
            var passengerUpdatedPhone = textBoxUpdatePassengerPhone.Text;
            var passengerUpdatedAddressId = textBoxUpdatePassengerAddressId.Text;

            Passenger editPassenger = _passengers.GetById(passengerUpdatedId);
            editPassenger.Name = passengerUpdatedName;
            editPassenger.Surname = passengerUpdatedSurname;
            editPassenger.Email = passengerUpdatedEmail;
            editPassenger.Phone = passengerUpdatedPhone;
            editPassenger.AddressId = Int32.Parse(passengerUpdatedAddressId);

            _passengers.Update(editPassenger);
            _passengers.Save();

            LoadPassengers();
        }
        /// <summary>
        /// Dodanie nowego lotu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlightAdd_Click(object sender, EventArgs e)
        {
            var flightDeparture = textBoxFlightDeparture.Text;
            var flightArrival = textBoxFlightArrival.Text;
            var flightFlightDate= dateTimePickerFlightDateFlight.Text;
            

            Flight newFlight = new Flight
            {
                Departure = flightDeparture,
                Arrival = flightArrival,
                FlightDate = Convert.ToDateTime(flightFlightDate)
            };

            _flights.Create(newFlight);
            _flights.Save();

            LoadFlights();
        }
        /// <summary>
        /// Usunięcie wybranego lotu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlightDelete_Click(object sender, EventArgs e)
        {
            var selectedFlightIndex = Int32.Parse(dataGridViewFlights.SelectedRows[0].Cells[0].Value.ToString());
            var deleteFlight = _flights.GetById(selectedFlightIndex);

            _flights.DeleteById(deleteFlight.Id);
            _flights.Save();

            LoadFlights();
        }
        /// <summary>
        /// Wypełnienie danymi do edycji wybranego lotu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateFlight_Click(object sender, EventArgs e)
        {

            var selectedFlightIndex = Int32.Parse(dataGridViewFlights.SelectedRows[0].Cells[0].Value.ToString());
            var updateFlight = _flights.GetById(selectedFlightIndex);

            textBoxUpdateFlightId.Text = updateFlight.Id.ToString();
            textBoxUpdateFlightDeparture.Text = updateFlight.Departure;
            textBoxUpdateFlightArrival.Text = updateFlight.Arrival;
            dateTimePickerFlightDateFlight.Text = updateFlight.FlightDate.ToString();
            
        }
        /// <summary>
        /// Edycja danych wybranego lotu i zapisanie zmian 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlightSaveChanges_Click(object sender, EventArgs e)
        {
            int flightUpdatedId = Int32.Parse(textBoxUpdateFlightId.Text);
            var flightUpdatedDeparture = textBoxUpdateFlightDeparture.Text;
            var flightUpdatedArrival = textBoxUpdateFlightArrival.Text;
            var flightUpdatedFlightDate = dateTimePickerUpdateFlightDate.Text;

            Flight editFlight = _flights.GetById(flightUpdatedId);
            editFlight.Departure = flightUpdatedDeparture;
            editFlight.Arrival = flightUpdatedArrival;
            editFlight.FlightDate = Convert.ToDateTime(flightUpdatedFlightDate);
            
            _flights.Update(editFlight);
            _flights.Save();

            LoadFlights();
        }
    }
}
