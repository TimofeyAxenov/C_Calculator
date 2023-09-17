internal class Program
{

    private static void Main(string[] args)
    {
        double num1;
        double num2;
        string oper;
        double result;
        while (true)
        {
            result = 0f;
            Console.WriteLine("Введите первое значение");
            if (!Double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Введено значение неверного типа");
                continue;
            }
            else
            {
                Console.WriteLine("Введите второе значение");
                if (!Double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Введено значение неверного типа");
                    continue;
                }
                else
                {
                    Console.WriteLine("Введите символ действия");
                    oper = Console.ReadLine();
                }
            }
            
            
            
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя!");
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        break;
                    }
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                    
            }
            Console.WriteLine(result);
        }
    }
}
