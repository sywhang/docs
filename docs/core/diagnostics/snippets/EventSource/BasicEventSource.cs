using System;
using System.Diagnostics.Tracing;

namespace EventSourceExample
{
    [EventSource(Name="BasicEventSource")]
    public class BasicEventSource
    {
        public static readonly BasicEventSource Log = new BasicEventSource();

        [Event(1, Level = EventLevel.Error, Keywords = Keywords.Diagnostic)]
        public void ProgramStarted(string message) { WriteEvent(1, message); }


    }

    public class Program
    {
        public static void main()
        {
            BasicEventSource.Log.ProgramStarted
        }
    }
}