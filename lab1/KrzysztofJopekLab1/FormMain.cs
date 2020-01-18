using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab1
{
    public partial class FormMain : Form
    {
        int number = 0;
        int number2 = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Przycisk zmieniający kolor programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)  
        {
            //zmiana koloru tła
            BackColor = Color.Aqua;
            
        }
        /// <summary>
        /// Przycisk zmieniający kolor przycisków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeButtonsColor_Click(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Blue;
            changeButtonsColor.BackColor = Color.Red;
            changeButtonsFont.BackColor = Color.Green;
            buttonIndex.BackColor = Color.Azure;
        }
        /// <summary>
        /// Przycisk zmieniający czcionkę napisów na przyciskach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeButtonsFont_Click(object sender, EventArgs e)
        {
            buttonColor.Font = new Font("Times New Roman", 24, FontStyle.Bold);
            //changeButtonsColor.Font = ;
        }
        /// <summary>
        /// Przycisk zmieniający imię i nazwisko na numer indeksu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIndex_Click(object sender, EventArgs e)
        {
            labelName.Text = "241406";
        }
        /// <summary>
        /// Funkcja uruchamiająca obliczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            number = Int32.Parse(textBoxCount.Text);
            number = number + 7;
            if ( number > 40)
            {
                MessageBox.Show("Za duża liczba!");

            }
            else { 
            MessageBox.Show(number.ToString());
            }
            
        }
        /// <summary>
        /// Licznik inkrementujący
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount2_Click(object sender, EventArgs e)
        {
            textBoxCount2.Text = number2.ToString();
            number2++;
        }
        /// <summary>
        /// Funkcja sumująca dwie liczby z textBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCounterStart_Click(object sender, EventArgs e)
        {
            int sum = Int32.Parse(textBoxCount.Text) + Int32.Parse(textBoxCount2.Text);
            MessageBox.Show("Suma wynosi: " + sum.ToString());
        }
        /// <summary>
        /// Funkcja wykonująca sie co tick Timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {

            textBoxCount.Text = number.ToString();
            
            switch (number % 5) {
                case 0:
                    BackColor = Color.Salmon;
                    break;

                case 1:
                    BackColor = Color.Red;
                    break;

                case 2:
                    BackColor = Color.Blue;
                    break;
                case 3:
                    BackColor = Color.Yellow;
                    break;
                case 4:
                    BackColor = Color.Magenta;
                    break;
            }
            number++;
        }
        /// <summary>
        /// Funckcja uruchamiająca licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTimerStart_Click(object sender, EventArgs e)
        {
            //ustawiamy interwał timera
            timerCount.Interval = 1000;
            //uruchamiamy Timer
            timerCount.Start();
        }
        /// <summary>
        /// Funkcja tworząca nowe okno z wpisanym tekstem "text"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            
            FormAbout formAbout = new FormAbout();
            formAbout.formName = "Krzysztof Jopek";
            formAbout.Show(); //ShowDialog()
        }
    }
}
