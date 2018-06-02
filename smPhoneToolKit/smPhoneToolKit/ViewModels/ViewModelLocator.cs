using smPhoneToolKit.ViewModels.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.ViewModels
{
    public sealed class ViewModelLocator
    {
        private static readonly MainWindowViewModel mainWindow = new MainWindowViewModel();
        public static MainWindowViewModel MainWindow
        {
            get
            {
                return ViewModelLocator.mainWindow;
            }
        }

        private static readonly InfoPageViewModel infoPage = new InfoPageViewModel();
        public static InfoPageViewModel InfoPage
        {
            get
            {
                return ViewModelLocator.infoPage;
            }
        }
    }
}
