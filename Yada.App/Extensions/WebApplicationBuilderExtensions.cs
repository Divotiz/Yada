namespace Yada.App;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder InitWebApplicationBuilder(this WebApplicationBuilder builder)
    {
        var logger = builder.AddSerilog();
        logger.LogInformation("Starting...");

        builder.Services.AddControllersWithViews();

        builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(nameof(AppSettings)));
        builder.Services.AddBusinessServices();
        builder.Services.AddDataRepositories();
        builder.Services.AddScoped<YadaContext>();

        return builder;
    }
}
