namespace Application.Api.HiperHub;

public class Program : BaseApiProgram<Startup>
{
    public static async Task Main(string[] args)
    {
        var webHost = BuildWebHost(args);

        ILogger logger = webHost.Services.GetRequiredService<ILogger<Program>>();

        try
        {
            logger.LogInformation("Starting web host");

            await webHost.RunAsync();
        }
        catch (Exception ex)
        {
            logger.LogCritical(ex, ex.Message);
        }
    }
}