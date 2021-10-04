using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {

            CollectionBase array = new Array();
            IList list = new List();
            var result = list.Add(2); // works

          //  array(3); // throw exception

            Console.WriteLine("Answer " + result);
        }
    }



    public interface IList
    {
        int Add(int number1);
    }

    public class CollectionBase
    {
        public int Count { get; set; }
    }

    public class List : CollectionBase, IList
    {
        public int Add(int number1)
        {
            // add item to list

            return number1 * 2;
        }
    }

    public class Array : CollectionBase
    {
    }

}
