Console.Write("Skriv ett ord här: ");
string input = Console.ReadLine();

char[] charArray = input.ToCharArray();

Array.Reverse(charArray);

string reversed = new string(charArray);

if (input == reversed)
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("Inte en palindrom");
}

