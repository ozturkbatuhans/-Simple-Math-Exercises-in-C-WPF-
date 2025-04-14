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

namespace math_klas_oefening1
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
            if (double.TryParse(txtcirkel.Text, out number))
            {
                double area = Math.PI * Math.Pow(number, 2);
                lblResult.Content = $"Area of the Circle: {area:F2}";
            }
            else
            {
                lblResult.Content = "Please enter a valid number for the radius.";
            }

            }
    }
}