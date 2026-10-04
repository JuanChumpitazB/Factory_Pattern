using EntregableII.FactoryPattern.Factories;
using EntregableII.FactoryPattern.Interfaces;

Console.WriteLine("=== Entregable II - Factory Pattern ===");
Console.WriteLine("Creación de notificadores mediante NotificadorFactory.");
Console.WriteLine();

var tiposNotificacion = new[] { "email", "sms", "teams" };

foreach (var tipo in tiposNotificacion)
{
    INotificador notificador = NotificadorFactory.Crear(tipo);
    notificador.Enviar();
}
