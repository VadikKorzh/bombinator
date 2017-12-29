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

namespace Bombinator
{
    /// <summary>
    /// Interaction logic for WrapPanelWindow.xaml
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            this.DynEllipse.Width += 10.0;
            this.DynEllipse.Height += 10.0;
        }

        private void RepeatButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.DynEllipse.Width -= 10.0;
            this.DynEllipse.Height -= 10.0;
        }
    }
}
