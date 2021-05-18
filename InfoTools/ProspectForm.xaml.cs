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

namespace InfoTools
{
    /// <summary>
    /// Logique d'interaction pour ProspectForm.xaml
    /// </summary>
    public partial class ProspectForm : UserControl
    {
        public ProspectForm()
        {
            InitializeComponent();
            dbInit();
        }

        private async void dbInit()
        {
            List<Prospect> cProspect = await BDD.SelectProspect();
            DtgProspect.ItemsSource = cProspect;
        }

    }
}
