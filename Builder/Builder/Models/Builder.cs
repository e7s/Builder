using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    abstract class AbstractBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }

    class ConcreteBuilder : AbstractBuilder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
