using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogHostIssue.ViewModels
{
    class DemoWithContentViewModel : Conductor<object>
    {
        private bool _isDialogOpen;

        public bool IsDialogOpen
        {
            get { return _isDialogOpen; }
            set
            {
                _isDialogOpen = value;
                NotifyOfPropertyChange(() => IsDialogOpen);
            }
        }

        public void OpenDialog()
        {
            IsDialogOpen = true;
            ActivateItem(new UsrControlViewModel());
        }
    }
}
