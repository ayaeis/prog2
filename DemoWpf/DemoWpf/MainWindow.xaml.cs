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

namespace DemoWpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                Display.Text += button.Content;
            }
            string text = Display.Text;
            var talen = text.Split('+' , '/' , '-' , '=');
            var tal1 = Convert.ToInt32(talen[0]);
            var tal2 = Convert.ToInt32(talen[1]);                            
            var resultat = tal1 + tal2;
            Display.Text = resultat + "";
        }
    }
}
