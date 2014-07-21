using System;
using Simpler.Net.Wpf;

namespace WhenFinished.ViewModels
{
    /// <summary>
    /// ViewModel for MainWindow
    /// </summary>
    public class MainWindowViewModel : Bindable
    {
        private string _lastLogMessage;

        public String LastLogMessage
        {
            get { return _lastLogMessage; }
            set { SetAndNotify(ref _lastLogMessage, value); }
        }
    }
}
