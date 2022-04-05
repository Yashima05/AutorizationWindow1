using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

namespace LoginPasswordApp
{
    /// <summary>
    /// Логика взаимодействия для Addclient.xaml
    /// </summary>
    public partial class Addclient : Page
    {
        Client _currentClient = new Client();
        public Addclient(Client selectedClient)
        {
            InitializeComponent();
            if(selectedClient != null)
            {
                _currentClient = selectedClient;
            }
            DataContext = _currentClient;
        }

        private void BtnSaveClick(object sender, RoutedEventArgs e)
        {
            Entities.GetEntities().Client.Add(_currentClient);
            try
            {
                Entities.GetEntities().SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            NavigationService.Navigate(new ListPres1());
        }
    }
}
