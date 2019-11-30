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
    public partial class Plemiona : Form
    {
        private List<Builder> BuildersList = new List<Builder>();
        private List<Timberman> TimbermansList = new List<Timberman>();
        private List<Dealer> DealersList = new List<Dealer>();
        private List<Soldier> SoldiersList = new List<Soldier>();
        private List<Miner> MinersList = new List<Miner>(); 
        int timeCount;
        int level = 2;
        int builderCounter = 0;
        int timbermanCounter = 0;
        int dealerCounter = 0;
        int soldierCounter = 0;
        int minerCounter = 0;
        public Plemiona()
        {
            timeCount = 0;
            InitializeComponent();
            textBoxBuilder.Text = 0.ToString();
            textBoxDealer.Text = 0.ToString();
            textBoxSoldier.Text = 0.ToString();
            textBoxMiner.Text = 0.ToString();
            textBoxTimberman.Text = 0.ToString();
            textBoxGold.Text = 1000.ToString();
            textBoxWood.Text = 0.ToString();
            textBoxRock.Text = 0.ToString();
            textBoxProduction.Text = 0.ToString();
            MessageBox.Show("Witaj w grze Plemiona!\nTwoim celem jest w jak najszybszym czasie rozbudować maksymalnie swoją wioskę." +
                "Aby tego dokonać, musisz wybudować cztery budynki: Domy mieszkalne, Koszary, Mury oraz Cud Świata.\n" +
                "Pamiętaj jednak, że do każdej budowy potrzebujesz surowców, a te możesz zdobywać poprzez robotników.\n" +
                "Są ich 4 rodzaje: Górnik, Kupiec, Budowniczy oraz Drwal.\nKolejno produkują oni kamień, złoto, punkty produkcji oraz drewno, 5 jednostek co sekundę.\n" +
                "Żołnierze mają za zadadnie bronić Twojej wioski przed najazdem barbarzyńców, przy pierwszym ataku potrzeba conajmniej 5 jednostek aby obronić wioskę," +
                "przy kolejnym aż 10.\nPonadto czekają Cię dwie inne niespodziewane zdarzenia mające wpływ na stan twoich surowców.\n" +
                "Do wyboru masz dwa poziomy trudności: łatwy i trudny.\nW każdym momencie możesz zmienić poziom trudności.\n" +
                "Gdy wygrasz, twój wynik z czasem zostanie zapisany do pliku.\n Miłej zabawy!", "ZASADY GRY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
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
            textBoxTime.Text = timeCount.ToString();
            timeCount++;

            if (radioButtonLevelEasy.Checked == true)
            {
                level = 2;
            }
            else
            {
                level = 1;
            }

            foreach(Builder builder in BuildersList)
            {
                int number = Int32.Parse(textBoxProduction.Text);
                textBoxProduction.Text = (number + (level * 5)).ToString();
            }
            foreach (Timberman timberman in TimbermansList)
            {
                int number = Int32.Parse(textBoxWood.Text);
                textBoxWood.Text = (number + (level * 5)).ToString();
            }
            foreach (Dealer dealer in DealersList)
            {
                int number = Int32.Parse(textBoxGold.Text);
                textBoxGold.Text = (number + (level * 5)).ToString();
            }
            foreach (Miner miner in MinersList)
            {
                int number = Int32.Parse(textBoxRock.Text);
                textBoxRock.Text = (number + (level * 5)).ToString();
            }


            switch (timeCount)
            {
                case 60:
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
                        break;
                    }
                case 90:
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
                        break;

                    }
                case 120:
                    {
                        Timer.Stop();
                        Invasion invasion = new Invasion(200 / level);
                        MessageBox.Show(invasion.StartDisaster());
                        if ( Int32.Parse(textBoxSoldier.Text) < 5)
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
                            break;
                        }
                        else
                        {
                            MessageBox.Show(invasion.StopDisaster());
                        }
                        Timer.Start();
                        break;
                    }
                case 160:
                    {
                        Timer.Stop();
                        Invasion invasion = new Invasion(200 / level);
                        MessageBox.Show(invasion.StartDisaster());
                        if (Int32.Parse(textBoxSoldier.Text) < 10)
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
                            break;
                        }
                        else
                        {
                            MessageBox.Show(invasion.StopDisaster());
                        }
                        Timer.Start();
                        break;
                    }

            }



        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void buttonAddMiner_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 100/level)
            {
                minerCounter++;
                Miner miner = new Miner(100, "nr " + minerCounter.ToString());
                MessageBox.Show(miner.StartWork());
                MinersList.Add(miner);
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

        private void buttonAddDealer_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 400/level)
            {
                dealerCounter++;
                Dealer dealer = new Dealer(100, "nr " + dealerCounter.ToString());
                MessageBox.Show(dealer.StartWork());
                DealersList.Add(dealer);
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

        private void buttonAddSoldier_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 300/level)
            {
                soldierCounter++;
                Soldier soldier = new Soldier(100, "nr " + soldierCounter.ToString());
                MessageBox.Show(soldier.StartWork());
                SoldiersList.Add(soldier);
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

        private void buttonAddBuilder_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 200/level)
            {
                builderCounter++;
                Builder builder = new Builder(100, "nr " + builderCounter.ToString());
                MessageBox.Show(builder.StartWork());
                BuildersList.Add(builder);
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

        private void buttonAddTimberMan_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 100/level)
            {
                timbermanCounter++;
                Timberman timberman = new Timberman(100, "nr " + timbermanCounter.ToString());
                MessageBox.Show(timberman.StartWork());
                TimbermansList.Add(timberman);
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

        private void buttonBuyHouses_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(textBoxGold.Text) > 500 && Int32.Parse(textBoxWood.Text) > 600 && Int32.Parse(textBoxRock.Text) > 250 && Int32.Parse(textBoxProduction.Text) > 400)
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

        private void buttonBuyBarracks_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 600 && Int32.Parse(textBoxWood.Text) > 200 && Int32.Parse(textBoxRock.Text) > 700 && Int32.Parse(textBoxProduction.Text) > 500)
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

        private void buttonBuyWalls_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 500 && Int32.Parse(textBoxWood.Text) > 300 && Int32.Parse(textBoxRock.Text) > 800 && Int32.Parse(textBoxProduction.Text) > 600)
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

        private void buttonBuyTower_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxGold.Text) > 1000 && Int32.Parse(textBoxWood.Text) > 400 && Int32.Parse(textBoxRock.Text) > 900 && Int32.Parse(textBoxProduction.Text) > 1000)
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
    }
}
