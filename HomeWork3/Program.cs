namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //davaleba1

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };

            //int[] resultArr = new int[arr1.Length + arr2.Length];


            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    resultArr[i] = arr1[i];
            //}


            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    resultArr[arr1.Length + i] = arr2[i];
            //}


            //Console.Write("result arr [ ");
            //for (int i = 0; i < resultArr.Length; i++)
            //{
            //    Console.Write(resultArr[i]);


            //    if (i < resultArr.Length - 1)
            //    {
            //        Console.Write(", ");
            //    }
            //}

            //Console.WriteLine(" ]");



            //davaleba2
            int[] arr1 = [3, 5, -4, 8, 11, 1, -1, 6];
            Console.Write("შეიყვანეთ სამიზნე ჯამი: ");

            //bool isValid = int.TryParse(Console.ReadLine(), out int num);
            int targetSum = 7;

            for (int i = 0; i < arr1.Length; i++) { 
            for(int j = 1+i; j< arr1.Length; j++)
                {
                    if (arr1[i]+ arr1[j]== targetSum)
                    {
                        Console.WriteLine("[" + arr1[i] + ", " + arr1[j] + "]");
                    }
                }
                 }
        






    }
    }
}
