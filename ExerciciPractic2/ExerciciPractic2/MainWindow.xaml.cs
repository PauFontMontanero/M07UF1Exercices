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

namespace ExerciciPractic2
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
        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            var currentTheme = Application.Current.Resources.MergedDictionaries[0].Source.ToString();
            var newTheme = currentTheme.Contains("TemaClar.xaml") ? "TemaFosc.xaml" : "TemaClar.xaml";
            LoadTheme(newTheme);
        }
        public void LoadTheme(String themeFileName)
        {
            ResourceDictionary theme = new ResourceDictionary
            {
                Source = new Uri($"pack://application:,,,/ExerciciPractic2;component/Themes/{themeFileName}")
                
            };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(theme);
    }


    }



}