using EntregableII.FactoryPattern.Interfaces;

namespace EntregableII.FactoryPattern.Notifications;

public class SmsNotificador : INotificador
{
    public void Enviar()
    {
        Console.WriteLine("Notificación enviada por SMS");
    }
}
