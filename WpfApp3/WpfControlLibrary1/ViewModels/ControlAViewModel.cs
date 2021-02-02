using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfControlLibrary1.ViewModels
{
    public class ControlAViewModel:BindableBase
    {
        private string myVar="ct";

        public string C
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public ControlAViewModel()
        {

        }

    }
}
