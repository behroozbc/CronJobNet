using System;
using System.Threading;
using System.Threading.Tasks;

namespace CronJobNet;

public interface ICronJob
{
    string Name { get; }
    Task ExecuteAsync(DateTime dateTime, CancellationToken cancellationToken);

    event EventHandler<string> JobExecuting;
    event EventHandler<string> JobExecuted;
}
