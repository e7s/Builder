using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    class Director
    {
        AbstractBuilder builder;

        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
