using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models;

class QnAService
{
    private readonly string subscriptionKey;
    private readonly string endpoint;
    private readonly string knowledgeBaseId;
    
    public QnAService(string subscriptionKey, string endpoint, string knowledgeBaseId)
    {
        this.subscriptionKey = subscriptionKey;
        this.endpoint = endpoint;
        this.knowledgeBaseId = knowledgeBaseId;
    }
    
    public async Task<string> GetAnswer(string question)
    {
        var client = new QnAMakerRuntimeClient(new EndpointKeyServiceClientCredentials(subscriptionKey)) { RuntimeEndpoint = endpoint };
        var response = await client.Runtime.GenerateAnswerAsync(knowledgeBaseId, new QueryDTO { Question = question });

        if (response.Answers.Any())
        {
            return response.Answers.First().Answer;
        }
        else
        {
            return "Desculpe, não tenho certeza como te responder isso.";
        }
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        var qnaService = new QnAService("<your-subscription-key>", "<your-endpoint>", "<your-knowledge-base-id>");

        Console.WriteLine("Bem vindo(a) ao sistema de Perguntas e Respostas!");
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            var answer = await qnaService.GetAnswer(input);
            Console.WriteLine(answer);
        }
    }
}
