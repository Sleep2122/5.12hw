Console.WriteLine("a * x^2 + b * x + c = 0");

bool test =false;
bool K=true;
while (test == false)
{
    Console.WriteLine("Введите значение a");
    var A = Console.ReadLine();
    Console.WriteLine("Введите значение b");
    var B = Console.ReadLine();
    Console.WriteLine("Введите значение c");
    var C = Console.ReadLine();
    int a;
    int b;
    int c;
    try
    {
 
        if ((int.TryParse(A, out a)) == false)
        {
            var ex = new FormatDate("Вы ввели не целое число a");
            throw ex;
        }
        if ((int.TryParse(B, out b))==false)
        {
            var ex = new FormatDate("Вы ввели не целое число b");
            throw ex;
        }
        if ((int.TryParse(C, out c)) == false)
        {
            var ex = new FormatDate("Вы ввели не целое число c");
            throw ex;
        }

    }
    catch (FormatDate e)
    {
        Console.WriteLine("ошибка ввода "+ e.Message);
        K = false;
    }


    if (K==true) 
    {
        a = int.Parse(A);
        b = int.Parse(B);
        c = int.Parse(C);
        double answer1;
        double answer2;
        float D = b * b - 4 * a * c;
        if (D == 0)
        {
            answer1 = -1 * b / (2 * a);
            Console.WriteLine("x= " + answer1);

        }
        if (D > 0)
        {
            answer1 = (-1 * b + Math.Sqrt(D)) / 2 * a;
            answer2 = (-1 * b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("x1= " + answer1);
            Console.WriteLine("x2= " + answer2);
            
        }
        try
        {
            if (D < 0)
            {
                var ex = new FormatDate("Вещественных значений не найдено");
                throw ex;
            }
        }
        catch (FormatDate e)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }



        test = true;
    }

}


class FormatDate : Exception
{
    public FormatDate(string message):base(message)
    {

    }
}
