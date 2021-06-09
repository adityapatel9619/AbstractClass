using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
  abstract  class Shape
    {
        public int lenght, width;
        public void set(int a = 0,int b = 0)
        {
            lenght = a;
            width = b;
        }
        public abstract int Area();
    }

    class rectangle : Shape
    {
        public override int Area()
        {
            return (lenght * width);
        }
    }
}
