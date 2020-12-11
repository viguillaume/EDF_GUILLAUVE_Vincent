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


namespace ProjetEDFWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            controleur leCtrl = gst.controleur.ToList().Find(Ctrl => Ctrl.login == txtLogin.Text && Ctrl.mdp == txtMDP.Text);
            if (txtLogin.Text == "")
            {
                txtErreur.Text = "Veuillez saisir votre login";
            }
            
            else if(txtMDP.Text == "")
            {
                txtErreur.Text = "Veuillez saisir le mot de passe";
            }
            else if(leCtrl == null)
            {
                txtErreur.Text = "Login invalide ou mot de passe invalide";
            }
            else if(leCtrl.statut == "admin")
            {
                Admin frm = new Admin();
                frm.Show();
            }
            else
            {
                Ctrl frm = new Ctrl();
                frm.Show();
            }

        }
    }
}
