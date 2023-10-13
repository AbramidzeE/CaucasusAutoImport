using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CarProject
{
    internal class UserControlPanel
    {
        public static void AddCar(Car c)
        {
            MainApp._Cars.Add(c);
        }
        public static void PrintMyStatements(User user)
        {
            foreach (var item in MainApp._Cars)
            {
                if (user.Id == item.Id)
                {
                    Console.WriteLine(item);
                }
            }
        }


        // გვჭირდება NullReferenceException

        public static void RemoveCarByWinCode(User user)
        {
            Console.Write("Enter Car VinCode: ");
            string WinCode = Console.ReadLine();
            var car = MainApp._Cars.Find(c => c.VINCode == WinCode);
            if (user.Id == car.Id)
            {
                MainApp._Cars.Remove(car);
            }
            else if (user.Id != car.Id)
            {
                Console.WriteLine("Car Not Found :(");
            }
            else if (car == null)
            {
                Console.WriteLine("Car Not Found :(");
            }
        }

        // გვჭირდება NullReferenceException

        public static void UpdateCarByWinCode(User user)
        {
            try
            {
                Console.Write("Enter WinCode: ");
                string winCode = Console.ReadLine();
                var find = MainApp._Cars.Find(i => i.VINCode == winCode);  
                if (user.Id == find.Id)
                {
                    Console.Write("Enter the data you want to update: ");

                    Console.Write("Enter Car Name: ");
                    find.Mark = Console.ReadLine();
                    Console.Write("Enter Car Model: ");
                    find.Model = Console.ReadLine();
                    Console.Write("Enter Car Color: ");
                    find.Color = Console.ReadLine();
                    Console.Write("Enter Car ExpireDate: ");
                    find.Year = Console.ReadLine();
                    Console.Write("Enter Car Price: ");
                    find.Price = int.Parse(Console.ReadLine());
                }
                else if (user.Id != find.Id)
                {
                    Console.WriteLine("Car Not Found :( ");
                }
                else if (find == null)
                {
                    Console.WriteLine("Car Not Found :( ");
                }

            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }





    public static void Deposit()
    {

        Console.Write("Enter Money: ");
        int money = int.Parse(Console.ReadLine());

        foreach (var item in MainApp._Users)
        {
            item.Balance += money;
        }
    }
    public static void FilterByMark()
    {
        Console.Write("Enter Mark: ");
        string mark = Console.ReadLine().ToLower();
        var result = MainApp._Cars.Where(c => c.Mark == mark).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }
    public static void FilterByMarkAndModel()
    {
        Console.Write("Enter Mark: ");
        string mark = Console.ReadLine().ToLower();
        Console.Write("Enter Model");
        string model = Console.ReadLine().ToLower();
        var result = MainApp._Cars.Where(c => c.Mark == mark && c.Model == model).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static void FilterByPrice()
    {
        Console.Write("Enter Price: ");
        int price = int.Parse(Console.ReadLine());

        var result = MainApp._Cars.Where(c => c.Price == price).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
    public static void FilterByYear()
    {
        Console.Write("Enter Year: ");
        string year = Console.ReadLine().ToLower();

        var result = MainApp._Cars.Where(c => c.Year == year).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static void FilterByMarkAndYear()
    {
        Console.Write("Enter Mark: ");
        string mark = Console.ReadLine().ToLower();
        Console.Write("Enter Year: ");
        string year = Console.ReadLine().ToLower();


        var result = MainApp._Cars.Where(c => c.Mark == mark && c.Year == year).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
    public static void FilterByMarkModelAndYear()
    {
        Console.Write("Enter Mark: ");
        string mark = Console.ReadLine().ToLower();
        Console.Write("Ente Model: ");
        string model = Console.ReadLine().ToLower();
        Console.Write("Enter Year: ");
        string year = Console.ReadLine().ToLower();


        var result = MainApp._Cars.Where(c => c.Mark == mark && c.Model == model && c.Year == year).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static void FilterByMarkModelAndPrice()
    {
        Console.Write("Enter Mark: ");
        string mark = Console.ReadLine().ToLower();
        Console.Write("Ente Model: ");
        string model = Console.ReadLine();
        Console.Write("Enter Price: ");
        int price = int.Parse(Console.ReadLine());


        var result = MainApp._Cars.Where(c => c.Mark == mark && c.Model == model && c.Price == price).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static void PrintFilterMenu()
    {
        Console.WriteLine("1: Filter Cars By mark 2: Filter Cars By Mark and Model 3: Filter Cars by the price " +
           "4: Filter Cars By year  5: Filter Cars By Mark and year  6: Filter Cars By Mark, Model and year" +
           " 7: Filter Cars By Mark, Model and price 8.Back In Menu");
    }

    public static void ShowMyCars()
    {
        foreach (var item in MainApp._SoldCars)
        {
            Console.WriteLine(item);
        }
    }
    public static void BuyCar(User user)
    {
        Console.Write("Enter VINcode: ");
        string vincode = Console.ReadLine();
        var find = MainApp._Cars.Find(c => c.VINCode == vincode);
        if (user.Id == find.Id)
        {
            Console.WriteLine("Thats Car Already Your.");
        }
        if (user.Balance >= find.Price)
        {
            find.Id = user.Id;
            user.Balance -= find.Price;
            MainApp._SoldCars.Add(find);

        }
        else
        {
            Console.WriteLine("Not Enough Money :(");
        }

    }


    public static void PrintCar()
    {
        foreach (var item in MainApp._Cars)
        {
            Console.WriteLine(item);
        }
    }
}
}
