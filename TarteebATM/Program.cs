using System;
using TarteebATM.Services;

namespace TarteebATM
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MenuService menu = new MenuService();

            menu.PrintMessage("Tarteeb ATM ga hush kelibsiz!!!!");
            menu.PrintMessage("Dasturdan foydalanish uchun o'zingizga parol yarating!!\n");

            Console.Write("Yangi parolni kiriting: ");
            string userInputGreatePassword = Console.ReadLine();
            Console.Clear();
            menu.PrintMessage("Parol yaratildi.........");
            menu.PrintMessage("Davom etish uchun istalgan klavyaturani bosing!!!");
            Console.ReadKey(); 

            
           
            bool isPassword = true;
            
            while (isPassword)
            {
                Console.Clear();
                menu.PrintMessage("========Tarteeb ATM========");
                menu.PrintMessage("Dasturdan foydalanish uchun yaratilgan parolni kiriting!!!!\n");
                Console.Write("Parolingizni kiriting: ");
                string userInputPassword = Console.ReadLine();

                if (userInputPassword == userInputGreatePassword)
                {
                    Console.WriteLine("dcdsdscd");

                    


                    isPassword = false;
                }
                else 
                {
                    menu.PrintMessage("Parolni noto'g'ri kiritdingiz!!!");
                    menu.PrintMessage("Davom etish uchun istalgan klavyaturani bosing!!!");
                    Console.ReadKey();

                }

                


            }


        }
    }
}