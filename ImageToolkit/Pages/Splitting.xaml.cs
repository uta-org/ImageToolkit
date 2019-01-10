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

namespace ImageToolkit.Pages
{
    /// <summary>
    /// Interaction logic for Splitting.xaml
    /// </summary>
    public partial class Splitting : UserControl
    {
        public Splitting()
        {
            InitializeComponent();
        }

        private void ucSplitting_Loaded(object sender, RoutedEventArgs e)
        {
            // Do this when resizing app...
            imgSplit.MinHeight = ucSplitting.ActualHeight - 250;
        }
    }
}