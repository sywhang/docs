using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.NETCore.Client;
using System.Diagnostics;
using System.IO;
using System.Threading.Task;

public class Tracer
{
    public void TraceProcessForDuration(int processId, int duration, string traceName)
    {
        var cpuProviders = new List<EventPipeProvider>()
        {
            new EventPipeProvider("Microsoft-Windows-DotNETRuntime", EventLevel.Informational, (long)ClrTraceEventParser.Keywords.Default),
            new EventPipeProvider("Microsoft-DotNETCore-SampleProfiler", EventLevel.Informational, (long)ClrTraceEventParser.Keywords.None)
        };
        var client = new DiagnosticsClient(processId);
        using (var traceSession = client.StartEventPipeSession(cpuProviders))
        {
            Task copyTask = Task.Run(async () =>
            {
                using (FileStream fs = new FileStream(traceName, FileMode.Create, FileAccess.Write))
                {
                    await traceSession.EventStream.CopyToAsync(fs);
                }
            });

            Task.WhenAny(copyTask, Task.Delay(duration * 1000));
            traceSession.Stop();
        }
    }
}
