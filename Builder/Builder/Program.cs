using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new ConcreteBuilder();

            Director director = new Director(builder);
            director.Construct();

            Product product = builder.GetResult();
            product.Show();

            Console.ReadLine();
        }
    }
}
