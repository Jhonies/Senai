    public class Sms : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }
