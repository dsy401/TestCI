// See https://aka.ms/new-console-template for more information

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

if (string.IsNullOrEmpty(connectionString))
{
    Console.WriteLine("Null");
}
else
{
    Console.WriteLine($"HI: {connectionString}");
}