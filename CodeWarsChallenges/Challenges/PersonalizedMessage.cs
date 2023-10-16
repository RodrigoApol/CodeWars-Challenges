namespace CodeWarsChallenges.Challenges;

// Crie uma função que forneça uma saudação personalizada. 
// Esta função recebe dois parâmetros: nome e proprietário. 
// Use condicionais para retornar a mensagem adequada:

public class PersonalizedMessage
{
    public string Greet(string name, string owner) => name == owner ? "Hello boss" : "Hello guest";
}