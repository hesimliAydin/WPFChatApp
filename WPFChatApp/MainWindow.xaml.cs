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

namespace WPFChatApp
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Chat uc1 = new Chat();

            uc1.Width = 640;
            uc1.Message1Lbl.Content = "Salam aleykum";
            
            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Chat uc1 = new Chat();
            uc1.NameCentral.Content = "Kamran";
            uc1.Width = 640;
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_2.png", UriKind.Relative));
            uc1.Message1Lbl.Content = "Salam aleykum";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            Chat uc1 = new Chat();
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_3.png", UriKind.Relative));
            uc1.NameCentral.Content = "Huseyn";
            uc1.Width = 640;
            uc1.Message1Lbl.Content = "Salam aleykum";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            Chat uc1 = new Chat();
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_4.png", UriKind.Relative));
            uc1.NameCentral.Content = "Fatih";
            uc1.Width = 640;
            uc1.Message1Lbl.Content = "Salam aleykum";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            Chat uc1 = new Chat();
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_5.png", UriKind.Relative));
            uc1.NameCentral.Content = "Omer";
            uc1.Width = 640;
            uc1.Message1Lbl.Content = "Salam aleykum";

            MessageGrid.Children.Add(uc1);
        }

        private void Grid_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            Chat uc1 = new Chat();
            uc1.ImageCentral.Source = new BitmapImage(new Uri(@"/Screenshot_6.png", UriKind.Relative));
            uc1.NameCentral.Content = "Sari";
            uc1.Width = 640;
            uc1.Message1Lbl.Content = "Salam aleykum";

            MessageGrid.Children.Add(uc1);
        }
    }
}
