using System;

namespace DecoratorDesignPattern
{
    //base interface
    interface Pizza
    {
        void getPizza();
    }
    //concrete implementation
    class MyPizza:Pizza
    {
        public void getPizza()
        {
            Console.WriteLine("This is a simple pizza");
        }
    }
    //base decorator class
    class PizzaDecorator:Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(Pizza p)
        {
            this.pizza = p;
        }
        public virtual void getPizza()
        {
             pizza.getPizza();
        }
    }
    class CheeseDecorator:PizzaDecorator
    {
        public CheeseDecorator(Pizza p) : base(p) { }
        public override void getPizza()
        {
            base.getPizza();
            Console.WriteLine("with extra cheeese");
        }
    }
    class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(Pizza p) : base(p) { }
        public override void getPizza()
        {
            base.getPizza();
            Console.WriteLine("with extra tomatoes");
        }
    }
    class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(Pizza p) : base(p) { }
        public override void getPizza()
        {
            base.getPizza();
            Console.WriteLine("with extra onions");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Pizza p = new MyPizza();
            //p.getPizza();
            Pizza p = new TomatoDecorator(new OnionDecorator(new MyPizza()));
            //Pizza p = new TomatoDecorator(new CheeseDecorator(new MyPizza()));
            p.getPizza();

            //Pizza tomatoPizza = new TomatoDecorator(new MyPizza());
            //tomatoPizza.getPizza();

        }
    }
}
