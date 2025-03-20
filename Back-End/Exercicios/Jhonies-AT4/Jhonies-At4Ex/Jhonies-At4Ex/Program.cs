using System;

class Program
{
    static void Main()
    {
        INotificacao email = new Email();
        email.EnviarMensagem("Seja bem-vindo ao nosso sistema");
        
        INotificacao sms = new Sms();
        sms.EnviarMensagem("Seu codigo de verificação é 123456");
        
        INotificacao push = new PushNotificacao();
        push.EnviarMensagem("Você tem uma nova mensagem");
    }
}