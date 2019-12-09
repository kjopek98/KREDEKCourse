using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab2ZadanieDomowe
{
    public partial class Welcome : Form
    {
        public string name;
        public Welcome()
        {
            InitializeComponent();
            //Ekran powitalny, przedstawiający zasady gry
            MessageBox.Show("Witaj w grze Cywilizacja!\nTwoim celem jest w jak najszybszym czasie rozbudować maksymalnie swoją wioskę." +
                "Aby tego dokonać, musisz wybudować cztery budynki: Domy mieszkalne, Koszary, Mury oraz Cud Świata.\n" +
                "Pamiętaj jednak, że do każdej budowy potrzebujesz surowców, a te możesz zdobywać poprzez robotników.\n" +
                "Są ich 4 rodzaje: Górnik, Kupiec, Budowniczy oraz Drwal.\nKolejno produkują oni kamień, złoto, punkty produkcji oraz drewno, 5 jednostek co sekundę.\n" +
                "Żołnierze mają za zadadnie bronić Twojej wioski przed najazdem barbarzyńców, przy pierwszym ataku potrzeba conajmniej 5 jednostek aby obronić wioskę,\n" +
                "przy kolejnym aż 10.\nPonadto czekają Cię dwa inne niespodziewane zdarzenia mające wpływ na stan twoich surowców.\n" +
                "Do wyboru masz dwa poziomy trudności: łatwy i trudny.\nW każdym momencie możesz zmienić poziom trudności.\n" +
                "Na start zaczynasz z 1000 sztuk złota.\n" +
                "Gdy wygrasz, twój wynik z czasem zostanie zapisany do pliku.\nMiłej zabawy!", "ZASADY GRY", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            name = textBoxEnterName.Text;
            Civilization civilization = new Civilization();
            civilization.Show();
        }
    }
}
