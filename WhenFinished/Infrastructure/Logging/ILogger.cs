using System;
using Simpler.Net.Events.Logging;

namespace WhenFinished.Infrastructure.Logging
{
    public interface ILogger : ISimplerEventLogger
    {
        event EventHandler<SimplerEventLogEntry> BeforeEntryAdd;
        event EventHandler<SimplerEventLogEntry> AfterEntryAdd;
    }
}