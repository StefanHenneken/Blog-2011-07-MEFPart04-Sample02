using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using CarContract;

namespace CarHost
{
    class Program
    {
        [ImportMany(typeof(ICarContract))]
        private IEnumerable<Lazy<ICarContract, Dictionary<string, object>>> CarParts { get; set; }

        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {          
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            foreach (Lazy<ICarContract, Dictionary<string, object>> car in CarParts)
            {
                if (car.Metadata.ContainsKey("Name"))
                    Console.WriteLine(car.Metadata["Name"]);
                if (car.Metadata.ContainsKey("Color"))
                    Console.WriteLine(car.Metadata["Color"]);
                if (car.Metadata.ContainsKey("Price"))
                    Console.WriteLine(car.Metadata["Price"]);
                Console.WriteLine("");
            }

            foreach (Lazy<ICarContract> car in CarParts)
                Console.WriteLine(car.Value.StartEngine("Sebastian"));
            container.Dispose();
        }
    }
}
