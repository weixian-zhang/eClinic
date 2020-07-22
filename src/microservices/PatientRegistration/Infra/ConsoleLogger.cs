using System;
using Serilog;
using Serilog.Formatting.Elasticsearch;

namespace eClinic.PatientRegistration.Infra
{
    public class ConsoleLogger : IAppLogger
    {
        public ConsoleLogger()
        {
            _logger = new LoggerConfiguration()
                .WriteTo
                .Console(new ElasticsearchJsonFormatter())
                .CreateLogger();

        }

        public void Error(Exception ex)
        {
            _logger.Error(ex, ex.Message);
        }

        public void Info(string message)
        {
            _logger.Information(message);
        }

        private ILogger _logger;
    }
}