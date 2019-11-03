using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Rounded_Window
{
    /// <summary>
    /// Interaction logic for ImageWindow.xaml
    /// </summary>
    /// 


    public partial class ImageWindow : Window
    {
        public string ImagePath { get; set; }


        public ImageWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        public ImageWindow(string path)
        {
            this.DataContext = this;
            ImagePath = path;
            InitializeComponent();
        }

      



        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
