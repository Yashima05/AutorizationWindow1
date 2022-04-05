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

namespace LoginPasswordApp
{
    /// <summary>
    /// Логика взаимодействия для ListPres1.xaml
    /// </summary>
    public partial class ListPres1 : Page
    {
        public ListPres1()
        {
            InitializeComponent();
            Dgrid.ItemsSource = Entities.GetEntities().Client.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Addclient(null));
        }

        private void Button_Click_Edt(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Addclient((sender as Button).DataContext as Client));
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = Dgrid.SelectedItems.Cast<Client>().ToList();
            if(MessageBox.Show($"Удалить {clientsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Entities.GetEntities().Client.RemoveRange(clientsForRemoving);
                    Entities.GetEntities().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    Dgrid.ItemsSource = Entities.GetEntities().Client.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
