using Microsoft.AspNetCore.Mvc;

namespace RepeatAPi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CancelationController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                cancellationTokenSource.CancelAfter(3000);

                var client = new HttpClient();

                var taskResult = await client.GetAsync("https://localhost:7156/Cancelation/TakingLongApi", cancellationTokenSource.Token);

                RunningTask(cancellationTokenSource.Token);

                return Ok(taskResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }
        [HttpGet("TakingLongApi")]
        public async Task<IActionResult> TakingLongApi()
        {
            await Task.Delay(10000);
            return Ok();

        }

        private async Task<string> RunningTask(CancellationToken cancellationToken)
        {

            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {

                    return "canceled";
                }
            }


            return "done";
        }
    }
}
