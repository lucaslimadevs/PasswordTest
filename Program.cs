using System;
using System.Linq;

namespace Algorithms
{
    class PasswordTest
    {
        const string _sequencial = "0123456789";
        const int _size = 8;

        static bool HasSpecialCharacter(string s)
            => s.Any(ch => ! char.IsLetterOrDigit(ch));        

        static string GetNumbers(string s)
            => string.Join("", s.ToCharArray().Where(Char.IsDigit));        

        static bool IsPasswordStrong(string s)
        {
            return s.Any(char.IsUpper) &&                     //check if string contains a upper character
                s.Any(char.IsLower) &&                        //check if string contains a lower character
                s.Any(char.IsDigit) &&                        //check if string contains a number        
                s.Any(ch => ! char.IsLetterOrDigit(ch)) &&    //check if string contains a special character
                !_sequencial.Contains(GetNumbers(s)) &&       //check if string don't contains sequential numbers
                (s.Count() >= _size);                         //check size of password
        }

        static void Main(string[] args)
        {
            // Console.WriteLine(HasSpecialCharacter("@"));
            // Console.WriteLine(HasSpecialCharacter("#"));
            // Console.WriteLine(HasSpecialCharacter("!"));
            // Console.WriteLine(HasSpecialCharacter("%"));
            // Console.WriteLine(HasSpecialCharacter("&"));
            // Console.WriteLine(HasSpecialCharacter("*"));
            // Console.WriteLine(HasSpecialCharacter("+"));
            // Console.WriteLine(HasSpecialCharacter("_"));
            // Console.WriteLine(HasSpecialCharacter("-"));
            
            //Console.WriteLine(GetNumbers("a123b456"));

            Console.WriteLine(IsPasswordStrong("Ab12545@"));
            Console.WriteLine(IsPasswordStrong("ab44451@"));
            Console.WriteLine(IsPasswordStrong("Abbbbbb@"));
            Console.WriteLine(IsPasswordStrong("Ab444516"));
            Console.WriteLine(IsPasswordStrong("Ab12345@"));
            Console.WriteLine(IsPasswordStrong("Ab44451"));
        }
    }
}