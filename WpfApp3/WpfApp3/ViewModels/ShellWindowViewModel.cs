using Core;
using Prism.Mvvm;
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

        public ShellWindowViewModel(IAppCommands ac)
        {
            AC = ac;
        }
    }
}
