using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class MainApp
    {

        public static List<User> _Users = new List<User>()
        {

        };

        public static List<Car> _Cars = new List<Car>()
        {

        };
        public static List<Car> _SoldCars = new List<Car>()
        {

        };
        public static void PrintUsers()
        {
            foreach (var item in _Users)
            {
                Console.WriteLine(item);
            }
        }
        public static void Registration()
        {
            User user = new User();
            Console.Write("Enter your Name: ");
            user.Name = Console.ReadLine();
            Console.Write("enter your Last Name: ");
            user.LastName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            user.PhoneNumber = Console.ReadLine();
            bool check = true;
            while (check)
            {
                Console.Write("Enter Mail: ");
                user.Login = Console.ReadLine();
                Console.Write("Enter Password: ");
                user.Password = Console.ReadLine();

                int count = 0;
                for (int i = 0; i < _Users.Count; i++)
                {
                    count++;
                }
                if (count != 0)
                {
                    foreach (var item in _Users)
                    {


                        if (item.Login == user.Login && item.Password == user.Password || item.Login == user.Login && item.Password != user.Password)
                        {
                            Console.WriteLine("There is already an account on this mail. Please Enter Another Mail");
                            Registration();
                        }
                        else if (item.Login != user.Login && item.Password == user.Password || item.Login != user.Login && item.Password != user.Password)
                        {
                            check = false;
                        }
                    }
                }
                else if (count == 0)
                {
                    check = false;
                }

            }
            _Users.Add(user);

            int id = 0;
            for (int i = 0; i < _Users.Count; i++)
            {
                id = i + 1;
            }
            user.Id = id;
        }
        public static void SignIn()
        {
            Console.Write("Enter Mail: ");
            string log = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            foreach (var item in _Users)
            {
                if (item.Login == log && item.Password == password && item.IsAdmin != true)
                {
                    bool again = true;
                    while (true)
                    {


                        Console.WriteLine("1: Add Car 2: Show Car 3: Show My Statement 4: Deposit 5:Show My Cars 6: Exit");
                        switch (Console.ReadLine())
                        {
                            case "1":

                                Car car = new Car();
                                Console.Write("Enter Car Name: ");
                                car.Mark = Console.ReadLine();
                                Console.Write("Enter Car Model: ");
                                car.Model = Console.ReadLine();
                                Console.Write("Enter Car Color: ");
                                car.Color = Console.ReadLine();
                                Console.Write("Enter Car ExpireDate: ");
                                car.Year = Console.ReadLine();
                                Console.Write("Enter Car Price: ");
                                car.Price = int.Parse(Console.ReadLine());
                                Console.Write("Enter Car VIN Code: ");
                                car.VINCode = Console.ReadLine();
                                car.Id = item.Id;
                                UserControlPanel.AddCar(car);
                                break;



                            case "2":
                                again = true;
                                while (again)
                                {
                                    UserControlPanel.PrintCar();
                                    Console.WriteLine("1.buy 2.filter 3.Back In Menu");
                                    Console.Write("Choose: ");
                                    int chose = Convert.ToInt32(Console.ReadLine());
                                    if (chose == 1)
                                    {
                                        UserControlPanel.BuyCar(item);
                                    }
                                    else if (chose == 2)
                                    {
                                        UserControlPanel.PrintFilterMenu();
                                    }
                                    else if (chose == 3)
                                    {
                                        again = false;
                                    }
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            UserControlPanel.FilterByMark();
                                            Console.WriteLine("1.buy  2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose = Convert.ToInt32(Console.ReadLine());
                                            if (choose == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose == 2)
                                            {
                                                again = false;
                                            }

                                            break;
                                        case "2":
                                            UserControlPanel.FilterByMarkAndModel();
                                            Console.WriteLine("1.buy 2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose1 = Convert.ToInt32(Console.ReadLine());
                                            if (choose1 == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose1 == 2)
                                            {
                                                again = false;
                                            }
                                            break;
                                        case "3":
                                            UserControlPanel.FilterByPrice();
                                            Console.WriteLine("1.buy 2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose2 = Convert.ToInt32(Console.ReadLine());
                                            if (choose2 == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose2 == 2)
                                            {
                                                again = false;
                                            }
                                            break;
                                        case "4":
                                            UserControlPanel.FilterByYear();
                                            Console.WriteLine("1.buy 2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose3 = Convert.ToInt32(Console.ReadLine());
                                            if (choose3 == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose3 == 2)
                                            {
                                                again = false;
                                            }
                                            break;
                                        case "5":
                                            UserControlPanel.FilterByMarkAndYear();
                                            Console.WriteLine("1.buy 2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose4 = Convert.ToInt32(Console.ReadLine());
                                            if (choose4 == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose4 == 2)
                                            {
                                                again = false;
                                            }
                                            break;
                                        case "6":
                                            UserControlPanel.FilterByMarkModelAndYear();
                                            Console.WriteLine("1.buy 2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose5 = Convert.ToInt32(Console.ReadLine());
                                            if (choose5 == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose5 == 2)
                                            {
                                                again = false;
                                            }
                                            break;
                                        case "7":
                                            UserControlPanel.FilterByMarkModelAndPrice();
                                            Console.WriteLine("1.buy 2.Back In Menu");
                                            Console.WriteLine("choose: ");
                                            int choose6 = Convert.ToInt32(Console.ReadLine());
                                            if (choose6 == 1)
                                            {
                                                UserControlPanel.BuyCar(item);
                                            }
                                            else if (choose6 == 2)
                                            {
                                                again = false;
                                            }
                                            break;
                                        case "8":
                                            again = false;
                                            break;



                                    }


                                }
                                break;
                            case "3":
                                bool check = true;
                                while (check)
                                {
                                    UserControlPanel.PrintMyStatements(item);
                                    Console.WriteLine("1:Remove Car 2:Update Car 3: Menu");
                                    int choose = Convert.ToInt32(Console.ReadLine());
                                    if (choose == 1)
                                    {
                                        Console.Write("Enter The VIN Code Of The Car You Want To Delete: ");
                                        UserControlPanel.RemoveCarByWinCode(item);
                                    }
                                    else if (choose == 2)
                                    {
                                        Console.Write("Enter The VIN Code Of The Car You Want To Update: ");
                                        UserControlPanel.UpdateCarByWinCode(item);
                                    }
                                    else if (choose == 3)
                                    {
                                        check = false;
                                    }
                                }
                                break;

                            case "4":
                                UserControlPanel.Deposit();
                                break;
                            case "5":
                                UserControlPanel.ShowMyCars();
                                break;


                            case "6":
                                StartMenu();

                                break;

                        }

                    }
                }
                else if (item.Login == log && item.Password != password && item.IsAdmin != true ||
                      item.Login != log && item.Password == password && item.IsAdmin != true ||
                      item.Login != log && item.Password != password && item.IsAdmin != true)
                {
                    Console.WriteLine("Mail or Password is wrong :( try again");
                }

            }
            foreach (var item1 in Admin._Admin)
            {
                if (item1.Login == log && item1.Password == password && item1.IsAdmin == true)
                {
                    AdminControlPanel.AdminStartMenu();
                }
            }
            SignIn();
        }

        public static void StartMenu()
        {
            Console.WriteLine("1.Sign In  2.Sign Up");
            Console.Write("Enter your choise: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                SignIn();
            }
            else if (choose == 2)
            {
                Registration();
                StartMenu();
            }
        }

    }
}
