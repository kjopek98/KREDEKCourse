using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab3Zadanie
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk logowania do systemu, jeśli login i hasło są prawidłowe, zostaje przyznany dostęp do systemu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn(textBoxUsername.Text, textBoxPassword.Text);
            FormHospital formHospital= new FormHospital();
            if (sign.SignInHospital() == true)
            {
                MessageBox.Show("Zalogowany.");
                formHospital.Show();
            }
            else
            {
                MessageBox.Show("Nie udało się.");
            }
        }
    }
}
