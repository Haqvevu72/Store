using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<product> Products = new List<product>() 
        {
            new product("ProductImages\\cola.jpg","Coca-Cola","12.4$"),
            new product("ProductImages\\lays.jpg", "Lays","13.5$"),
            new product("ProductImages\\pepsi.jpg", "Pepsi","12.3$"),
            new product("ProductImages\\sprite.jpg", "Sprite","13.4$")
        };
        public MainWindow()
        {
            InitializeComponent();
            Bravo.ItemsSource = Products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            StackPanel stackPanel = button.Parent as StackPanel;
            StackPanel namecost = stackPanel.Children[1] as StackPanel;
            TextBlock name = namecost.Children[0] as TextBlock;
            TextBlock cost = namecost.Children[1] as TextBlock;
            Image image = button.Content as Image;
            BitmapImage bitmapImage = new BitmapImage(new Uri(image.Source.ToString(), UriKind.RelativeOrAbsolute));

            Product product =new Product();
            
            Button Pbutton = (Button)product.FindName("image");
            Image Pimage = Pbutton.Content as Image;
            Pimage.Source = bitmapImage;

            StackPanel Name = (StackPanel)product.FindName("name");
            TextBox Pname = Name.Children[1] as TextBox;
            Pname.Text = name.Text;

            StackPanel Cost = (StackPanel)product.FindName("cost");
            TextBox Pcost = Cost.Children[1] as TextBox;
            Pcost.Text = cost.Text;

            product.Show();
        }
    }
}
