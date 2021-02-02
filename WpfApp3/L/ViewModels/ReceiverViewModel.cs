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
            set {SetProperty(ref m , value); ea.Subscribe(s); }
        }
        private bool show=true;

        public bool Show
        {
            get { return show; }
            set { SetProperty(ref show , value); hs(show); }
        }
        public WpfApp3.Core.Evenets.Events ea;
        public ReceiverViewModel(IEventAggregator  e)
        {
            ea = e.GetEvent<Events>();//.Subscribe(s,ThreadOption.PublisherThread,false,p=>p.Contains("Nomi")
                                      //);
            hs(true);
        }
        public void s(string ms) {
            M.Add(ms);
        }

        public void hs(bool isshow) {
            if (isshow)
                ea.Subscribe(s);
            else
                ea.Unsubscribe(s);
        }
    }
}
