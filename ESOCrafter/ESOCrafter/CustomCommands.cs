using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ESOCrafter
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand TestCommand = new RoutedUICommand
            (
                "TestCommand",
                "TestCommand",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.T, ModifierKeys.Control)
                }
            );
    }
}
