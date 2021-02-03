using Core.Business;
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
        private ObservableCollection<Person> m= new ObservableCollection<Person>();
        private IRegionManager r;

        public ObservableCollection<Person> People
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
        public ReceiverViewModel(IEventAggregator  e,IRegionManager rm)
        {
            ea = e.GetEvent<Events>();//.Subscribe(s,ThreadOption.PublisherThread,false,p=>p.Contains("Nomi")
                                      //);
            hs(true);
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            r = rm;
        }
        public DelegateCommand<Person> PersonSelectedCommand { get;  set; }


        private void PersonSelected(Person person)
        {
            if (null == person)
                return;
            var p = new NavigationParameters();
            p.Add("person",person);
            r.RequestNavigate("PersonDetailsRegion", "PersonDetail",p);
        }
        public void s(Person ms) {
            People.Add(ms);
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
