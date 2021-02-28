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
    /// Interaction logic for WijzigPersoon.xaml
    /// </summary>
    public partial class WijzigPersoon : Window
    {
        private personen dePersoon;
        private dbZiekmeldingDataContext db;
        public WijzigPersoon(personen dePersoon, dbZiekmeldingDataContext db)
        {
            InitializeComponent();

            this.dePersoon = dePersoon;
            this.db = db;

            txtVoornaam.Text = dePersoon.voornaam;
            txtAchternaam.Text = dePersoon.achternaam;
            txtAfdeling.Text = dePersoon.afdeling;
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            string strVoornaam = txtVoornaam.Text;
            string strAchternaam = txtAchternaam.Text;
            string strAfdeling = txtAfdeling.Text;

            dePersoon.voornaam = strVoornaam;
            dePersoon.achternaam = strAchternaam;
            dePersoon.afdeling = strAfdeling;
            db.SubmitChanges();

            this.Close();
        }
    }
}
