using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESOCrafter
{
    class RefocusCutSnippets
    {

        /*
         * SOURCE: MAINWINDOW.XAML.CS
         * 
         * 
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
         */

        //***************************

        /*
         * SOURCE: MAINWINDOW.XAML
         * 
         *         <CommandBinding Command="ApplicationCommands.New" Executed="NewCommand_Executed" CanExecute="NewCommand_CanExecute" />
         *         <CommandBinding Command="ApplicationCommands.Open" Executed="OpenCommand_Executed" CanExecute="OpenCommand_CanExecute" />
         *         
         *         <MenuItem Header="Save to file" Command="Save"/>
         *         <MenuItem Header="Open DB File" Command="Open"/>
         * 
         */

        //***************************

        /*
         * SOURCE: ENTIRE CLASS OF METADATA.CS
         * 
         * 
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;

                namespace ESOCrafter
                {
                    /// <summary>
                    /// A Metadata class for persistent storing of data not in the database, ie. pertaining not the data but the application in general.
                    /// </summary>
                    [Serializable()]
                    class Metadata
                    {
                        public List<String> FilePathList { get; private set; }

                        public Metadata()
                        {
                            FilePathList = new List<string>();
                            //TODO might need more code in here. Add as needed.
                        }

                        public void AddElement(string element)
                        {
                            FilePathList.Add(element);
                        }
                        public void ClearList()
                        {
                            FilePathList = new List<string>();
                        }
                    }
                }
         * 
         * 
         */
    }
}
