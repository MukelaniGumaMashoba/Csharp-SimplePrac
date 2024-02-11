//Console.WriteLine("Please enter age/ wat is jou ouderdom ? ");
//string input = Console.ReadLine();
//int muk = int.Parse(input);
//Console.WriteLine("wat is jou naam: ");
//string nam = Console.ReadLine();

//if(nam != "mukelani")
//{
//    Console.Write("Wrong naam sorry...");
//}
//else
//{
//   Console.Write("Your ouderdom and naam is .... " + muk + " " + nam);
//}

internal class Program
{
    private static void Main(string[] args)
    {
        int count = 3; //you have only 3 attemps...
        for (int i = 0; i < count; i--)
        {
            Console.WriteLine("Please enter age/ wat is jou ouderdom ? ");
            string input = Console.ReadLine();
            int muk = int.Parse(input);
            Console.WriteLine("wat is jou naam: ");
            string nam = Console.ReadLine();

            if (nam == "mukelani" && muk == 20)
            {
                Console.Write("You entered the correct credintials ");
                break;
            }
            else if (count == 0)
            {
                break;
            }
            else
            {
                Console.Write("Sorry Wrong Password.....Try again");
                count -= 1;
                continue;

            }



        }
    }
}