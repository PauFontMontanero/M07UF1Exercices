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

namespace ExerciciPractic3
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

        private void CambiarLabel_Click(object sender, RoutedEventArgs e)
        {
            Missatge.IsEnabled = false;

            String Content = (string)CambiarLabel.Content;
            Label.Content = Content;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Missatge.IsEnabled = true;
            Label.Content = "ACTIVE!";
        }

        private void Missatge_Click(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("IT WORKS!");
        }
    }
}