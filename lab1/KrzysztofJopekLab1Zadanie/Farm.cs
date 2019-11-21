using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab1Zadanie
{
    public partial class Farm : Form
    {
        /// <summary>
        /// zmienna przechowująca obecny czas 
        /// </summary>
        int number = 0;
        /// <summary>
        /// zmienna przechowująca liczbę owiec
        /// </summary>
        int sheepCounter = 24;
        /// <summary>
        /// zmienna przechowująca stan czy wilk zjadł owce
        /// </summary>
        bool wolfAte = false;
        /// <summary>
        /// zmienna przechowująca numer dnia
        /// </summary>
        int numberOfDay = 1;
        public Farm()
        {
            InitializeComponent();
        }

        private void Farm_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightYellow;
            sheep1.Visible = false;
            sheep2.Visible = false;
            sheep3.Visible = false;
            sheep4.Visible = false;
            sheep5.Visible = false;
            sheep6.Visible = false;
            sheep7.Visible = false;
            sheep8.Visible = false;
            wolf.Visible = false;
            dog.Visible = false;
            sheepCounterLabel.Text = sheepCounter.ToString();
            numberOfDayLabel.Text = numberOfDay.ToString();

        }
        /// <summary>
        /// metody wykonujące się przy każdym ticku timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = number.ToString();
            sheepCounterLabel.Text = sheepCounter.ToString();

            if (wolf.Visible == true && dog.Visible == false)
            {
                sheep1.Visible = false;
                sheep2.Visible = false;
                sheep3.Visible = false;
                sheep4.Visible = false;
                sheep5.Visible = false;
                sheep6.Visible = false;
                sheep7.Visible = false;
                sheep8.Visible = false;
                wolfAte = true;

            }
            // Jeśli ilość owiec = 0 -> KONIEC GRY
            if (sheepCounter == 0)
            {
                Timer.Stop();
                MessageBox.Show("You lost all sheeps.", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if( numberOfDay == 8)
            {
                Timer.Stop();
                MessageBox.Show("Congratulations!", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Pojawianie się kolejnych owiec co 5 sekund
            switch (number)
            {
                case 5:
                    {
                        sheep1.Visible = true;
                        break;
                    }
                case 10:
                    {
                        sheep2.Visible = true;
                        break;
                    }
                case 15:
                    {
                        sheep3.Visible = true;
                        break;
                    }
                case 20:
                    {
                        sheep4.Visible = true;
                        break;
                    }
                case 25:
                    {
                        sheep5.Visible = true;
                        break;
                    }
                case 30:
                    {
                        sheep6.Visible = true;
                        break;
                    }
                case 35:
                    {
                        sheep7.Visible = true;
                        break;
                    }
                case 40:
                    {
                        sheep8.Visible = true;
                        break;
                    }
                //nastanie nocy, pojawienie się wilka
                case 50:
                    {
                        BackColor = Color.DarkBlue;
                        dayNightLabel.Text = "Night";
                        wolf.Visible = true;
                        break;
                    }
                //nastanie dnia, wilka znika, dzień zaczyna się od nowa
                case 55:
                    {
                        numberOfDay++;
                        numberOfDayLabel.Text = numberOfDay.ToString();
                        wolf.Visible = false;
                        dayNightLabel.Text = "Day";
                        BackColor = Color.LightYellow;
                        number = 0;
                        if (wolfAte == true)
                        {
                            sheepCounter -= 8;
                        }
                        break;
                    }
            }
            number++;
        }
        /// <summary>
        /// Przycisk uruchamiający timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            Timer.Interval = 400;
            Timer.Start();

        }
        /// <summary>
        /// Przycisk "przywołujący" psa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dogButton_Click(object sender, EventArgs e)
        {
            dog.Visible = true;
        }
        /// <summary>
        /// Przycisk do przyśpieszania czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTime2x_Click(object sender, EventArgs e)
        {
            Timer.Interval = 100;
        }
        /// <summary>
        /// Przycisk "odwołujący" psa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dogInHouseButton_Click(object sender, EventArgs e)
        {
            dog.Visible = false;
        }
        /// <summary>
        /// Przycisk wyświetlający zasady gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZASADY GRY: \nCelem gry jest przetrwać 7 dni nie tracąc wszystkich owiec. Owce pojawiają się na pastwisu w dzień (max. 8), " +
                "opcjonalnie moze pilnować je pies pasterski.\nPo pewnym czasie nastaje noc, kiedy zjawia się wilk. Jeżeli pies nie pilnuje owiec, wilk " +
                "zjada wszystkie owce z pastwiska. \nNastępnie nastaje nowy dzień,  jeśli owce zostały zjedzone, uzupełniają je na pastwisku kolejne.\n" +
                "Jeśli stracisz wszystkie owce przed upływem 7 dni, przegrywasz. \nJeśli uda Ci się przetrwać, gratulacje! Wygrałeś :)", "ZASADY GRY",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }
    }
}
