namespace PizzaMAUI.Services;

public class PizzaService
{
    private readonly static IEnumerable<Pizza> _pizzas = new List<Pizza>
    {
        new Pizza
        {
            Name="Pizza 1",
            Image="pizza1img.png",
            Price=5.1
        },
        new Pizza
        {
            Name="Pizza 2",
            Image="pizza2img.png",
            Price=2.5
        },
        new Pizza
        {
            Name="Pizza 3",
            Image="pizza3img.png",
            Price=3.6
        },
        new Pizza
        {
            Name="Pizza 4",
            Image="pizza4img.png",
            Price=4.3
        },
    };



    public IEnumerable<Pizza> GetAllPizzas() => _pizzas;

    public IEnumerable<Pizza> GetPopularPizzas(int count = 8) =>
        _pizzas.OrderBy(P => Guid.NewGuid())
        .Take(count);

    public IEnumerable<Pizza> SearchPizzas(string shearchTerm) =>
        string.IsNullOrWhiteSpace(shearchTerm)
        ? _pizzas
        : _pizzas.Where(p => p.Name.Contains(shearchTerm, StringComparison.OrdinalIgnoreCase));
}
