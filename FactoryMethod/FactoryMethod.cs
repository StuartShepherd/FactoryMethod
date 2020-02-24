namespace FactoryMethod
{
    // the creator class declares the factory method that is supposed to return an object of a product class. 
    // the creator's subclasses usually provides the implementation of this method.
    abstract class Creator
    {
        // note that the creator may also provide some default implementation of the factory method.
        public abstract IProduct FactoryMethod();

        // also note that, despite its name, the creator's primary responsibility is not creating products. 
        // usually, it contains some core business logic that relies on product objects, returned by the factory method. 
        // subclasses can indirectly change that business logic by overriding the factory method and returning a different type of product from it.
        public string SomeOperation()
        {
            // call the factory method to create a Product object.
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.Operation();
            return result;
        }
    }

    // concrete creators override the factory method in order to change the resulting product's type.
    class ConcreteCreator1 : Creator
    {
        // note that the signature of the method still uses the abstract product type, even though the concrete product is actually returned from the method. 
        // this way the creator can stay independent of concrete product classes.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    // the product interface declares the operations that all concrete products must implement.
    public interface IProduct
    {
        string Operation();
    }

    // concrete products provide various implementations of the product interface.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }       
}