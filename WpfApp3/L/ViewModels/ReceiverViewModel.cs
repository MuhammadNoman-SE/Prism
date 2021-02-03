using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfApp3.Core.Evenets;

namespace L.ViewModels
{
    public class ReceiverViewModel : BindableBase,INavigationAware
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
        SubscriptionToken st;
        public void hs(bool isshow) {
            if (isshow)
                st= ea.Subscribe(s);
            else
                ea.Unsubscribe(st);
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            C += 1;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        private int c=0;

        public int C
        {
            get { return c; }
            set { SetProperty(ref c , value);
                Count = c.ToString();
            }
        }
        private string count= "0";

        public string Count
        {
            get { return count; }
            set { SetProperty(ref count, value); }
        }
    }
}
