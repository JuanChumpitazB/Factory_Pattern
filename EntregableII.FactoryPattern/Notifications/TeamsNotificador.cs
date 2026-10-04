using EntregableII.FactoryPattern.Interfaces;

namespace EntregableII.FactoryPattern.Notifications;

public class TeamsNotificador : INotificador
{
    public void Enviar()
    {
        Console.WriteLine("Notificación enviada por Teams");
    }
}
