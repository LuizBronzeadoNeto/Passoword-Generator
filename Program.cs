﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many characters should the password have?");
        int DesiredLength = Convert.ToInt32(Console.ReadLine());

        int temp;
        Random random = new Random();
        string Password = "";
        char[] Letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] SpecialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '|', '\\', ';', ':', '\'', '"', ',', '<', '.', '>', '/', '?', '`', '~' };
        char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for (int i = 1; i <= DesiredLength; i++)
        {
            switch (random.Next(0, 3))
            {
                case 0:
                    switch (random.Next(0, 2))
                    {
                        case 0:
                            Password = Password + Letters[random.Next(0, Letters.Length - 1)];
                            break;
                        case 1:
                            string RandomLetter = Convert.ToString(Letters[random.Next(0, Letters.Length - 1)]).ToLower();
                            Password = Password + RandomLetter;
                            break;
                    }
                    break;
                case 1:
                    Password = Password + Convert.ToString(SpecialChars[random.Next(0, SpecialChars.Length - 1)]);
                    break;
                case 2:
                    Password = Password + Convert.ToString(Numbers[random.Next(0, Numbers.Length - 1)]);
                    break;
            }
        }
        Console.WriteLine(Password);
    }
}