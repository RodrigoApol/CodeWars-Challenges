// Dado um array de inteiros como strings e números, 
// retorne a soma dos valores do array como se todos fossem números. 
// Retorne sua resposta como um número.

public class SumMixedArray
{
    public int SumMix(object[] x)
    {
        int sum = 0;
        foreach (var element in x)
        {
            // Método de conversão 1    
            sum += Convert.ToInt32(element);
            // Método de conversão 2
            sum += int.Parse(element.ToString()!);
        }
        return sum;
    }
}