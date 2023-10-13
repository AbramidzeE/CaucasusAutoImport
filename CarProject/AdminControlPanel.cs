using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class AdminControlPanel
    {

        public static void AdminStartMenu()
        {
            foreach (var item in Admin._Admin)
            {
                Console.WriteLine("1.Print Users 2.Remove User 3.exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    MainApp.PrintUsers();
                }
                else if (choose == 2)
                {
                    Admin.RemoveUserByID(item.Id);
                }
                else if (choose == 3)
                {
                    MainApp.StartMenu();
                }
            }
        }

    }
}
