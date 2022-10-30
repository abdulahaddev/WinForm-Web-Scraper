using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebScrapper
{
    public class TaskLimiter
    {
        private readonly TimeSpan _timespan;
        private readonly SemaphoreSlim _semaphore;

        public TaskLimiter(int count, TimeSpan timespan)
        {
            _semaphore = new SemaphoreSlim(count, count);
            _timespan = timespan;
        }

        public async Task LimitAsync(Func<Task> taskFactory)
        {
            //await _semaphore.WaitAsync().ConfigureAwait(false);
            await _semaphore.WaitAsync();
            try
            {
                await taskFactory();
                await Task.Delay(_timespan);
            }
            finally
            {
                _semaphore.Release();
            }
        }

    }
}
