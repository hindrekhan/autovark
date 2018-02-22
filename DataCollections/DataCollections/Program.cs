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
