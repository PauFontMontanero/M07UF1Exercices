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

namespace ExerciciPractic6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<String> imagePaths;
        private int currentIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            Create_ImageList();
            DisplayImage();
        }

        private void Create_ImageList()
        {
            imagePaths = new List<String> {
                "Archer.jpg",
                "Mage.jpg",
                "Warrior.jpg"
            };
        }
        private void DisplayImage()
        {
            ImageFrame.Source = "Archer.jpg";
            

            //String bitmap = new String(new Uri($"pack://application:,,,/ExerciciPractic6;component/Images/{imagePaths}");
            //ImageFrame.Source = bitmap;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}