namespace PizzaMAUI.Pages;

public partial class AllPizzasPage : ContentPage
{
    private readonly AllPizzaViewModel _allPizzaViewModel;
    public AllPizzasPage(AllPizzaViewModel allPizzaViewModel)
    {
        InitializeComponent();
        BindingContext = _allPizzaViewModel = allPizzaViewModel;
    }


    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (_allPizzaViewModel.FromShearch)
        {
            await Task.Delay(100);
            searchBar.Focus();
        }
    }


    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.OldTextValue) && string.IsNullOrWhiteSpace(e.NewTextValue))
        {
            _allPizzaViewModel.SearchPizzasCommand.Execute(null);
        }
    }
}