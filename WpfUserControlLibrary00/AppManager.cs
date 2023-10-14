using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using WpfUserControlLibrary00.Models;
using WpfUserControlLibrary00.ViewModels;
// using WpfUserControlLibrary00.ViewModels.Views;

namespace WpfUserControlLibrary00
{
    public class AppManager
    {
        MainWindowViewModel mainWindowViewModel;

        public AppManager()
        {
            mainWindowViewModel = new MainWindowViewModel();
            MainWindowApp mainWindow = new MainWindowApp();
            mainWindow.DataContext = mainWindowViewModel;
            mainWindow.Show();
        }
    }
}
