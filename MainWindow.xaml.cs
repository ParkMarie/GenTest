using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Generation
{
	
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Password.Visibility = Visibility.Collapsed;
		}

		private void PassingTest_Click(object sender, RoutedEventArgs e)
		{
			
			string password = Password.Text = "";
			First tester = new(password);
			tester.ShowDialog();
		}

		private void CreateTest_Click(object sender, RoutedEventArgs e)
		{
			
			Password.Visibility = Visibility.Visible;
		}

		private void Password_TextChanged(object sender, TextChangedEventArgs e)
		{
			string password = Password.Text;

			if (Password.Text == "admin")
			{
				First test = new(password);
				test.ShowDialog();
			}
		}
	}
}