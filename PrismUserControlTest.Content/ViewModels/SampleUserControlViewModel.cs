﻿using Prism.Mvvm;

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
