using Models;

namespace Views;

public partial class FoodDetailsPage : ContentPage
{
	public FoodDetailsPage(Food food)
    {
        InitializeComponent();

        this.BindingContext = food;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    async void RecipeButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RecipeMiniView(BindingContext as Food));
    }
}