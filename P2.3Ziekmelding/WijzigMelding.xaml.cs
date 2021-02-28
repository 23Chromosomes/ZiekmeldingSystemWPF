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
using System.Windows.Shapes;

namespace P2._3Ziekmelding
{
    /// <summary>
    /// Interaction logic for WijzigMelding.xaml
    /// </summary>
    public partial class WijzigMelding : Window
    {
        private meldingen deMelding;
        private dbZiekmeldingDataContext db;
        public WijzigMelding(meldingen deMelding, dbZiekmeldingDataContext db)
        {
            InitializeComponent();

            this.deMelding = deMelding;
            this.db = db;

            txtVoornaam.Text = deMelding.personen.voornaam;
            txtAchternaam.Text = deMelding.personen.achternaam;
            txtAfdeling.Text = deMelding.personen.afdeling;

            DateZiek.SelectedDate = deMelding.DatumZiek;
            DateBeter.SelectedDate = deMelding.DatumBeter;
        }

        private void Opslaan_Click(object sender, RoutedEventArgs e)
        {
            DateTime datumBeter = (DateTime)DateZiek.SelectedDate;
            DateTime datumZiek = (DateTime)DateBeter.SelectedDate;

            deMelding.DatumBeter = datumBeter;
            deMelding.DatumZiek = datumZiek;
            db.SubmitChanges();

            this.Close();
        }
    }
}
