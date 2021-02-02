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
        private ObservableCollection<string> m= new ObservableCollection<string>();

        public ObservableCollection<string> M
        {
            get { return m; }
            set {SetProperty(ref m , value); }
        }

        public ReceiverViewModel(IEventAggregator  e)
        {
            e.GetEvent<Events>().Subscribe(s,ThreadOption.PublisherThread,false,p=>p.Contains("Nomi")
                );
        }
        public void s(string ms) {
            M.Add(ms);
        }
    }
}
