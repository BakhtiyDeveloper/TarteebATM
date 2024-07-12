using System;

namespace TarteebATM
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tarteeb ATM ga hush kelibsiz!!!!");
            Console.WriteLine("Dasturdan foydalanish uchun o'zingizga parol yarating!!\n");

            Console.Write("Yangi parolni kiriting: ");
            string userInputGreatePassword = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("========Tarteeb ATM========");
            Console.WriteLine("Dasturdan foydalanish uchun yaratilgan parolmi kiriting!!!!\n");
            Console.Write("Parolni kiriting: ");
            string userInputPassword = Console.ReadLine();

            do 
            {
                Console.WriteLine("parol");



            } while (userInputPassword == userInputGreatePassword);
            {
                Console.WriteLine("dcdcdscdscdsc");
            }


        }
    }
}