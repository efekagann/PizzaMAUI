namespace PizzaMAUI.Pages;

public partial class AllPizzasPage : ContentPage
{
    private readonly AllPizzaViewModel _allPizzaViewModel;
    public AllPizzasPage(AllPizzaViewModel allPizzaViewModel)
    {
        InitializeComponent();
        BindingContext = _allPizzaViewModel = allPizzaViewModel;
    }
}