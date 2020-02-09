using System;
using System.Collections;

namespace DesignPatternBuilder
{
    class Product
    {
        ArrayList list = new ArrayList();

        public void Add(string part)
        {
            list.Add(part);
        }

        public void Show()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
