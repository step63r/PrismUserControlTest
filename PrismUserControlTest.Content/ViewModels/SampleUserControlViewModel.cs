using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUserControlTest.Content.ViewModels
{
    public class SampleUserControlViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public SampleUserControlViewModel()
        {
        }
    }
}
