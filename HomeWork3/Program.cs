namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //davaleba1

            //Console.WriteLine("input username:");
            //string UserName = Console.ReadLine();

            //Console.WriteLine("input paswword");
            //string Password = Console.ReadLine();

            //if(UserName =="admin" && Password== "1234")
            //{
            //    Console.WriteLine("welcome admin");
            //}
            //else
            //{
            //    Console.WriteLine("access denied");
            //}



            //davaleba2

            // Console.WriteLine("shemoiyvanet cifri");
            //int.TryParse(Console.ReadLine(),out int num1 );

            // Console.WriteLine("shemoiyvanet operatori");
            // string opetator = Console.ReadLine();

            // Console.WriteLine("shemoiyvanet cifri");
            // int.TryParse(Console.ReadLine(),out int num2);


            // int result = 0;

            // switch (opetator)
            // {
            //     case "+":
            //         result = num1 + num2;
            //         break;

            //     case "-":
            //         result = num1 - num2;
            //         break;

            //     case "*":
            //         result = num1 * num2;
            //         break;

            //     case "/":
            //         result = num1 / num2;
            //         break;
            //     default:
            //          Console.WriteLine("araswori operatori");
            //         break;
            // }
            //Console.WriteLine("shedegi " + result);


            //davaleba3 

            Console.WriteLine("sheiyvanet asaki");
            int.TryParse(Console.ReadLine(), out int age);

            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("kid");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("tineijeri");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("zrdasruli");
            }
            else { Console.WriteLine("tineijeri"); }
        }
    }
}
