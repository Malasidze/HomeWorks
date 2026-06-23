namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //დავალება 1
            //int[][] students = [
            //    [10,8,9],
            //    [9,6,5],
            //    [7,7,10]
            //    ];

            //int sum = 0;
            //for (int i = 0; i < students.Length; i++)
            //{   

            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        sum += students[i][j];

            //    }
            //    Console.WriteLine(sum / students[i].Length);



            //davaleba2

            //Random rand = new();


            //int[] passcodes = new int[10];

            //for (int i = 0; i < passcodes.Length; i++)
            //{
            //    passcodes[i] = rand.Next(1000, 10000);
            //}

            //Console.WriteLine("shemoiyvan epaskodi");
            //bool isValid = int.TryParse(Console.ReadLine(), out int userInput);

            //bool isMatch = false;

            //if (isValid)
            //{
            //    for (int i = 0; i < passcodes.Length; i++)
            //    {
            //        if (userInput == passcodes[i])
            //        {

            //            isMatch = true;
            //            break;
            //        }

            //    }
            //}
            //Console.WriteLine(isMatch ? "correct" : "inccorect");



            //davaleba3
            //int[] numbers = [2, 3, 4, -4, 11, 12];
            //int min = numbers[0]; 
            //int max = numbers[0]; 

            //foreach (var item in numbers)
            //{
            //    if (item < min)
            //    {
            //        min = item;
            //    }

            //    if (item > max)
            //    {
            //        max = item;
            //    }
            //}


            //davaleba 4

            string[] words = ["dachi", "gocha", "ado"];


            foreach (var item in words)
            {
            	foreach (var symbol in item)
            	{
            		Console.WriteLine(symbol);
            	}
           }
            //davaleba 5



            string[] emails = ["gftyyiif@gg", "adomalo@iii"];

            bool validEmail = false;
            foreach (var email in emails)
            {
                foreach (var symbol in email)
                {
                    if (symbol == '@')
                    {
                        validEmail = true;
                    }
                    Console.WriteLine(validEmail ? "valid" : "not valid");
                }
            }


        }
    }
}
