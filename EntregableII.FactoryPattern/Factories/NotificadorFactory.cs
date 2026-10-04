using EntregableII.FactoryPattern.Interfaces;
using EntregableII.FactoryPattern.Notifications;

namespace EntregableII.FactoryPattern.Factories;

public static class NotificadorFactory
{
    public static INotificador Crear(string tipo)
    {
        return tipo.Trim().ToLowerInvariant() switch
        {
            "email" => new EmailNotificador(),
            "sms" => new SmsNotificador(),
            "teams" => new TeamsNotificador(),
            _ => throw new ArgumentException(
                $"Tipo de notificador no soportado: {tipo}",
                nameof(tipo))
        };
    }
}
