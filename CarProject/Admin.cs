using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class Admin
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public bool IsAdmin { get; set; }



        public static List<Admin> _Admin = new List<Admin>()
        {
            new Admin{Name = "admin", Id = 1, LastName = "admin", Login = "admin", Password = "admin", IsAdmin = true}
        };
        public static void RemoveUserByID(int iD)
        {

            var user = MainApp._Users.FirstOrDefault(i => i.Id == iD);
            foreach (var item in MainApp._Cars)
            {
                if (user.Id == item.Id)
                {
                    MainApp._Cars.Remove(item);
                }
            }
            MainApp._Users.Remove(user);


        }

    }
}
