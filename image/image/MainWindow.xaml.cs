using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace image
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            open.ShowDialog();
            string filename = open.FileName;
            Uri uri = new Uri(filename);
            var bitmap = new BitmapImage(uri);
            Image.Source = bitmap;
        }

        private void Uniform_Click(object sender, RoutedEventArgs e)
        {
            Image.Stretch = Stretch.Uniform;
        }

        private void UniformtoFill_Click(object sender, RoutedEventArgs e)
        {
            Image.Stretch = Stretch.UniformToFill;
        }

        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            Image.Stretch = Stretch.Fill;
        }

        private void None_Click(object sender, RoutedEventArgs e)
        {
            Image.Stretch = Stretch.None;
        }

        private void UpOnly_Click(object sender, RoutedEventArgs e)
        {
            Image.StretchDirection = StretchDirection.UpOnly;
        }

        private void DownOnly_Click(object sender, RoutedEventArgs e)
        {
            Image.StretchDirection = StretchDirection.DownOnly;
        }

        private void Both_Click(object sender, RoutedEventArgs e)
        {
            Image.StretchDirection = StretchDirection.Both;
        }
    }
}
