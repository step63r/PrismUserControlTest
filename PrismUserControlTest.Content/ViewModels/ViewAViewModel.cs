using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUserControlTest.Content.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ObservableCollection<SampleUserControlViewModel> UserControls { get; set; } = new ObservableCollection<SampleUserControlViewModel>();

        public ViewAViewModel()
        {
            for (int i = 1; i < 51; i++)
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
