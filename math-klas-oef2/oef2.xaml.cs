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

namespace math_klas_oef2
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

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            double number;
            if (double.TryParse(txtnumber.Text, out number))
            {
                double kwaadraatwortel = Math.Sqrt(number);
                lblResult.Content = $"Kwaadraatwortel: {kwaadraatwortel:F2}";
            }
            else
            {
                lblResult.Content = "Please enter a valid number for the radius.";
            }
        }
    }
}