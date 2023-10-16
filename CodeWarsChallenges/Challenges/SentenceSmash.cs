using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWarsChallenges.Challenges;
// Escreva uma função que pegue um conjunto de palavras e as junte em uma frase e retorne a frase. 
// Você pode ignorar qualquer necessidade de higienizar palavras ou adicionar pontuação, 
// mas deve adicionar espaços entre cada palavra. 
// Cuidado, não deve haver espaço no início ou no final da frase!

public class SentenceSmash
{
    public string Smash(string[] words) => string.Join(" ", words);
}