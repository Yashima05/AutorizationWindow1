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
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		String login = "abcd33";
		String password = "qwer123";
		
		public MainWindow()
		{
			InitializeComponent();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			if (loginVoid.Text == login && passwordVoid.Text == password)
			{
				passwordMassange.Foreground = Brushes.Green;
				passwordMassange.Text = "Данные введены верно!";
				MainFrame.Navigate(new ListPres1());
			}
			else 
			{
				passwordMassange.Text = "Данные введены неверно!";
				loginVoid.Text = "Логин";
				passwordVoid.Text = "Пароль";
			}
        }

        private void password_Click(object sender, MouseButtonEventArgs e)
        {
			passwordVoid.Foreground = Brushes.Black;
			passwordVoid.Text = "";
        }
		private void login_Click(object sender, MouseButtonEventArgs e) 
		{
			loginVoid.Foreground = Brushes.Black;
			loginVoid.Text = "";
		}
		
	}
}
