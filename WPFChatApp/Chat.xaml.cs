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
    /// Interaction logic for Chat.xaml
    /// </summary>
    public partial class Chat : UserControl
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void rightMessageTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (rightMessageTextBox.Text.ToString() == "Type Something")
                rightMessageTextBox.Text = String.Empty;
        }


        private void rightMessageTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (rightMessageTextBox.Text.ToString() == String.Empty)
                rightMessageTextBox.Text = "Type Something";
        }

        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label sendMessage = new Label()
            {
                Foreground = new SolidColorBrush(Colors.Black),
                FontSize = 10,
                Content = rightMessageTextBox.Text,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            Label answerMessage = new Label()
            {
                Foreground = new SolidColorBrush(Colors.Black),
                FontSize = 10,
                Content = "Salam",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };


            var lenght1 = sendMessage.Content!.ToString()!.Length;
            var answerLenght = answerMessage.Content!.ToString()!.Length;

            Border border = new()
            {
                Margin = new Thickness(5, 5, 5, 5),
                Background = new SolidColorBrush(Colors.WhiteSmoke),
                Height = 40,
                Width = sendMessage.FontSize * lenght1,
                HorizontalAlignment = HorizontalAlignment.Right,
                CornerRadius = new CornerRadius(25, 25, 0, 25),
                Child = sendMessage
            };

            Border border2 = new()
            {
                Margin = new Thickness(5, 5, 5, 5),
                Background = new SolidColorBrush(Colors.WhiteSmoke),
                Height = 40,
                Width = answerMessage.FontSize * answerLenght,
                HorizontalAlignment = HorizontalAlignment.Left,
                CornerRadius = new CornerRadius(25, 25, 25, 0),
                Child = answerMessage
            };

            ChatGrid.Children.Add(border);
            ChatGrid.Children.Add(border2);

        }
    }
}
