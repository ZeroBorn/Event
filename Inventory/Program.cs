using System;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Valoday","Kosarev");
            person.PropertyChanged += Rename;
            person.FirstName = "Pavel";
            person.LastName = "Ignatchenko";
        }

        static void Rename(object sender,PropertyChangedEventArgs e)
        {
            Console.Write($" {e.PropertyName} was be changed."+
                              $"\nPreviois value: {e.PreviosValue}"+
                              $"\nNew value: {e.NewValue}");
        }
    }
}
