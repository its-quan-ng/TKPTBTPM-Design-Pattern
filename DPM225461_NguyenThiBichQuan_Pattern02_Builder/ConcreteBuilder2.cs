
namespace DPM225461_NguyenThiBichQuan__Pattern02_Builder
{
    class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("Part X");
        }

        public override void BuildPartB()
        {
            _product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
