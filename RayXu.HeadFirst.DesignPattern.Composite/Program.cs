using RayXu.HeadFirst.DesignPattern.Composite.Abstract;
using RayXu.HeadFirst.DesignPattern.Composite.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponentInfo pancakeHouseMenu = new MenuInfo("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponentInfo dinerMenu = new MenuInfo("DINER MENU", "Lunch");
            MenuComponentInfo cafeMenu = new MenuInfo("CAFE MENU", "Dinner");
            MenuComponentInfo dessertMenu = new MenuInfo("DESSERT MENU", "Dessert of course!");

            MenuComponentInfo allMenus = new MenuInfo("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItemInfo("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
            pancakeHouseMenu.Add(new MenuItemInfo("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            pancakeHouseMenu.Add(new MenuItemInfo("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49));
            pancakeHouseMenu.Add(new MenuItemInfo("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));

            dinerMenu.Add(new MenuItemInfo("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.Add(new MenuItemInfo("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.Add(new MenuItemInfo("Soup of the day", "A bowl of the soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.Add(new MenuItemInfo("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));
            dinerMenu.Add(new MenuItemInfo("Steamed Veggies and Brown Rice", "A medly of steamed vegetables over brown rice", true, 3.99));
            dinerMenu.Add(new MenuItemInfo("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItemInfo("Apple Pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59));
            dessertMenu.Add(new MenuItemInfo("Cheesecake", "Creamy New York cheesecake, with a chocolate graham crust", true, 1.99));
            dessertMenu.Add(new MenuItemInfo("Sorbet", "A scoop of raspberry and a scoop of lime", true, 1.89));

            cafeMenu.Add(new MenuItemInfo("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99));
            cafeMenu.Add(new MenuItemInfo("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69));
            cafeMenu.Add(new MenuItemInfo("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29));

            WaitressInfo waitress = new WaitressInfo(allMenus);
            waitress.PrintMenu();

            Console.ReadLine();
        }
    }
}
