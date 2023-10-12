namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DZ-1
            if (args.Length == 3)
            {
                int result = 0;
                int number1 = int.Parse(args[0]);
                string operation = args[1];
                int number2 = int.Parse(args[2]);
                if (operation == "+")
                {
                    result = number1 + number2;
                }
                if (operation == "-")
                {
                    result = number1 - number2;
                }
                if (operation == "/")
                {
                    result = number1 / number2;
                }
                if (operation == "*")
                {
                    result = number1 * number2;
                }
                Console.WriteLine("Результат выполнения операции(" + operation + ") = " + result);
            }
            else
                Console.WriteLine("Для использования программы введите: число знак(+-/*) число");



            //DZ-2
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            int y = a.GetLength(0);
            int x = a.GetLength(1);
            int[] sort = new int[x * y];
            int counter = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    sort[counter] = a[i, j];
                    counter++;
                }
            }
            Array.Sort(sort);
            counter = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    a[i, j] = sort[counter];
                    counter++;
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}