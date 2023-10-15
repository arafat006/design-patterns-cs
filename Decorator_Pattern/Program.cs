using Decorator_Pattern.Decorators;
using Decorator_Pattern.Products;

// We can add decorations as need maintaining sequence
IPizza pizza = new CapsicumPizza(new PepperoniPizza(new OnionPizza(new BasePizza())));
pizza.Prepare();

Console.WriteLine();

IPizza pizza2 = new PepperoniPizza(new OnionPizza(new CapsicumPizza(new BasePizza())));
pizza2.Prepare();

Console.WriteLine();

IPizza pizza3 = new OnionPizza(new PepperoniPizza(new BasePizza()));
pizza3.Prepare();

// It reduces class combinations of decorators
// We can now easily and freely use the combination with layering as needed