using System;
using Simpler.Net.Wpf;

namespace WhenFinished.ViewModels
{
    /// <summary>
    /// ViewModel for MainWindow
    /// </summary>
    public class MainWindowViewModel : Bindable
    {
        /// <summary>
        /// Last message in the event log.
        /// </summary>
        public String LastLogMessage
        {
            get { return _lastLogMessage; }
            set { SetAndNotify(ref _lastLogMessage, value); }
        }

        /// <summary>
        /// User's selection of what to do when the given up has finished.
        /// </summary>
        public FinishActionType FinishAction
        {
            get { return _finishAction; }
            set { SetAndNotify(ref _finishAction, value); }
        }

        #region Backing fields
        private string _lastLogMessage;
        private FinishActionType _finishAction;
        #endregion
    }
}
