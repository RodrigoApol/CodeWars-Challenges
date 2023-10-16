// Dado um array de inteiros, retorne um novo array com cada valor duplicado. 
// Por exemplo:

// [1, 2, 3] --> [2, 4, 6]
public class LostWithoutAMap
{
    public int[] Maps(int[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            x[i] *= 2;
        }
        return x;
    }

    // Console.WriteLine(string.Join(", ", desafio.Maps(myArray)));
}