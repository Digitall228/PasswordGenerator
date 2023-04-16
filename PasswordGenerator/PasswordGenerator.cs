using System;

namespace PassGen
{
    public static class PasswordGenerator
    {
        public static Random rnd = new Random();
        public static string keys = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789";
        public static string Generate(int number = 20, string Keys = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789")
        {
            char[] key = Keys.ToCharArray();
            string password = string.Empty;
            
            for (int i = 0; i < number; i++)
            {
                password += key[rnd.Next(0, key.Length)];
            }
            return password;
        }
    }
}
