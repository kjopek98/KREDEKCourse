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
    public partial class BuyTicket : Form
    {
        private readonly IFlightStoreGeneric<Ticket> _tickets;
        public BuyTicket()
        {
            InitializeComponent();
            _tickets = new FlightStoreGeneric<Ticket>();
            LoadTickets();
        }
        private void LoadTickets()
        {
            dataGridViewTickets.DataSource = _tickets.GetAll();
        }

        private void buttonTicketAdd_Click(object sender, EventArgs e)
        {
            var ticketPlaceNumber = textBoxTicketPlaceNumber.Text;
            var ticketLuggageId = textBoxTicketLuggageId.Text;
            var ticketPassengerId = textBoxTicketPassengerId.Text;
            var ticketFlightId = textBoxTicketFlightId.Text;

            Ticket newTicket = new Ticket
            {
                Place_number = ticketPlaceNumber,
                LuggageId = Int32.Parse(ticketLuggageId),
                PassengerId = Int32.Parse(ticketPassengerId),
                FlightId = Int32.Parse(ticketFlightId) 
            };

            _tickets.Create(newTicket);
            _tickets.Save();

            LoadTickets();
        }

        private void buttonTicketDelete_Click(object sender, EventArgs e)
        {
            var selectedTicketIndex = Int32.Parse(dataGridViewTickets.SelectedRows[0].Cells[0].Value.ToString());
            var deleteTicket = _tickets.GetById(selectedTicketIndex);

            _tickets.DeleteById(deleteTicket.Id);
            _tickets.Save();

            LoadTickets();
        }

        private void buttonTicketUpdate_Click(object sender, EventArgs e)
        {
            var selectedTicketIndex = Int32.Parse(dataGridViewTickets.SelectedRows[0].Cells[0].Value.ToString());
            var updateTicket = _tickets.GetById(selectedTicketIndex);

            textBoxUpdateTicketId.Text = updateTicket.Id.ToString();
            textBoxUpdateTicketPlaceNumber.Text = updateTicket.Place_number;
            textBoxUpdateTicketLuggageId.Text = updateTicket.LuggageId.ToString();
            textBoxUpdateTicketPassengerId.Text = updateTicket.Passenger.ToString();
            textBoxUpdateTicketFlightId.Text = updateTicket.FlightId.ToString();
        }

        private void buttonTicketSaveChanges_Click(object sender, EventArgs e)
        {
            var ticketUpdatedId = Int32.Parse(textBoxUpdateTicketId.Text);
            var ticketPlaceNumber = textBoxUpdateTicketPlaceNumber.Text;
            var ticketLuggageId = textBoxUpdateTicketLuggageId.Text;
            var ticketPassengerId = textBoxUpdateTicketPassengerId.Text;
            var ticketFlightId = textBoxUpdateTicketFlightId.Text;

            Ticket newTicket = _tickets.GetById(ticketUpdatedId);
           
            newTicket.Place_number = ticketPlaceNumber;
            newTicket.LuggageId = Int32.Parse(ticketLuggageId);
            newTicket.PassengerId = Int32.Parse(ticketPassengerId);
            newTicket.FlightId = Int32.Parse(ticketFlightId);
           

            _tickets.Create(newTicket);
            _tickets.Save();

            LoadTickets();
        }
    }
}
