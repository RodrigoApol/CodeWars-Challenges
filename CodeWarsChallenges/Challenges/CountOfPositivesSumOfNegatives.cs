using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Dada uma matriz de inteiros. 
// Retorna uma matriz, onde o primeiro elemento é a contagem dos números positivos 
// e o segundo elemento é a soma dos números negativos. 
// 0 não é positivo nem negativo. Se a entrada for uma matriz vazia ou nula, retorne uma matriz vazia.

namespace CodeWarsChallenges.Challenges
{
    public class CountOfPositivesSumOfNegatives
    {
        int positiveNumbers = 0;
        int sumNegatives = 0;

        public int[] CountPositivesSumNegatives(int[] input)
        {
            if (input is null || input.Length == 0)
            {
                return Array.Empty<int>();
            }
            else
                foreach (int e in input)
                {
                    _ = e > 0 ? positiveNumbers++ : sumNegatives += e;
                }
            return new int[] { positiveNumbers, sumNegatives };
        }
    }
}
