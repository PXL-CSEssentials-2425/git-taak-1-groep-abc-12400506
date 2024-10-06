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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void roodImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#FF0000";
        }

        private void geelImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#FFFF00";
        }

        private void groenImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#008000";
        }

        private void blauwImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#0000FF";
        }
    }
}