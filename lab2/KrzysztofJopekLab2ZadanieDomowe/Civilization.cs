using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    public partial class Civilization : Form
    {
        //Listy przechowujące robotników
        private List<Builder> buildersList = new List<Builder>();
        private List<Timberman> timbermansList = new List<Timberman>();
        private List<Dealer> dealersList = new List<Dealer>();
        private List<Soldier> soldiersList = new List<Soldier>();
        private List<Miner> minersList = new List<Miner>(); 
        //licznik czasu
        int timeCount;
        //poziom trudności, domyślnie "łatwy"
        int level = 2;
        public Civilization()
        {
            timeCount = 0;
            InitializeComponent();
            //Zerowanie statystyk dla nowej gry.
            textBoxBuilder.Text = 0.ToString();
            textBoxDealer.Text = 0.ToString();
            textBoxSoldier.Text = 0.ToString();
            textBoxMiner.Text = 0.ToString();
            textBoxTimberman.Text = 0.ToString();
            textBoxGold.Text = 1000.ToString();
            textBoxWood.Text = 0.ToString();
            textBoxRock.Text = 0.ToString();
            textBoxProduction.Text = 0.ToString();
            //Ekran powitalny, przedstawiający zasady gry
            MessageBox.Show("Witaj w grze Cywilizacja!\nTwoim celem jest w jak najszybszym czasie rozbudować maksymalnie swoją wioskę." +
                "Aby tego dokonać, musisz wybudować cztery budynki: Domy mieszkalne, Koszary, Mury oraz Cud Świata.\n" +
                "Pamiętaj jednak, że do każdej budowy potrzebujesz surowców, a te możesz zdobywać poprzez robotników.\n" +
                "Są ich 4 rodzaje: Górnik, Kupiec, Budowniczy oraz Drwal.\nKolejno produkują oni kamień, złoto, punkty produkcji oraz drewno, 5 jednostek co sekundę.\n" +
                "Żołnierze mają za zadadnie bronić Twojej wioski przed najazdem barbarzyńców, przy pierwszym ataku potrzeba conajmniej 5 jednostek aby obronić wioskę,\n" +
                "przy kolejnym aż 10.\nPonadto czekają Cię dwa inne niespodziewane zdarzenia mające wpływ na stan twoich surowców.\n" +
                "Do wyboru masz dwa poziomy trudności: łatwy i trudny.\nW każdym momencie możesz zmienić poziom trudności.\n" +
                "Na start zaczynasz z 1000 sztuk złota.\n"+
                "Gdy wygrasz, twój wynik z czasem zostanie zapisany do pliku.\nMiłej zabawy!", "ZASADY GRY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Metoda wywołująca "skutki" powodzi.
        /// </summary>
        public void FloodInCity()
        {
            Timer.Stop();
            Flood flood = new Flood(200 / level);
            MessageBox.Show(flood.StartDisaster());
            int number0 = Int32.Parse(textBoxWood.Text);
            if (number0 < 200)
            {
                textBoxWood.Text = 0.ToString();
            }
            else
            {
                textBoxWood.Text = (number0 - flood.GetDamagePoints()).ToString();
            }
            int number1 = Int32.Parse(textBoxGold.Text);
            if (number1 < 200)
            {
                textBoxGold.Text = 0.ToString();
            }
            else
            {
                textBoxGold.Text = (number1 - flood.GetDamagePoints()).ToString();
            }
            int number2 = Int32.Parse(textBoxRock.Text);
            if (number2 < 200)
            {
                textBoxRock.Text = 0.ToString();
            }
            else
            {
                textBoxRock.Text = (number2 - flood.GetDamagePoints()).ToString();
            }
            Timer.Start();
        }
        /// <summary>
        /// Metoda wywołująca "skutki" pożaru
        /// </summary>
        public void ForestFire()
        {
            Timer.Stop();
            Fire fire = new Fire(300 / level);
            MessageBox.Show(fire.StartDisaster());
            int number = Int32.Parse(textBoxWood.Text);
            if (number < 300)
            {
                textBoxWood.Text = 0.ToString();
            }
            else
            {
                textBoxWood.Text = (number - fire.GetDamagePoints()).ToString();
            }
            Timer.Start();
        }
        /// <summary>
        /// Metoda wywołująca "skutki" najazdu barbarzyńców
        /// </summary>
        public void BarbarianInvasion(int number)
        {
            Timer.Stop();
            Invasion invasion = new Invasion(200 / level);
            MessageBox.Show(invasion.StartDisaster());
            if (Int32.Parse(textBoxSoldier.Text) < number)
            {
                int number0 = Int32.Parse(textBoxWood.Text);
                if (number0 < 200)
                {
                    textBoxWood.Text = 0.ToString();
                }
                else
                {
                    textBoxWood.Text = (number0 - invasion.GetDamagePoints()).ToString();
                }
                int number1 = Int32.Parse(textBoxGold.Text);
                if (number1 < 200)
                {
                    textBoxGold.Text = 0.ToString();
                }
                else
                {
                    textBoxGold.Text = (number1 - invasion.GetDamagePoints()).ToString();
                }
                int number2 = Int32.Parse(textBoxRock.Text);
                if (number2 < 200)
                {
                    textBoxRock.Text = 0.ToString();
                }
                else
                {
                    textBoxRock.Text = (number2 - invasion.GetDamagePoints()).ToString();
                }
            }
            else
            {
                MessageBox.Show(invasion.StopDisaster());
            }
            Timer.Start();
        }
        /// <summary>
        /// Metoda wywołująca sie za każdym tickiem Timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Jeśli ukończono grę, zapis do pliku .txt
            if( pictureBoxBuildings.Visible == true && pictureBoxBarracks.Visible == true && pictureBoxWalls.Visible == true && pictureBoxTower.Visible == true)
            {
                Timer.Stop();
                using (StreamWriter writer = new StreamWriter("Scores.txt"))
                {
                    if (level == 2)
                    {
                        writer.WriteLine("Twój wynik - poziom łatwy: " + timeCount.ToString());
                    }
                    if (level == 1)
                    {
                        writer.WriteLine("Twój wynik - poziom trudny: " + timeCount.ToString());
                    }
                }
                MessageBox.Show("Gratulacje! Rozbudowałeś do końca swoją osadę! Twój wynik: " + timeCount.ToString() + " został zapisany do pliku  Scores.txt . Dziękuję za granie!");
            }
            // zmiana licznika zegara
            textBoxTime.Text = timeCount.ToString();
            timeCount++;
            //sprawdzanie poziomu trudności
            if (radioButtonLevelEasy.Checked == true)
            {
                level = 2;
            }
            else
            {
                level = 1;
            }
            //Dodawanie surowców w zależności od ilości danych robotników.
            foreach(Builder builder in buildersList)
            {
                int number = Int32.Parse(textBoxProduction.Text);
                textBoxProduction.Text = (number + (level * 5)).ToString();
            }
            foreach (Timberman timberman in timbermansList)
            {
                int number = Int32.Parse(textBoxWood.Text);
                textBoxWood.Text = (number + (level * 5)).ToString();
            }
            foreach (Dealer dealer in dealersList)
            {
                int number = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number + (level * 5)).ToString();
            }
            foreach (Miner miner in minersList)
            {
                int number = Int32.Parse(textBoxRock.Text);
                textBoxRock.Text = (number + (level * 5)).ToString();
            }
            //Obługa wydarzeń "losowych", tzw. katastrof.
            switch (timeCount)
            {
                case 30:
                    {
                        ForestFire();
                        break;
                    }
                case 60:
                    {
                        FloodInCity();
                        break;

                    }
                case 120:
                    {
                        BarbarianInvasion(5);
                        break;
                    }
                case 150:
                    {
                        ForestFire();
                        break;
                    }
                case 180:
                    {
                        FloodInCity();
                        break;
                    }
                case 240:
                    {
                        BarbarianInvasion(10);
                        break;
                    }
            }
        }
        /// <summary>
        /// Przycisk rozpoczynający grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1000;
            Timer.Start();
        }
        /// <summary>
        /// Przycisk dodający nowego górnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMiner_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 100/level)
            {
                Miner miner = new Miner(100, "nr " + (minersList.Count + 1).ToString());
                MessageBox.Show(miner.StartWork());
                minersList.Add(miner);
                int number = Int32.Parse(textBoxMiner.Text);
                textBoxMiner.Text = (number + 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 - (miner.GetCost()/level)).ToString();
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk dodający nowego kupca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDealer_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 400/level)
            {
                Dealer dealer = new Dealer(100, "nr " + (dealersList.Count + 1).ToString());
                MessageBox.Show(dealer.StartWork());
                dealersList.Add(dealer);
                int number = Int32.Parse(textBoxDealer.Text);
                textBoxDealer.Text = (number + 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 - (dealer.GetCost()/level)).ToString();
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk dodający nowego żołnierza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSoldier_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 300/level)
            {
                Soldier soldier = new Soldier(100, "nr " + (soldiersList.Count + 1).ToString() );
                MessageBox.Show(soldier.StartWork());
                soldiersList.Add(soldier);
                int number = Int32.Parse(textBoxSoldier.Text);
                textBoxSoldier.Text = (number + 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 - (soldier.GetCost()/level)).ToString();
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk dodający nowego budowniczego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBuilder_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 200/level)
            {
                Builder builder = new Builder(100, "nr " + (buildersList.Count + 1).ToString());
                MessageBox.Show(builder.StartWork());
                buildersList.Add(builder);
                int number = Int32.Parse(textBoxBuilder.Text);
                textBoxBuilder.Text = (number + 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 - (builder.GetCost()/ level)).ToString();
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk dodający nowego drwala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTimberMan_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 100/level)
            {
                Timberman timberman = new Timberman(100, "nr " + (timbermansList.Count + 1).ToString() );
                MessageBox.Show(timberman.StartWork());
                timbermansList.Add(timberman);
                int number = Int32.Parse(textBoxTimberman.Text);
                textBoxTimberman.Text = (number + 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 - (timberman.GetCost()/level)).ToString();
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk kupujący Domy Budowlane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyHouses_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(textBoxGold.Text) >= 500 && Int32.Parse(textBoxWood.Text) >= 600 && Int32.Parse(textBoxRock.Text) >= 250 && Int32.Parse(textBoxProduction.Text) >= 400)
            {
                int number0 = Int32.Parse(textBoxGold.Text);
                int number1 = Int32.Parse(textBoxWood.Text);
                int number2 = Int32.Parse(textBoxRock.Text);
                int number3 = Int32.Parse(textBoxProduction.Text);

                textBoxGold.Text = (number0 - 500).ToString();
                textBoxWood.Text = (number1 - 600).ToString();
                textBoxRock.Text = (number2 - 250).ToString();
                textBoxProduction.Text = (number3 - 400).ToString();
                pictureBoxBuildings.Visible = true;
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk kupujący Koszary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyBarracks_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 600 && Int32.Parse(textBoxWood.Text) >= 200 && Int32.Parse(textBoxRock.Text) >= 700 && Int32.Parse(textBoxProduction.Text) >= 500)
            {
                int number0 = Int32.Parse(textBoxGold.Text);
                int number1 = Int32.Parse(textBoxWood.Text);
                int number2 = Int32.Parse(textBoxRock.Text);
                int number3 = Int32.Parse(textBoxProduction.Text);

                textBoxGold.Text = (number0 - 600).ToString();
                textBoxWood.Text = (number1 - 200).ToString();
                textBoxRock.Text = (number2 - 700).ToString();
                textBoxProduction.Text = (number3 - 500).ToString();
                pictureBoxBarracks.Visible = true;
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk kupujący Mury.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWalls_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 500 && Int32.Parse(textBoxWood.Text) >= 300 && Int32.Parse(textBoxRock.Text) >= 800 && Int32.Parse(textBoxProduction.Text) >= 600)
            {
                int number0 = Int32.Parse(textBoxGold.Text);
                int number1 = Int32.Parse(textBoxWood.Text);
                int number2 = Int32.Parse(textBoxRock.Text);
                int number3 = Int32.Parse(textBoxProduction.Text);

                textBoxGold.Text = (number0 - 500).ToString();
                textBoxWood.Text = (number1 - 300).ToString();
                textBoxRock.Text = (number2 - 800).ToString();
                textBoxProduction.Text = (number3 - 600).ToString();
                pictureBoxWalls.Visible = true;
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk kupujący Cud Świata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyTower_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) >= 1000 && Int32.Parse(textBoxWood.Text) >= 400 && Int32.Parse(textBoxRock.Text) >= 900 && Int32.Parse(textBoxProduction.Text) >= 1000)
            {
                int number0 = Int32.Parse(textBoxGold.Text);
                int number1 = Int32.Parse(textBoxWood.Text);
                int number2 = Int32.Parse(textBoxRock.Text);
                int number3 = Int32.Parse(textBoxProduction.Text);

                textBoxGold.Text = (number0 - 1000).ToString();
                textBoxWood.Text = (number1 - 400).ToString();
                textBoxRock.Text = (number2 - 900).ToString();
                textBoxProduction.Text = (number3 - 1000).ToString();
                pictureBoxTower.Visible = true;
            }
            else
            {
                MessageBox.Show("Nie masz potrzebnych zasobów.");
            }
        }
        /// <summary>
        /// Przycisk sprzedający górnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellMiner_Click(object sender, EventArgs e)
        {
            if (minersList.Count > 0)
            {
                MessageBox.Show(minersList[(minersList.Count - 1)].StopWork());
                minersList.RemoveAt(minersList.Count - 1);
                int number = Int32.Parse(textBoxMiner.Text);
                textBoxMiner.Text = (number - 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 + 25).ToString();
            }
        }
        /// <summary>
        /// Przycisk sprzedający kupca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellDealer_Click(object sender, EventArgs e)
        {
            if (dealersList.Count > 0)
            {
                MessageBox.Show(dealersList[(dealersList.Count - 1)].StopWork());
                dealersList.RemoveAt(dealersList.Count - 1);
                int number = Int32.Parse(textBoxDealer.Text);
                textBoxDealer.Text = (number - 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 + 25).ToString();
            }
        }
        /// <summary>
        /// Przycisk sprzedający żołnierza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellSoldier_Click(object sender, EventArgs e)
        {
            if (soldiersList.Count > 0)
            {
                MessageBox.Show(soldiersList[(soldiersList.Count - 1)].StopWork());
                soldiersList.RemoveAt(soldiersList.Count - 1);
                int number = Int32.Parse(textBoxSoldier.Text);
                textBoxSoldier.Text = (number - 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 + 25).ToString();
            }
        }
        /// <summary>
        /// Przycisk sprzedający budowniczego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellBuilder_Click(object sender, EventArgs e)
        {
            if (buildersList.Count > 0)
            {
                MessageBox.Show(buildersList[(buildersList.Count - 1)].StopWork());
                buildersList.RemoveAt(buildersList.Count - 1);
                int number = Int32.Parse(textBoxBuilder.Text);
                textBoxBuilder.Text = (number - 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 + 25).ToString();
            }
        }
        /// <summary>
        /// Przycisk sprzedający drwala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellTimberman_Click(object sender, EventArgs e)
        {
            if (timbermansList.Count > 0)
            {
                MessageBox.Show(timbermansList[(timbermansList.Count - 1)].StopWork());
                timbermansList.RemoveAt(timbermansList.Count - 1);
                int number = Int32.Parse(textBoxTimberman.Text);
                textBoxTimberman.Text = (number - 1).ToString();
                int number0 = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number0 + 25).ToString();
            }
        }
    }
}
