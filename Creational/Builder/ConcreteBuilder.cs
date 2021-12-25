namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new();

        public ConcreteBuilder() => Reset();

        public void Reset()
        {
            _product = new Product();
        }

        // All production steps work with the same product instance.
        public void BuildPartA() => _product.Add("PartA1");
        public void BuildPartB() => _product.Add("PartB1");
        public void BuildPartC() => _product.Add("PartC1");

        public Product GetProduct()
        {
            Product result = _product;
            Reset();

            return result;
        }
    }
}