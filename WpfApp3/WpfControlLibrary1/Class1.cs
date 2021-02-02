using L.Views;
using P.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using WpfControlLibrary1.Controls;
using WpfControlLibrary1.ViewModels;
using WpfControlLibrary1.Views;

namespace WpfControlLibrary1
{
    public class Class1 : IModule
    {
        IRegionManager r;
        public Class1(IRegionManager rm) 
        {
            r = rm;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //r.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
            //IRegion rg = r.Regions["ContentRegion"];
            //var v1 = containerProvider.Resolve<ViewA>();
            //var v2 = containerProvider.Resolve<ControlA>();
            //v2.Content = new TextBlock { Text="V2"};
            //var tabA = containerProvider.Resolve<TabView>();
            //SetTitle(tabA, "Tab A");
            //rg.Add(tabA);

            //var tabB = containerProvider.Resolve<TabView>();
            //SetTitle(tabB, "Tab B");
            //rg.Add(tabB);

            //var tabC = containerProvider.Resolve<TabView>();
            //SetTitle(tabC, "Tab C");
            //rg.Add(tabC);

            //rg.Add(v1);
            //rg.Add(v2);
            //rg.Add(v3);

            //rg.Activate(v3);

            //var s = containerProvider.Resolve<ShellWindow>();
            //var rr = containerProvider.Resolve<Receiver>();

            //r.AddToRegion("P",s );
            //r.AddToRegion("S", rr);
            r.RegisterViewWithRegion("P", typeof(Sender));
            r.RegisterViewWithRegion("S", typeof(Receiver));

        }

        void SetTitle(TabView tab, string title)
        {
            (tab.DataContext as TabViewModel).Title = title;
        }
        public void RegisterTypes(IContainerRegistry c)
        {
            ViewModelLocationProvider.Register<ControlA>(() => {
                return new ControlAViewModel() { C = "fac" };
            });
        }

    }
}
