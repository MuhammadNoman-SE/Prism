using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfApp3.Core.Evenets;

namespace L.ViewModels
{
    public class ReceiverViewModel : BindableBase
    {
        private ObservableCollection<string> m;

        public ObservableCollection<string> M
        {
            get { return m; }
            set { m = value; }
        }

        public ReceiverViewModel(IEventAggregator  e)
        {
            e.GetEvent<Events>().Subscribe(s);
        }
        public void s(string ms) {
            M.Add(ms);
        }
    }
}
