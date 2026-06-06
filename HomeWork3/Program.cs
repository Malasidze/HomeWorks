namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //davaleba1

            //Console.WriteLine("sheiyvanet cifri");
            //bool isValid = int.TryParse(Console.ReadLine(), out int num);
            //if (isValid)
            //{
            //	for (int i = 0; i <= 10; i++)
            //	{
            //		Console.WriteLine(num*i);
            //	}
            //}


            //davaleba2

            //Console.WriteLine("sheiyvanet cifri");
            //bool isValid = int.TryParse(Console.ReadLine(), out int num);
            //if (isValid)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        for (int j = 1; j <= num - i; j++)

            //            Console.Write(" ");
            //        for (int k = 1; k <= i; k++)

            //            Console.Write("* ");
            //        Console.WriteLine();

            //    }


            //}
            //else
            //{
            //    Console.WriteLine("invalid input");
            //}

            //davaleba3 

            //Console.WriteLine("enter number");

            //bool isValid = int.TryParse(Console.ReadLine(), out int num1);
            //int numbers = 0;
            //if (isValid)
            //{
            //    for (int j = 2; j < num1; j += 2)
            //    {
            //        numbers += j;
            //    }
            //}


            //Console.WriteLine(numbers);



            //davaleab4

            Random random = new Random();
           

            int rand = random.Next(0, 100); 

            Console.WriteLine("Enter number");
            bool isvalid = int.TryParse(Console.ReadLine(), out int userNum);


            while (rand != userNum || !isvalid)
            {
                
                Console.WriteLine("tavidan cadet");
                isvalid = int.TryParse(Console.ReadLine(), out userNum);
            }
        }
    }
}
