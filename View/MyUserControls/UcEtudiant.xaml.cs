using Demo2.Model;
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
    /// Logique d'interaction pour UcEtudiant.xaml
    /// </summary>
    public partial class UcEtudiant : UserControl
    {
        public UcEtudiant()
        {
            InitializeComponent();
        }

        private void btnAjouterEtudiant_Click(object sender, RoutedEventArgs e)
        {
            Etudiant etudiant = new Etudiant();
            View.DataEntry.StudentDataEntry dataEntry = new View.DataEntry.StudentDataEntry();
            dataEntry.DataContext = etudiant;
            if (dataEntry.ShowDialog() == true)
            {
               
                Business.ETudiantBusiness bs = this.DataContext as Business.ETudiantBusiness;
                bs.ListOfStudent.Add(etudiant);
             
            }
        }

        private void btn_Editer_Click(object sender, RoutedEventArgs e)
        {
            Business.ETudiantBusiness bs = this.DataContext as Business.ETudiantBusiness;
            if (bs.SelectedStudent!=null)
            {
                View.DataEntry.StudentDataEntry dataEntry = new DataEntry.StudentDataEntry();
                dataEntry.DataContext = bs.SelectedStudent;
                dataEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sellectionnez un element");
            }
        }

        private void btnDeleteEtudiant_Click(object sender, RoutedEventArgs e)
        {
            Business.ETudiantBusiness bs = this.DataContext as Business.ETudiantBusiness;
            if (bs.SelectedStudent != null)
            {
              bs.ListOfStudent.Remove(bs.SelectedStudent);
            }
            else
            {
                MessageBox.Show("Sellectionnez un element");
            }
        }
    }
}
