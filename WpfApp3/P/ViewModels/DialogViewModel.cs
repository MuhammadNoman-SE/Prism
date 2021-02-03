using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P.ViewModels
{
    public class DialogViewModel : BindableBase,IDialogAware
    {
        public DialogViewModel()
        {
            Ok = new DelegateCommand(co);
            Cancel = new DelegateCommand(cc);
        }
        public void co() {
            var r = ButtonResult.OK;
            var p = new DialogParameters();
            p.Add("param", "OK");
            RequestClose?.Invoke(new DialogResult(r, p));

        }
        public void cc()
        {
            var r = ButtonResult.Cancel;
            var p = new DialogParameters();
            p.Add("param", "Cancel");
            RequestClose?.Invoke(new DialogResult(r, p));

        }
        private string myVar;

        public string Message
        {
            get { return myVar; }
            set {SetProperty(ref myVar , value); }
        }
        public DelegateCommand Ok { get; set; }
        public DelegateCommand Cancel { get; set; }

        public string Title => "Show?";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
