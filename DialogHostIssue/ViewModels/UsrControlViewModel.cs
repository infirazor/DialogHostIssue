using Caliburn.Micro;
using DialogHostIssue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogHostIssue.ViewModels
{
    class UsrControlViewModel : Screen
    {
        private string _demoStringValue;

        public string DemoStringValue
        {
            get { return _demoStringValue; }
            set { _demoStringValue = value;
                NotifyOfPropertyChange(() => DemoStringValue);
            }
        }


        private Customers _selectedCustomer;
        public Customers SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                NotifyOfPropertyChange(() => SelectedCustomer);
            }
        }

        private List<Customers> _customers = new List<Customers>();
        public List<Customers> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                NotifyOfPropertyChange(() => Customers);
            }
        }

        private BindableCollection<string> _newCustomers = new BindableCollection<string>();
        public BindableCollection<string> NewCustomers
        {
            get { return _newCustomers; }
            set { _newCustomers = value;
                NotifyOfPropertyChange(() => NewCustomers);
            }
        }


        public UsrControlViewModel()
        {
            Customers.Add(new Customers { CustomerName = "Stark", EmailAddress = "tony@starkindustries.com", MobileNo = "123456789" });
            Customers.Add(new Customers { CustomerName = "Hulk", EmailAddress = "hulk@avengers.com", MobileNo = "123456789" });
            Customers.Add(new Customers { CustomerName = "Captain America", EmailAddress = "steve@avengers.com", MobileNo = "123456789" });

            NewCustomers.Add("Hulk");
            NewCustomers.Add("Tony Stark");
            NewCustomers.Add("Steve");
            NewCustomers.Add("Banner");

            DemoStringValue = "Demo";
        }
    }
}
