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
        public MainWindow()
        {
            InitializeComponent();
            l = new Logic();
        }

        private void A_Button_Click(object sender, RoutedEventArgs e)
        {
            The_text.Text = l.SQLiteTest();
        }

        private void Clr_Db_Click(object sender, RoutedEventArgs e)
        {
            l.ClrDb();
            ClearText();
        }

        private void TestCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            The_text.Text = l.Eq_test();
        }

        private void TestCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New command executed, next up: new file dialog!"); //DEBUG
            //TODO there might not be a new file dialog, can maybe use save file dialog?
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //string loadPath;
            MessageBoxResult loadConfirm = MessageBox.Show("LOCALIZE load file confirmation prompt", "LOCALIZE Confirm file load", MessageBoxButton.YesNo);
            if (loadConfirm == MessageBoxResult.Yes)
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.InitialDirectory = "";
                dlg.DefaultExt = ".txt"; //TODO change to capsule format when complete!
                dlg.Filter = "Text documents (.txt)|*.txt"; //TODO adapt for capsule format when complete!
                dlg.Multiselect = false;
                bool? result = dlg.ShowDialog();
                if (result == true)
                {
                    if (l.IsFileLoaded == true)
                    {
                        l.CloseDBFile();
                    }
                    l.LoadDBFile(dlg.FileName);
                    //loadPath = dlg.FileName;
                }
            }
        }

        private void OpenCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
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
