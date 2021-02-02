using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace WpfControlLibrary1.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        string p;
        public string P { get {
                return p;
            }
            set { 
               SetProperty(ref p,value); 
            }
        }
        private bool ii;

        public bool i
        {
            get { return ii; }
            set { SetProperty(ref ii , value);
                //Click.RaiseCanExecuteChanged();

            }
        }

        public ViewAViewModel()
        {
            p = "pt";
            Click = new DelegateCommand(c)//, cc)
                .ObservesCanExecute(()=>i);
                //.ObservesProperty(()=>i);
        }

        public void c() {
             P = "clicked";
        }
        public bool cc() { return i; }
        public DelegateCommand Click { get; set; }
    }
}
