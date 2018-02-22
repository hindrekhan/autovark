using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var cars = new List<string>();

            var car1 = "BMW";
            var car2 = "Lada";
            var car3 = "Mercedes";
            var car4 = "Ferrari"; 
            var car5 = "Opel";
            var car6 = "Saab";

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);
            cars.Add(car6);
            
            foreach (var item in cars)
                Console.WriteLine(item);
            */
            /*
            var humans1 = new List<Human>
            {
                new Human(){ Name = "Kalle", Age = 20},
                new Human(){ Name = "Malle", Age = 21},
                new Human(){ Name = "Mari", Age = 30},
                new Human(){ Name = "Juku", Age = 17},
            };

            var human1 = new Human();
            human1.Name = "Priit";
            human1.Age = 25;
            humans1.Add(human1);

            while (true)
            {
                var human2 = new Human();
                Console.WriteLine("Sisestage nimi");
                human2.Name = Console.ReadLine();
                Console.WriteLine("Sisestage Vanus");
                human2.Age = int.Parse(Console.ReadLine());
                humans1.Add(human2);

                Console.WriteLine("Kas tahate veel sisestada(Y/N)");
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "N")
                    break;
            }

            foreach (var item in humans1)
                Console.WriteLine(item.Name + " " + item.Age);

            var openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine("for key = rtf, value = " + openWith["rtf"]);

            try
            {
                openWith.Add("txt", "word.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key txt already exists");
            }

            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value= {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found");
            }
            
            foreach(KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("kEY = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            foreach(string item in valueCollection)
            {
                Console.WriteLine("Value = {0}", item);
            }

            Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;
            foreach(var item in keyCollection)
            {
                Console.WriteLine("Key = {0}", item);
            }

            openWith.Remove("doc");
            if(!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }*/

            /*Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            foreach(string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            Console.WriteLine("Dequeing '{0}'", numbers.Dequeue());

            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());

            Console.WriteLine("Dequeueing '{0}'", numbers.Dequeue());

            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            Console.WriteLine("Contents of the first Copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            string[] array2 = new string[numbers.Count + 2];
            foreach(var item in array2)
            {
                Console.WriteLine(item);
            }*/

            /*Stack<string> numbers = new Stack<string>();

            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            foreach (var item in numbers)
            {
                Console.WriteLine("numbers");
            }*/

            /*var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age= 20},
                new Human(){Name = "Salle", Age= 21},
                new Human(){Name = "Lalle", Age= 22},
                new Human(){Name = "Ralle", Age= 23},
                new Human(){Name = "Aalle", Age= 24},
            };
            */
            /*var query = (from element in humans1
                         orderby element.Age descending
                        where element.Age > 20
                        select element).ToList();

            foreach( var item in query)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            */

            var cars = new List<Car>
            {
                new Car() {KW = 5, Producer = "BMW", Model = "M5", Color = "Gray"},
                new Car() {KW = 3, Producer = "BMW", Model = "M12", Color = "Pink"},
                new Car() {KW = 7, Producer = "BMW", Model = "M4", Color = "Green"},
                new Car() {KW = 4, Producer = "Peugeot", Model = "108", Color = "Purple"},
                new Car() {KW = 1, Producer = "Peugeot", Model = "208", Color = "Cyan"},
                new Car() {KW = 100, Producer = "Peugeot", Model = "208 GT Line", Color = "Blue"},
                new Car() {KW = 676, Producer = "Audi", Model = "A3", Color = "Green"},
                new Car() {KW = 35, Producer = "Audi", Model = "A4", Color = "White"},
                new Car() {KW = 53532525, Producer = "Volkswagen", Model = "Passat", Color = "Cyan"},
                new Car() {KW = 25241234, Producer = "Volkswagen", Model = "Atlas", Color = "Gold"},
            };

            // 1
            Console.WriteLine("KW Ascend:");

            var data1 = (from element in cars
                        orderby element.KW ascending
                        select element.KW
                       ).ToList();

            foreach (var i in data1)
                Console.WriteLine(i);

            Console.WriteLine();

            //2
            Console.WriteLine("Contains 'o':");

            var data2 = (from element in cars
                        where element.Producer.Contains("o")
                        select element.Producer).ToList();

            foreach (var i in data2)
                Console.WriteLine(i);

            Console.WriteLine();

            //3
            Console.WriteLine("Contains 'e':");

            var data3 = (from element in cars
                         where element.Producer.Contains('e')
                         select element.Producer).ToList();

            foreach (var i in data3)
                Console.WriteLine(i);

            Console.WriteLine();

            //4
            Console.WriteLine("More than 4 letters:");

            var data4 = (from element in cars
                         where element.Model.Count() > 4
                         
                         select element.Model);

            foreach (var i in data4)
                Console.WriteLine(i);

            Console.WriteLine();

            //5
            Console.WriteLine("Most powerful:");

            var data5 = (from element in cars
                         orderby element.KW descending
                         select element).ElementAt(0);

            Console.WriteLine(data5.Producer + ", " + data5.Model);

            var data6 = (from element in cars
                         orderby element.KW ascending
                         select element).ElementAt(0);

            Console.WriteLine();
            Console.WriteLine("Least powerful:");
            Console.WriteLine(data6.Producer + ", " + data6.Model);

            Console.ReadLine();
        }
    }
}
