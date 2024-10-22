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

namespace Inventario_Zelda
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

        private void Reloj_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush brush = new();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/img/relojA_1.png"));

            Reloj.Background = brush;
        }
    }
}