using Microsoft.Maui.Controls;
using Models;
using Services;

namespace Views
{
    public partial class PAGEEEE : ContentPage
    {
        public PAGEEEE()
        {
            InitializeComponent();

            lstSaltyFood.ItemsSource = FoodsService.GetSaltyFood();
            lstDesserts.ItemsSource = FoodsService.GetDesserts();
        }

        async void GridArea_Tapped(System.Object sender, System.EventArgs e)
        {

        }

        async void Food_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new FoodDetailsPage(e.CurrentSelection.First() as Food));
        }      
    }
}
