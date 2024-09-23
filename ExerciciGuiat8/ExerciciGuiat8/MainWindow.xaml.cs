using LiveCharts.Wpf;
using LiveCharts;
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

namespace ExerciciGuiat8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gràfic.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> {3, 5, 7, 4}
                }
            };

        }
    }
}