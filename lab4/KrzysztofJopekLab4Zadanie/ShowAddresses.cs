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
    public partial class ShowAddresses : Form
    {
        private readonly IFlightStoreGeneric<Address> _addresses;
        public ShowAddresses()
        {
            InitializeComponent();
            _addresses = new FlightStoreGeneric<Address>();
            LoadAddresses();
        }

        private void LoadAddresses()
        {
            dataGridViewAddressShow.DataSource = _addresses.GetAll();
        }
    }
}
