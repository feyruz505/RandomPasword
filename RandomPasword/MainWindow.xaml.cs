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
using Bogus;

namespace RandomPasword
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void HandleButton_Click(object sender, RoutedEventArgs e) => PasswordLabel.Content = txtBox.Text;

        private void RandomButton_Click(Object sender, RoutedEventArgs e)
        {
            Faker fakePasword = new Faker();
            PasswordLabel.Content = fakePasword.Internet.Password();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
