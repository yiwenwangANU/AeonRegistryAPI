namespace AeonRegistryAPI.Data;

public static class DataUtility
{
    public static string GetConnectionString(IConfiguration configuration)
    {
        // Local development reads from appsettings.json / user-secrets.
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Most hosts (Railway, Render, Heroku) inject a URI-form DATABASE_URL instead.
        var databaseUrl = configuration["DATABASE_URL"];

        return string.IsNullOrWhiteSpace(databaseUrl)
            ? connectionString ?? throw new InvalidOperationException(
                "No connection string found. Set ConnectionStrings:DefaultConnection or DATABASE_URL.")
            : BuildConnectionString(databaseUrl);
    }

    private static string BuildConnectionString(string databaseUrl)
    {
        var uri = new Uri(databaseUrl);
        var userInfo = uri.UserInfo.Split(':');

        return $"Host={uri.Host};Port={uri.Port};Database={uri.LocalPath.TrimStart('/')};" +
               $"Username={userInfo[0]};Password={userInfo[1]};SSL Mode=Require;Trust Server Certificate=True";
    }
}
