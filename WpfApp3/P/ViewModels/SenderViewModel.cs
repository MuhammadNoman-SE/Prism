using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using WpfApp3.Core.Evenets;

namespace P.ViewModels
{
    public class SenderViewModel : BindableBase,INavigationAware
    {
        private DelegateCommand s;

        public DelegateCommand S
        {
            get { return s; }
            set { SetProperty(ref s, value); }
        }
        private IEventAggregator e;

        public IEventAggregator E
        {
            get { return e; }
            set { e = value; }
        }
        private string m;

        public string M
        {
            get { return m; }
            set {SetProperty(ref m , value); }
        }

        public SenderViewModel(IEventAggregator e)
        {
            S = new DelegateCommand(sm);
            E = e;
        }
        public void sm() {
            E.GetEvent<Events>().Publish(M);
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            C+=1;
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
            set { SetProperty(ref c, value);
                Count= c.ToString();
            }
        }
        private string count="0";

        public string Count
        {
            get { return count; }
            set {SetProperty(ref count , value); }
        }


    }
}
