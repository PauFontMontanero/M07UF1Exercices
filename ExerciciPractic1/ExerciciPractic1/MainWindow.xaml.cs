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

namespace ExerciciPractic1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int comptador = 0;
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox.IsChecked == true)
            {
                MessageBox.Show("The counter is on!");
            }
            else
            {
                MessageBox.Show("The counter is off!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CheckBox.IsChecked == true)
            {
                comptador+=1;
                Comptador.Content = comptador;
            }
        }
    }
}