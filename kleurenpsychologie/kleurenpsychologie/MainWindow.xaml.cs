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
            informatieTextbox.Text = "Rood is de kleur van warmte";
        }

        private void geelImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#FFFF00"; 
            informatieTextbox.Text = "Geel is de kleur van levenslust";

        }

        private void groenImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#008000";
            informatieTextbox.Text = "Groen is de kleur van genezing";
        }

        private void blauwImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurcodeTextbox.Text = "#0000FF";
            informatieTextbox.Text = "Blauw is de kleur van intelligentie";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}