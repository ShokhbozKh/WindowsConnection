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
using System.Windows.Shapes;

namespace WindowsConnection.Windows
{
    /// <summary>
    /// Interaction logic for Oyna2.xaml
    /// </summary>
    public partial class Oyna2 : Window
    {
        public Oyna2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window1= new Window1();
            window1.ShowDialog();
        }
    }
}
