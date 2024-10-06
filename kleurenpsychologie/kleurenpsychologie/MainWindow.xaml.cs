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

namespace kleurenpsychologie
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

        private void roodImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);

        }

        private void groenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);

        }

        private void blauwImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void geelImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Yellow);
        }
    }
}