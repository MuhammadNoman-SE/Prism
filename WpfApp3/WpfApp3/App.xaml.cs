using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp3.Core.Regions;
using WpfApp3.Views;
using WpfControlLibrary1;
using WpfControlLibrary1.Controls;
using WpfControlLibrary1.ViewModels;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel),Container.Resolve<StackPanelRegionAdapter>());
        }

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    base.ConfigureModuleCatalog(moduleCatalog);
        //    moduleCatalog.AddModule<Class1>();
        //}

        protected override IModuleCatalog CreateModuleCatalog() 
        {
            return new ConfigurationModuleCatalog();
           // return new DirectoryModuleCatalog() { ModulePath= "./Modules" };
        }

        //protected override void ConfigureViewModelLocator()
        //{
        //    base.ConfigureViewModelLocator();
        //    ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(vt=> {
        //        string n= $"{ vt.FullName.Replace("Controls", "ViewModels") }ViewModel,{ vt.Assembly.FullName}";
        //        return Type.GetType(n);
        //    });
        //}

        
    }
}
