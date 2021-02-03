using Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3.ViewModels
{
    public class ShellWindowViewModel:BindableBase
    {
        private IAppCommands myVar;

        public IAppCommands AC
        {
            get { return myVar; }
            set { SetProperty(ref myVar , value); }
        }
        public DelegateCommand<string> NC { get; set; }
        private IRegionManager r;
        public ShellWindowViewModel(IAppCommands ac, IRegionManager rm)
        {
            AC = ac;
            NC = new DelegateCommand<string>(n);
            r = rm;
        }
        private void n(string u) {
            r.RequestNavigate("C",u);
        }
    }
}
