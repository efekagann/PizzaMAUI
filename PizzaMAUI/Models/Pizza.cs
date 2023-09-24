using CommunityToolkit.Mvvm.ComponentModel;

namespace PizzaMAUI.Models;

public partial class Pizza : ObservableObject
{
    public string Name { get; set; }
    public string Image { get; set; }
    public double Price { get; set; }

    [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
    private int _cardQuantity;

    public double Amount => CardQuantity * Price;
    public Pizza Clone() => MemberwiseClone() as Pizza;
}
