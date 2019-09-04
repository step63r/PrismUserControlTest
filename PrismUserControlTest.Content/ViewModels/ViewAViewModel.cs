using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismUserControlTest.Content.Common;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PrismUserControlTest.Content.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;

        public ReactiveCollection<SampleUserControlViewModel> UserControls { get; set; } = new ReactiveCollection<SampleUserControlViewModel>();

        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            BindingOperations.EnableCollectionSynchronization(UserControls, new object());
            _eventAggregator = eventAggregator;

            for (int i = 1; i < 21; i++)
            {
                var uc = new SampleUserControlViewModel(_eventAggregator)
                {
                    Message = string.Format("This is UserControl of No. {0}", i)
                };
                UserControls.Add(uc);
                //_eventAggregator.GetEvent<MessageSentEvent>().Publish(string.Format("This is UserControl of No. {0}", i));
            }
        }
    }
}
