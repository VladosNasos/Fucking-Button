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

namespace Fucking_Button
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
        private void gradientButton_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush gradientBrush = gradientButton.Background as LinearGradientBrush;

            if (gradientBrush != null)
            {
                Random random = new Random();

                Color startColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                Color endColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));

                gradientBrush.GradientStops[0].Color = startColor;
                gradientBrush.GradientStops[1].Color = endColor;
            }
        }
    }
}
