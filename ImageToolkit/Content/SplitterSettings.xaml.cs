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

namespace ImageToolkit.Content
{
    /// <summary>
    /// Interaction logic for SplitterSettings.xaml
    /// </summary>
    public partial class SplitterSettings : UserControl
    {
        public SplitterSettings()
        {
            InitializeComponent();
        }

        private void ucSplitterSettings_Loaded(object sender, RoutedEventArgs e)
        {
            udOverlapping.Visibility = Visibility.Hidden;
            lblOverlapping.Visibility = Visibility.Hidden;

            rbQuantity.IsChecked = true;
        }

        private void chkOverlapping_Checked(object sender, RoutedEventArgs e)
        {
            var visibility = chkOverlapping.IsChecked.Value ? Visibility.Visible : Visibility.Hidden;

            udOverlapping.Visibility = visibility;
            lblOverlapping.Visibility = visibility;
        }

        private void rbQuantity_Checked(object sender, RoutedEventArgs e)
        {
            ToggleRadioButtons();
        }

        private void ToggleRadioButtons()
        {
            rbQuantity.IsChecked = !rbHeight.IsChecked;
            rbHeight.IsChecked = !rbQuantity.IsChecked;
        }
    }
}