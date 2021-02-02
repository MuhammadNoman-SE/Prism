using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using WpfApp3.Core.Evenets;

namespace P.ViewModels
{
    public class SenderViewModel : BindableBase
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
    }
}
