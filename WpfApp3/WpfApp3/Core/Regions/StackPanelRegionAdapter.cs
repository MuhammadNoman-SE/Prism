using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3.Core.Regions
{
    public class StackPanelRegionAdapter:RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(RegionBehaviorFactory f) :
            base(f)
        {
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged+=(s,e)=>{
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach ( FrameworkElement frameWorkElement in e.NewItems) 
                    {
                        regionTarget.Children.Add(frameWorkElement);
                    }
                }
                else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove) 
                {
                    foreach (FrameworkElement frameWorkElement in e.OldItems)
                    {
                        regionTarget.Children.Remove(frameWorkElement);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
           return new Region();
        }
    }
}
