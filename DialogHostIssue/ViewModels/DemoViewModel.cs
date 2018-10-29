using Caliburn.Micro;
using DialogHostIssue.Views;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogHostIssue.ViewModels
{
    class DemoViewModel : Screen
    {
        private bool _isDialogOpen;
        public bool IsDialogOpen
        {
            get { return _isDialogOpen; }
            set { _isDialogOpen = value;
                NotifyOfPropertyChange(() => IsDialogOpen);
            }
        }

        public DemoViewModel()
        {

        }

        public async void OpenDialog()
        {
            
            var view = new UsrControlView
            {
                DataContext = new UsrControlViewModel()
            };

            //show the dialog
            var result = await DialogHost.Show(view, "RootDialog", ExtendedOpenedEventHandler, ExtendedClosingEventHandler);
        }

        private void ExtendedOpenedEventHandler(object sender, DialogOpenedEventArgs eventargs)
        {
            Console.WriteLine("You could intercept the open and affect the dialog using eventArgs.Session.");
        }
        private void ExtendedClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
            //if ((bool)eventArgs.Parameter == false) return;

            ////OK, lets cancel the close...
            //eventArgs.Cancel();

            ////note, you can also grab the session when the dialog opens via the DialogOpenedEventHandler

            ////lets run a fake operation for 3 seconds then close this baby.
            //Task.Delay(TimeSpan.FromSeconds(3))
            //    .ContinueWith((t, _) => eventArgs.Session.Close(false), null,
            //        TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
