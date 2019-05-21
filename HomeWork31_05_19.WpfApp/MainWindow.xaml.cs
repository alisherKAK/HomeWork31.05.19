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

namespace HomeWork31_05_19.WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DarkThemeButtonClick(object sender, RoutedEventArgs e)
        {
            this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/DarkTheme.xaml") };
        }

        private void LightThemeButtonClick(object sender, RoutedEventArgs e)
        {
            this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/LightTheme.xaml") };
        }
    }
}
