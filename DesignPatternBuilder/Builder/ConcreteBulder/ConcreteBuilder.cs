using System;

namespace DesignPatternBuilder
{
    class ConcreteBuilder : Builder
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

        public override Product GetResult()
        {
            return product;
        }
    }
}
