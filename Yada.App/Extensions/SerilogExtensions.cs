namespace Yada.App.Extensions;

public static class SerilogExtensions
{
    public static Microsoft.Extensions.Logging.ILogger AddSerilog(this WebApplicationBuilder builder)
    {
        // build logger configuration
        var loggerConfiguration = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration);

        // create logger instance
        var logger = loggerConfiguration.CreateLogger();

        // Register the logger
        builder.Host.UseSerilog(logger);

        // Init static logger factory
        StaticLoggerConfiguration.SetStaticLoggerFactory((LoggerFactory)new LoggerFactory().AddSerilog(logger));

        return StaticLoggerConfiguration.CreateLogger<Program>();
    }
}
