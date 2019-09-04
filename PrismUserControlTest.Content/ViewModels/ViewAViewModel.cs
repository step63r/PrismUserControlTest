using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace PrismUserControlTest.Content.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ObservableCollection<SampleUserControlViewModel> UserControls { get; set; } = new ObservableCollection<SampleUserControlViewModel>();

        public ViewAViewModel()
        {
            for (int i = 1; i < 21; i++)
            {
                var uc = new SampleUserControlViewModel()
                {
                    Message = string.Format("This is UserControl of No. {0}", i)
                };
                UserControls.Add(uc);
            }
        }
    }
}
