using PrismUserControlTest.Content.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PrismUserControlTest.Content
{
    public class ContentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<IRegionManager>();
            regionMan.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}