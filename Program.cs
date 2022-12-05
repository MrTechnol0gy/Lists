using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {     
        static void Main(string[] args)
        {

        }
        static void PickUp()
        {

        }
        static void Drop() 
        {

        }
        static void Use()
        {

        }
        static void ClearInventory()
        {

        }
        static void ShowInventory()
        {
            List<int> list = new List<int>();

            list.Add(4);
            list.Add(5);
            list.Add(6);

            list.Remove(5);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            Console.ReadKey();
        }
    }
}
