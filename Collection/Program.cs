using InteratorCollection.Composto;
using System;

namespace Collection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");

            MenuComponent dinerMenu = new Menu("DINER MENU", "Breakfast");

            MenuComponent cafeMenu = new Menu("CAFÉ MENU", "Dinner");

            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            // acresentar os itens

            dinerMenu.Add(new InteratorCollection.Composto.MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
               3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new InteratorCollection.Composto.MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla ice cream",
                true,
               1.599));

            InteratorCollection.Composto.Waitress waitress = new InteratorCollection.Composto.Waitress(allMenus);

            waitress.PrintVegetarianMenu();
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= number;
                yield return result;
            }
        }

        public static void SortDucks()
        {
            Console.WriteLine("Hello Ducks!");

            Duck[] ducks = {
                new Duck() { Name = "Daffity", Weight = 8 },
                new Duck(){ Name = "Dewey", Weight = 2 },
                new Duck(){ Name = "Howard", Weight = 7 },
                new Duck(){ Name = "Louis", Weight = 2 },
                new Duck(){ Name = "Donald", Weight = 10 },
                new Duck(){ Name = "Huey", Weight = 2 }
            };

            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("Ducks organizados!");

            Display(ducks);
        }

        public static void Display(params Duck[] ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.ToString());
            }
        }
    }
}