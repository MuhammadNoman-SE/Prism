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
            IRegion rg = r.Regions["ContentRegion"];
            var v1 = containerProvider.Resolve<ViewA>();
            var v2 = containerProvider.Resolve<ControlA>();
            //v2.Content = new TextBlock { Text="V2"};
            rg.Add(v1);
           rg.Add(v2);

            rg.Activate(v1);
        }


        public void RegisterTypes(IContainerRegistry c)
        {
            ViewModelLocationProvider.Register<ControlA>(() => {
                return new ControlAViewModel() { C = "fac" };
            });
        }

    }
}
