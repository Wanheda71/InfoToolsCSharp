﻿using System;
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

namespace InfoTools
{
    /// <summary>
    /// Logique d'interaction pour AccueilForm.xaml
    /// </summary>
    public partial class AccueilForm : UserControl
    {
        public AccueilForm()
        {
            InitializeComponent();
            LblBienvenue.Content = string.Format("Bienvenue sur InfoTools CRM {0} {1}", Global.UtilisateurActuel.Nom, Global.UtilisateurActuel.Prenom);
        }
    }
}
