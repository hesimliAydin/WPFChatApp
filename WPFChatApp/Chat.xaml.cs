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

        bool isCheck = false;
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (isCheck == false)
            {

                var message = new Chat();
                message.HorizontalAlignment = HorizontalAlignment.Right;
                message.Content = rightMessageTextBox.Text.ToString();
                message.Height = 30;
                ChatGrid.Children.Add(message);
                rightMessageTextBox.Text = String.Empty;
                isCheck = true;
            }
            else
            {
                var message = new Chat();
                message.HorizontalAlignment = HorizontalAlignment.Left;
                message.Content = rightMessageTextBox.Text.ToString();
                message.Height = 30;
                ChatGrid.Children.Add(message);
                rightMessageTextBox.Text = String.Empty;
                isCheck = false;
            }

        }
    }
}
