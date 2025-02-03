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

namespace ESOCrafter
{
    /// <summary>
    /// Interaction logic for AddItemDialog.xaml
    /// </summary>
    public partial class AddItemDialog : Window
    {
        public AddItemDialog()
        {
            InitializeComponent();
        }

        private void Btn_window_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_window_ok_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
