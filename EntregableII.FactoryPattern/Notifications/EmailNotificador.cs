using EntregableII.FactoryPattern.Interfaces;

namespace EntregableII.FactoryPattern.Notifications;

public class EmailNotificador : INotificador
{
    public void Enviar()
    {
        Console.WriteLine("Notificación enviada por Email");
    }
}
