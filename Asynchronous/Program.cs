
namespace Asynchronous
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            await Task1();
            //List<Task<string>> tasks = new List<Task<string>>();

            //tasks.Add(PerformCalculationAsync("Task 1", 6000));
            //tasks.Add(PerformCalculationAsync("Task 2", 3000));
            //tasks.Add(PerformCalculationAsync("Task 3", 12000));

            //var finishedTasks = Task.WhenAll(tasks);

            //foreach (var task in finishedTasks.Result)
            //{
            //    Console.WriteLine($"First response received: {task}");
            //}


            //Thread thread = new Thread(new ThreadStart(DoWork));
            //Thread thread2 = new Thread(new ThreadStart(DoWork));



            //thread.Start();
            //thread2.Start();
            //thread.Join();
            //thread2.Join();

        }

        //static void DoWork()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("something");
        //    }
        //}





        //static async Task<string> PerformCalculationAsync(string taskName, int delay)
        //{
        //    Console.WriteLine($"{taskName} started.");
        //    await Task.Delay(delay);

        //    // Read database


        //    Console.WriteLine($"{taskName} completed.");

        //    return $"{taskName} result: Calculation done in {delay} milliseconds.";
        //}






        static async Task Task1()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                ProgressBar progressBar = new ProgressBar();

                var t = Task.Run(() => IncrementBar(progressBar, cts));

                var incrementTask = IncrementBar(progressBar, cts);
                var printTask = PrintBar(progressBar, cts.Token);

                await Task.Delay(2000);
                cts.Cancel();

                await Task.WhenAll(incrementTask, printTask);
            }


        }
        static async Task<bool> IncrementBar(ProgressBar progressBar, CancellationTokenSource cts)
        {
            while (progressBar.GetProgress() <= 99)
            {

                progressBar.Increment();
                await Task.Delay(100); //switch context to other until you finish delay
            }
            cts.Cancel();
            return true;
        }
        static async Task<bool> PrintBar(ProgressBar progressBar, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    Console.WriteLine(progressBar.GetProgress());
                    //paused
                    await Task.Delay(300, cancellationToken);
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return true;
        }
    }
}
