public class GradeBook
{
    public char GetGrade(int s1, int s2, int s3)
    {
        var score = (s1 + s2 + s3) / 3;

        if (score >= 90 && score <= 100)
            return 'A';
        else if (score >= 80)
            return 'B';
        else if (score >= 70)
            return 'C';
        else if (score >= 60)
            return 'D';
        return 'F';
    }

    //  var desafio = new GradeBook();

    //  Console.WriteLine(desafio.GetGrade(65, 65, 65));
}