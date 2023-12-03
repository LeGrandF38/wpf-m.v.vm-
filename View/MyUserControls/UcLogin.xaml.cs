using Demo2.Business;
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

namespace Demo2.View.MyUserControls
{
    /// <summary>
    /// Logique d'interaction pour UcLogin.xaml
    /// </summary>
    public partial class UcLogin : UserControl
    {
        public UcLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = App.Current.MainWindow as MainWindow;
            mainWindow.grContent.Children.Clear();

            UcEtudiant ucEtudiant = new UcEtudiant();

            ETudiantBusiness eTudiantBusiness = new ETudiantBusiness();

            ucEtudiant.DataContext = eTudiantBusiness;


            mainWindow.grContent.Children.Add(ucEtudiant);
            



        }
    }
}
