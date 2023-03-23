internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many characters should the password have?");
        int DesiredLength = Convert.ToInt32(Console.ReadLine()); //Input

        int temp;
        Random random = new Random();
        string Password = "";
        char[] Letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] SpecialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '|', '\\', ';', ':', '\'', '"', ',', '<', '.', '>', '/', '?', '`', '~' };
        char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for (int i = 1; i <= DesiredLength; i++) // Generate characters based on desired legnth
        {
            switch (random.Next(0, 3))  // choose wether to generate a number, special character or letter
            {
                case 0: // Letter
                    switch (random.Next(0, 2)) // Choose between lowercase and uppercase
                    {
                        case 0: // Upper (default)
                            Password = Password + Letters[random.Next(0, Letters.Length - 1)];
                            break;
                        case 1: // Lower
                            string RandomLetter = Convert.ToString(Letters[random.Next(0, Letters.Length - 1)]).ToLower();
                            Password = Password + RandomLetter;
                            break;
                    }
                    break;
                case 1: // Special character
                    Password = Password + Convert.ToString(SpecialChars[random.Next(0, SpecialChars.Length - 1)]);
                    break;
                case 2: // number
                    Password = Password + Convert.ToString(Numbers[random.Next(0, Numbers.Length - 1)]);
                    break;
            }
        }
        Console.WriteLine(Password); // output
    }
}
