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
    /// Interaction logic for SpellCheckWindow.xaml
    /// </summary>
    public partial class SpellCheckWindow : Window
    {
        public SpellCheckWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            SpellingError error = txtBox.GetSpellingError(txtBox.CaretIndex);
            txtBox.TextAlignment = TextAlignment.Justify;
            if (error != null)
            {
                foreach (var hint in error.Suggestions)
                {
                    sb.Append($"{hint}\n");
                }
                SpellingHintsLabel.Content = sb.ToString();
                hintExpander.IsExpanded = true;
            }
        }
    }
}
