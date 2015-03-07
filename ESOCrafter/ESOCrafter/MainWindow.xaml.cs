﻿using System;
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
            //MessageBox.Show(l.SQLiteTest());
            The_text.Text = l.SQLiteTest();
        }

        private void Clr_Db_Click(object sender, RoutedEventArgs e)
        {
            l.ClrDb();
            ClearText();
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
