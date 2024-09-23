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

namespace ExerciciPractic4
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

        private void PersonaFisica_Checked(object sender, RoutedEventArgs e)
        {
            NomLabel.Content = "Nom";
            IdentificadorLabel.Content = "DNI";
        }
        private void Empresa_Checked(object sender, RoutedEventArgs e)
        {
            NomLabel.Content = "Empresa";
            IdentificadorLabel.Content = "CIF";
        }

        private void NomTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomTextBox.Text))
            {
                AlertaNom.Visibility = Visibility.Visible;

            }
            else
            {
                AlertaNom.Visibility = Visibility.Collapsed;
            }
            if (!string.IsNullOrWhiteSpace(NomTextBox.Text) && !string.IsNullOrWhiteSpace(IdentificadorTextBox.Text))
            {
                Comprovar.IsEnabled = true;
            }
            else
            {
                Comprovar.IsEnabled = false;
            }
        }

        private void IdentificadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdentificadorTextBox.Text))
            {
                AlertaIdentificador.Visibility = Visibility.Visible;
            }
            else
            {
                AlertaIdentificador.Visibility = Visibility.Collapsed;
            }

            if (!string.IsNullOrWhiteSpace(NomTextBox.Text) && !string.IsNullOrWhiteSpace(IdentificadorTextBox.Text))
            {
                Comprovar.IsEnabled = true;
            }
            else
            {
                Comprovar.IsEnabled = false;
            }
        }

        private void Comprovar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Quan el programa funcioni et comprovarem les dades!");
        }
    }
}