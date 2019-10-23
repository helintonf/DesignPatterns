using System;
using System.Collections;
using System.Collections.Generic;

namespace InteratorCollection.Composto
{
    public class Menu : MenuComponent
    {
        public List<MenuComponent> MenuComponents { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Menu(string name, string description)
        {
            MenuComponents = new List<MenuComponent>();
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            MenuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            MenuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return MenuComponents[i];
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine("--------------");

            var enumerator = MenuComponents.GetEnumerator();

            while (enumerator.MoveNext() && enumerator.Current != null)
            {
                MenuComponent menuComponent = enumerator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator CreateIterator()
        {
            return new CompositeIterator(MenuComponents.GetEnumerator());
        }
    }
}