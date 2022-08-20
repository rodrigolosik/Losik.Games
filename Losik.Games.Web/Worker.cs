namespace Losik.Games.Web
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            do
            {
                _logger.LogInformation($"Rodando...{DateTime.Now}");

                await Task.Delay(TimeSpan.FromSeconds(5));
            } while (true);

        }
    }
}
