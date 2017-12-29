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
    /// Interaction logic for DmeProjectManagement.xaml
    /// </summary>
    public partial class DmeProjectManagement : Window
    {
        public DmeProjectManagement()
        {
            InitializeComponent();
            SetCommandBinding();
        }

        private void SetCommandBinding()
        {
            CommandBinding printBinding = new CommandBinding(ApplicationCommands.Help);
            printBinding.CanExecute += PrintBinding_CanExecute;
            printBinding.Executed += PrintBinding_Executed;
            CommandBindings.Add(printBinding);
        }

        private void PrintBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Command executed!");
        }

        private void PrintBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AccordionItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

        }
        private void SaveCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void SaveCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

        }

        private void NewCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
