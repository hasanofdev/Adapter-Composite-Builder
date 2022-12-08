public class Pizza
{
    public DoughType doughType { get; set; }
    public bool isRedPepper { get; set; }
    public Size size { get; set; }
    public CheeseType cheeseType { get; set; }
    public List<string> vegetables { get; set; }

    public void PizzaContent()
    {
        Console.WriteLine("Pizza with {0}", doughType);
        if (isRedPepper)
            Console.WriteLine("Red Pepper");
        Console.WriteLine("Size: {0}", size);
        Console.WriteLine("Cheese Type: {0}", cheeseType);
        Console.WriteLine("Vegetables:");
        foreach (var item in vegetables)
        {
            Console.WriteLine(" {0}", item);
        }
    }
}
public enum DoughType
{
    CirclePizza_Dough = 1,
    NewYorkStyle_Pizza_Dough = 2,
    SquarePan_Pizza_Dough = 3
}

public enum CheeseType
{
    American = 1,
    Swiss = 2,
}

public enum Size
{
    Small = 1,
    Medium = 2,
    Large = 3
}
public class MyPizzaBuilder
{
    Pizza pizza;

    public Pizza GetPizza()
    {
        return pizza;
    }

    public void CreatePizza()
    {
        pizza = new Pizza();

        PrepareDough();
        ApplyVegetables();
        ApplyCheese();
        AddCondiments();
    }

    private void AddCondiments()
    {
        pizza.isRedPepper = true;
    }

    private void ApplyCheese()
    {
        pizza.cheeseType = CheeseType.American;
    }

    private void ApplyVegetables()
    {
        pizza.vegetables = new List<string> { "Tomato", "Corn" };
    }

    private void PrepareDough()
    {
        pizza.doughType = DoughType.CirclePizza_Dough;
        pizza.size = Size.Large;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var builder = new MyPizzaBuilder();
        builder.CreatePizza();
        var pizza = builder.GetPizza();
        pizza.PizzaContent();
        Console.ReadKey();
    }

}