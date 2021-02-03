using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class DialogService
    {
        public static void ShowDialog(this IDialogService d,string message, Action<IDialogResult> cb) {
            var p = new DialogParameters();
            p.Add("message",message);
            d.ShowDialog("Dialog", p, cb);

        }
    }
}
