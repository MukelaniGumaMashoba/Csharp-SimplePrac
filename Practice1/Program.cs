// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter age/ wat is jou ouderdom ? ");
string input = Console.ReadLine();
int muk = int.Parse(input);
Console.WriteLine("wat is jou naam: ");
string nam = Console.ReadLine();

if(nam != "mukelani")
{
    Console.Write("Wrong naam sorry...");
}
else
{
    Console.Write("Your ouderdom and naam is .... " + muk + " " + nam);
}

