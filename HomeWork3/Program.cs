namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //davaleba1

            //Console.WriteLine(power(2, 3));



            //int power(int num1, int num2)
            //{
            //    int result = num1;
            //    for (int i = 1; i < num2; i++)
            //    {
            //        result *= num1; 
            //    }

            //    return result;
            //}




            //davaleba2

            bool IsPrime(int num)
            {

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }

                return true;

            }


            Console.WriteLine("Ennter numebe");
            bool isValid = int.TryParse(Console.ReadLine(), out int userNum);

            Console.WriteLine(IsPrime(userNum) ? "primitive" : "conpose");


            //davaleba3


            //bool IsPailndrome(string pal)
            //{
            //    if (pal.Length < 2)
            //    {
            //        return true;
            //    }

            //    if (pal[0] != pal[pal.Length - 1])
            //    {
            //        return false;
            //    }

            //    string middle = pal.Substring(1, pal.Length - 2);

            //    return IsPailndrome(middle);
            //}

            //Console.WriteLine(IsPailndrome("1noon"));



            //davaleba 5

            //int Pow(int num, int powerer)
            //{
            //	if(powerer == 1)
            //	{
            //		return num;
            //	}

            //	return num * Pow(num, powerer - 1);
            //}




        }
    }
}
