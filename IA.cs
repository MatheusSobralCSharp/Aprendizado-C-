class MinhaIA
{
    public void Run()
    {
        Console.WriteLine("Bem vindo ao J.A.R.V.I.S como posso te ajudar hoje?");
        string userInput = Console.ReadLine();
        
        switch (userInput)
        {
            case "Como está o tempo hoje?":
                Console.WriteLine("Eu não tenho certeza, poderia me informar sua localização?");
                string location = Console.ReadLine();
                Console.WriteLine($"A temperatura em {location} está 30 graus celsius");
                break;
            case "Que horas são?":
                Console.WriteLine($"Atualmente são {DateTime.Now.ToShortTimeString()} horas.");
                break;
            default:
                Console.WriteLine("Perdão, eu não entendi o que você quis dizer!");
                break;
        }
        
        Console.WriteLine("Obrigado por conversar comigo campeão! Até a próxima!");
    }
}
