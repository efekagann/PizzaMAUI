namespace PizzaMAUI.ViewModels
{
    [QueryProperty(nameof(FromShearch), nameof(FromShearch))]
    public partial class AllPizzaViewModel : ObservableObject
    {
        private readonly PizzaService _pizzaService;

        public AllPizzaViewModel(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
            Pizzas = new(_pizzaService.GetAllPizzas());
        }
        public ObservableCollection<Pizza> Pizzas { get; set; }

        [ObservableProperty]
        private bool _fromShearch;

        [ObservableProperty]
        private bool _searching;

        [RelayCommand]
        private async Task ShearchPizzas(string searchTerm)
        {
            Pizzas.Clear();
            Searching = true;
            foreach (var pizza in _pizzaService.SearchPizzas(searchTerm))
            {
                Pizzas.Add(pizza);

                Searching = false;
            }
        }
    }
}
