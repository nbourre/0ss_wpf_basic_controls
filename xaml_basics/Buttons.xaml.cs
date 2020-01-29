using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace xaml_basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Buttons : Window
    {
        public Buttons()
        {
            InitializeComponent();
        }



        private void OrdinaryButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Bouton cliqué");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Bouton maintenu");
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton btn = (ToggleButton)sender;
            
            Debug.WriteLine($"Bouton état {btn.IsChecked}");
        }

        private void chkBox_Checked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Case cochée");
        }

        private void chkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Case décochée");
        }

        private void chkBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Case indéfinie");
        }
    }
}
