
namespace Design_Patterns.Decorator
{
    using System;

    /// <summary>
    /// Order pizza with added features 
    /// </summary>
    public class OrderPizza
    {
        /// <summary>
        /// Orders the pizza
        /// </summary>
        public void Order()
        {
            ////Order basic pizza with non vegetarian feature
            IPizza nonVegPizza = new NonVegPizza(new DefaultPizza());
            nonVegPizza.MakePizza();
            Console.WriteLine("\n-----------------------------");

            ////Order basic non vegetarian pizza with extra topping
            IPizza nonVegTopping = new NonvegPizzaExtraAdding(new NonVegPizza(new DefaultPizza()));
            nonVegTopping.MakePizza();
        }
    }
}
