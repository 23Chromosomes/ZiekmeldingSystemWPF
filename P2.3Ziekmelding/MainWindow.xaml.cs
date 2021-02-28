using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P2._3Ziekmelding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        dbZiekmeldingDataContext db = new dbZiekmeldingDataContext();
        personen dePersoon = new personen();
        meldingen deMelding = new meldingen();
        public MainWindow()
        {
            InitializeComponent();
            dgPersonen.ItemsSource = db.personens.ToList();
            dgMeldingen.ItemsSource = db.meldingens.ToList();
        }

        private void btnWijzigPersonen_Click(object sender, RoutedEventArgs e)
        {
            personen dePersoon = (personen)dgPersonen.SelectedItem;

            WijzigPersoon wMelding = new WijzigPersoon(dePersoon, db);
            wMelding.Show();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string strVoornaam = txtVoornaam.Text;
            string strAchternaam = txtAchternaam.Text;
            string strAfdeling = txtAfdeling.Text;

            //Object persoon toevoegen
            personen dePersoon = new personen();
            dePersoon.voornaam = strVoornaam;
            dePersoon.achternaam = strAchternaam;
            dePersoon.afdeling = strAfdeling;

            db.personens.InsertOnSubmit(dePersoon);

            db.SubmitChanges();

            dgPersonen.ItemsSource = db.personens.ToList();
        }

        private void btnZiekMelden_Click(object sender, RoutedEventArgs e)
        {
            dePersoon = (personen)dgPersonen.SelectedItem;
            tbVoornaam.Text = dePersoon.voornaam;
            tbAchternaam.Text = dePersoon.achternaam;
        }

        private void btnVerwijderPersoon_Click(object sender, RoutedEventArgs e)
        {
            var item = (personen)dgPersonen.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Ben je het zeker dat je: " + item.voornaam + " " + item.achternaam + " wilt verwijderen?", "Waarschuwing!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.personens.DeleteOnSubmit(item);

                db.SubmitChanges();
                dgPersonen.ItemsSource = db.personens.ToList();
            }

        }


        private void btnZiek_Click(object sender, RoutedEventArgs e)
        {
            DateTime dtZiek = (DateTime)dpDatumZiek.SelectedDate;
            meldingen ziekMelding = new meldingen();
            ziekMelding.DatumZiek = dtZiek;
            ziekMelding.personen = dePersoon;
            db.meldingens.InsertOnSubmit(ziekMelding);
            db.SubmitChanges();

            dgMeldingen.ItemsSource = db.meldingens.ToList();
        }


        private void btnWijzigMelding_Click(object sender, RoutedEventArgs e)
        {
            meldingen deMelding = (meldingen)dgMeldingen.SelectedItem;

            WijzigMelding wMelding = new WijzigMelding(deMelding, db);
            wMelding.Show();
        }


        private void btnVerwijderMelding_Click(object sender, RoutedEventArgs e)
        {
            var item = (meldingen)dgMeldingen.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Ben je het zeker dat je: " + item.personen.voornaam + " " + item.personen.achternaam + " zijn melding wilt verwijderen?", "Waarschuwing!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.meldingens.DeleteOnSubmit(item);

                db.SubmitChanges();
                dgMeldingen.ItemsSource = db.meldingens.ToList();
            }

        }        

    }
}
