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

namespace Rounded_Window
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

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
        /*
         * Double click the picture to open new window
         * And double click to new window to close it 
         * 
         * 
         * */
        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow("Images/img1.jpg");
            imageWindow.Show();
        }
        private void ContentControl_MouseDoubleClick2(object sender, MouseButtonEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow("Images/img2.jpg");
            imageWindow.Show();
        }
        private void ContentControl_MouseDoubleClick3(object sender, MouseButtonEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow("Images/img3.jpg");
            imageWindow.Show();
        }
        private void ContentControl_MouseDoubleClick4(object sender, MouseButtonEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow("Images/img4.jpg");
            imageWindow.Show();
        }
    }
}
