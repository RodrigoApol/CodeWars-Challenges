// Dado um número aleatório não negativo, 
// você deve retornar os dígitos desse número em uma matriz na ordem inversa.

// 35231 => [1,3,2,5,3]
// 0 => [0]

public class ConvertNumberToReversedArray
{
    public long[] Digitize(long number)
    {
        return number.ToString().ToCharArray().Reverse().Select(n => long.Parse(n.ToString())).ToArray();
    }
}