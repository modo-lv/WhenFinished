using System;
using System.Collections.ObjectModel;
using System.Linq;
using Simpler.Net.Events.Logging;

namespace WhenFinished.Infrastructure.Logging
{
    /// <summary>
    /// A XAML-bindable extension of <see cref="SimplerEventLogger"/>.
    /// </summary>
    public class Logger : SimplerEventLogger, ILogger
    {
        public event EventHandler<SimplerEventLogEntry> BeforeEntryAdd;
        public event EventHandler<SimplerEventLogEntry> AfterEntryAdd;

        public ObservableCollection<String> FormattedEntries
        {
            get
            {
                return
                    new ObservableCollection<string>(
                        Entries.Select(e => String.Format("{0} [{1}] {2}", e.Time, e.Severity, e.Message)));
            }
        }

        protected virtual void OnBeforeEntryAdd(SimplerEventLogEntry entry)
        {
            if (BeforeEntryAdd != null)
                BeforeEntryAdd(this, entry);
        }

        protected virtual void OnAfterEntryAdd(SimplerEventLogEntry entry)
        {
            if (AfterEntryAdd != null)
                AfterEntryAdd(this, entry);
        }

        /// <summary>
        /// P-less c-tor.
        /// </summary>
        public Logger()
        {
            Entries = new ObservableCollection<SimplerEventLogEntry>();
        }

        public override SimplerEventLogEntry AddNewEntry(SimplerEventLogEntry entry)
        {
            OnBeforeEntryAdd(entry);
            var result = base.AddNewEntry(entry);
            OnAfterEntryAdd(entry);
            return result;
        }
    }
}
