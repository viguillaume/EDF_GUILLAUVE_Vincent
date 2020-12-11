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

namespace ProjetEDFWPF
{
    /// <summary>
    /// Logique d'interaction pour Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        edfEntities gst;
        int idControleur;
        controleur leCtrl;
        public Admin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstCtrl.ItemsSource = gst.controleur.ToList();
        }

        private void lstCtrl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstCtrl.SelectedItem != null)
            {
                
                lstClient.ItemsSource = from c in gst.client.ToList()
                                         where c.idcontroleur == leCtrl.id
                                         select new ClientPerso(c.identifiant, c.nom, c.prenom, c.ancienReleve, c.dernierReleve);
            }
            
        }

       
    }
}
