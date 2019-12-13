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
    public partial class ShowLuggage : Form
    {
        private readonly IFlightStoreGeneric<Luggage> _luggage;
        public ShowLuggage()
        {
            InitializeComponent();
            _luggage = new FlightStoreGeneric<Luggage>();
            LoadLuggage();
        }

        private void LoadLuggage()
        {
            dataGridViewLuggageShow.DataSource = _luggage.GetAll();
        }
    }
}
