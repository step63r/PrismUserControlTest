using Prism.Ioc;
using Prism.Modularity;
using PrismUserControlTest.Content;
using PrismUserControlTest.Views;
using System.Windows;

namespace PrismUserControlTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ContentModule>();
        }
    }
}
