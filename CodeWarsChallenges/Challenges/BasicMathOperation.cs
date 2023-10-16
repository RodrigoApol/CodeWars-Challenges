// Sua tarefa é criar uma função que execute quatro operações matemáticas básicas.

// A função deve receber três argumentos - operação(string/char), valor1(número), valor2(número). 
// A função deve retornar resultado de números após aplicar a operação escolhida.

public class BasicMathOperation
{
    public double BasicOp(char operation, double value1, double value2)
    {
        return operation switch
        {
            '+' => value1 + value2,
            '-' => value1 - value2,
            '*' => value1 * value2,
            '/' => value1 / value2,
            _ => throw new ArgumentException("Operação desconhecida!", operation.ToString()),
        };

        // switch padrão 
        // --------------
        // switch (operation)
        // {
        //     case '+': return value1 + value2;
        //     case '-': return value1 - value2;
        //     case '*': return value1 * value2;
        //     case '/': return value1 / value2;
        //     default: throw new System.ArgumentException("Operação desconhecida!", operation.ToString());
        // }
    }
}