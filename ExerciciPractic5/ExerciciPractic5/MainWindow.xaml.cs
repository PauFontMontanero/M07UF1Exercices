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

namespace ExerciciPractic5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu1_Click(object sender, RoutedEventArgs e)
        {
            MenuName.Content = "Estas al menú 1";
        }

        private void Menu2_Click(object sender, RoutedEventArgs e)
        {
            MenuName.Content = "Estas al menú 2";
        }

        private void Menu3_Click(object sender, RoutedEventArgs e)
        {
            MenuName.Content = "Estas al menú 3";
        }

        private void Menu4_Click(object sender, RoutedEventArgs e)
        {
            MenuName.Content = "Estas al menú 4";
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            MenuName.Content = "Main Menu";
        }
    }
}