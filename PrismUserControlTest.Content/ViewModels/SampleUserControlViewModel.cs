using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismUserControlTest.Content.Common;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUserControlTest.Content.ViewModels
{
    public class SampleUserControlViewModel : BindableBase
    {
        //public ReactiveProperty<string> Message { get; set; } = new ReactiveProperty<string>();
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public SampleUserControlViewModel(IEventAggregator eventAggregator)
        {
            //eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(string message)
        {
            Message = message;
        }
    }
}
