using System.Text.Json;

const string configFile = "appsettings.json";

if (File.Exists(configFile))
{
    var json = File.ReadAllText(configFile);
    using var document = JsonDocument.Parse(json);
    var connectionString = document.RootElement
        .GetProperty("ConnectionStrings")
        .GetProperty("DefaultConnection")
        .GetString();

    Console.WriteLine("Simulación de cadena de conexión:");
    Console.WriteLine(connectionString);
}
else
{
    Console.WriteLine($"No se encontró el archivo de configuración '{configFile}'.");
}

Console.WriteLine("Hello, platzi!");
