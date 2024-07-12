using System;

namespace TarteebATM.Services
{
    internal class MenuService
    {
        internal void ShowMenu()
        {
            PrintMassegeMenu("\nChoose one below!!!");
            PrintMassegeMenu("1 - Balance check.");
            PrintMassegeMenu("2 - Withdraw money from the balance.");
            PrintMassegeMenu("3 - Topping up the balance.");
            PrintMassegeMenu("4 - Spending");
            PrintMassegeMenu("5 - Exit the program");
        }

        
        internal void PrintMessage(string message) 
        {
            Console.WriteLine(message);
        }

        private void PrintMassegeMenu(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
