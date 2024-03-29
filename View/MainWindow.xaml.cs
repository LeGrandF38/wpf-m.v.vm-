﻿using Demo2.Business;
using Demo2.Model;
using Demo2.View.MyUserControls;
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

namespace Demo2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AnyName();

            //lines of code 
        }

        private void AnyName()
        {
            UcLogin ucLogin = new UcLogin();

            LoginBusiness loginBusiness = new LoginBusiness();

            ucLogin.DataContext = loginBusiness;
            
            grHome.Children.Add(ucLogin);

        }
        View.MyUserControls.UcEtudiant ucEtudiant;
        public void btnGestionEtudiant(object sender, RoutedEventArgs e)
        {
            ETudiantBusiness etudiantBusiness = new ETudiantBusiness();
            ucEtudiant = new UcEtudiant();
            ucEtudiant.DataContext = etudiantBusiness;
            grContent.Children.Clear();
            grContent.Children.Add((ucEtudiant));


        }

        private void btnGestionSalle_click(object sender, RoutedEventArgs e)
        {
           
            SalleBusiness selleBusiness = new SalleBusiness();   
            ucEtudiant.DataContext = selleBusiness;

        }

        

        
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            grContent.Children.Clear();

            AnyName();

        }

       
    }
}
