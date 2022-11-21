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

namespace Hospital_wpf
{
    /// <summary>
    /// Логика взаимодействия для avtorizacia.xaml
    /// </summary>
    public partial class avtorizacia : Page
    {
        public Frame fram_reg;
        public avtorizacia(Frame fram_regg)
        {
            InitializeComponent();
            fram_reg = fram_regg;
        }

        private void Reg_button_Click(object sender, RoutedEventArgs e)
        {
            fram_reg.Navigate(new registration());
        }
    }
}
