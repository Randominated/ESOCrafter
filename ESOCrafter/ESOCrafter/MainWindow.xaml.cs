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


namespace ESOCrafter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Logic l;
        AddItemDialog addItemDialog;
        public MainWindow()
        {
            InitializeComponent();
            l = new Logic();
            addItemDialog = new AddItemDialog();
        }

        private void A_Button_Click(object sender, RoutedEventArgs e)
        {
            The_text.Text = l.SQLiteTest();
        }
        
        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            addItemDialog.Show();
        }

        private void DiscardDatabase_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult confirmDiscardDB = MessageBox.Show("Are you sure you want to discard the database?\n\nWARNING: This can not be undone!", "Confirm Database Discard", MessageBoxButton.YesNo);
            if (confirmDiscardDB == MessageBoxResult.Yes)
            {
                l.DiscardDB();
                ClearText();
            }
        }

        private void DiscardDatabase_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void TestCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            The_text.Text = l.Eq_test();
        }

        private void TestCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ClearText()
        {
            The_text.Text = "";
        }


    }
}
