using EntityFrameworkLab4.Models;
using EntityFrameworkLab4.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLab4
{
    public partial class FormMain : Form
    {
        private readonly ISkiJumpingGeneric<Jumper> _jumpers;
        private readonly ISkiJumpingGeneric<Country> _countries;

        public FormMain()
        {
            InitializeComponent();
            _jumpers = new SkiJumpingGeneric<Jumper>();
            _countries = new SkiJumpingGeneric<Country>();
            LoadJumpers();
            LoadCountries();
        }

        /// <summary>
        /// Edycja danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperUpdate_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());
            var updateJumper = _jumpers.GetById(selectedJumperIndex);

            textBoxUpdateJumperId.Text = updateJumper.Id.ToString();
            textBoxUpdateJumperFirstName.Text = updateJumper.FirstName;
            textBoxUpdateJumperLastName.Text = updateJumper.LastName;
            dateTimePickerUpdateJumper.Text = updateJumper.Birthdate.ToShortDateString();
            textBoxUpdateCountryId.Text = updateJumper.CountryId.ToString();
        }

        /// <summary>
        /// Wczytanie skoczków z bazy danych
        /// </summary>
        private void LoadJumpers()
        {
            dataGridViewJumpers.DataSource = _jumpers.GetAll();
        }

        /// <summary>
        /// Wczytanie krajów z bazy danych
        /// </summary>
        private void LoadCountries()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
        }

        /// <summary>
        /// Usunięcie skoczka z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperDelete_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());
            var deleteJumper = _jumpers.GetById(selectedJumperIndex);

            _jumpers.DeleteById(deleteJumper.Id);
            _jumpers.Save();

            LoadJumpers();
        }

        /// <summary>
        /// Wyświetlenie informacji o skoczku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperShow_Click(object sender, EventArgs e)
        {
            var selectedJumperIndex = Int32.Parse(dataGridViewJumpers.SelectedRows[0].Cells[0].Value.ToString());

            var showJumper = _jumpers.GetById(selectedJumperIndex);
            var country = _countries.GetById(showJumper.CountryId);

            MessageBox.Show("Kraj skoczka to: " + country.Name);
        }

        /// <summary>
        /// Usunięcie kraju z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryDelete_Click(object sender, EventArgs e)
        {
            var selectedCountryIndex = Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString());
            var deleteCountry = _countries.GetById(selectedCountryIndex);

            _countries.DeleteById(deleteCountry.Id);
            _countries.Save();

            LoadCountries();
        }

        /// <summary>
        /// Edycja danych kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryUpdate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Wyświetlenie informacji o kraju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryShow_Click(object sender, EventArgs e)
        {
            var selectedCountryIndex = Int32.Parse(dataGridViewCountries.SelectedRows[0].Cells[0].Value.ToString());

            var deleteCountry = _countries.GetById(selectedCountryIndex);

            MessageBox.Show("Id kraju to: " + deleteCountry.Id.ToString());
        }

        /// <summary>
        /// Dodanie nowego skoczka do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperAdd_Click(object sender, EventArgs e)
        {
            var jumperFirstName = textBoxJumperFirstName.Text;
            var jumperLastName = textBoxJumperLastName.Text;
            var jumperBirthdate = dateTimePickerJumper.Text;
            var countryId = textBoxJumperCountryId.Text;

            Jumper newJumper = new Jumper
            {
                FirstName = jumperFirstName,
                LastName = jumperLastName,
                Birthdate = Convert.ToDateTime(jumperBirthdate),
                CountryId = Int32.Parse(countryId)
            };

            _jumpers.Create(newJumper);
            _jumpers.Save();

            LoadJumpers();
        }

        /// <summary>
        /// Dodanie nowego kraju do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryAdd_Click(object sender, EventArgs e)
        {
            var countryName = textBoxCountryName.Text;
            var countryRecord = textBoxCountryRecord.Text;

            Country newCountry = new Country
            {
                Name = countryName,
                CountryRecord = Int32.Parse(countryRecord)
            };

            _countries.Create(newCountry);
            _countries.Save();

            LoadCountries();
        }

        /// <summary>
        /// Zapis zmian danych skoczka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJumperSaveChanges_Click(object sender, EventArgs e)
        {
            int jumperUpdatedId = Int32.Parse(textBoxUpdateJumperId.Text);
            var jumperUpdatedFirstName = textBoxUpdateJumperFirstName.Text;
            var jumperUpdatedLastName = textBoxUpdateJumperLastName.Text;
            var jumperUpdatedBirthdate = dateTimePickerUpdateJumper.Text;
            var jumperUpdatedCountryId = textBoxUpdateCountryId.Text;

            Jumper editJumper = _jumpers.GetById(jumperUpdatedId);
            editJumper.FirstName = jumperUpdatedFirstName;
            editJumper.LastName = jumperUpdatedLastName;
            editJumper.Birthdate = Convert.ToDateTime(jumperUpdatedBirthdate);
            editJumper.CountryId = Int32.Parse(jumperUpdatedCountryId);

            _jumpers.Update(editJumper);
            _jumpers.Save();

            LoadJumpers();
        }
    }
}
