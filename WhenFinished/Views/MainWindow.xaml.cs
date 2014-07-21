using System;
using Simpler.Net.Wpf;
using WhenFinished.ViewModels;

namespace WhenFinished.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// <see cref="SimplerWindow"/>
        /// </summary>
        protected virtual SimplerWindow Win { get; set; }

        public virtual MainWindowViewModel ViewModel { get; set; } 

        /// <summary>
        /// P-less c-tor.
        /// </summary>
        public MainWindow()
        {
            ViewModel = new MainWindowViewModel();
            App.Logger.AfterEntryAdd += (sender, entry) => ViewModel.LastLogMessage = entry.Message;

            InitializeComponent();

            Win = new SimplerWindow(this);

            Win.FullyLoaded += (sender, args) => App.LoadConfig();
        }
    }
}
