namespace PizzaMAUI.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    private readonly PizzaService _pizzaService;
    public HomeViewModel(PizzaService pizzaService)
    {
        _pizzaService = pizzaService;
        Pizzas = new(_pizzaService.GetPopularPizzas());
    }

    public ObservableCollection<Pizza> Pizzas { get; set; }


}
