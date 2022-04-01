using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hqCmWpfCore1.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _title;
        public string Title { 
            get => _title;
            set 
            {
                _title = value;
                NotifyOfPropertyChange("Title");
            }
        }
        public ShellViewModel()
        {
            Title = "Welcome to Caliburn Micro in .net 6 WPF";
        }

    }
}

