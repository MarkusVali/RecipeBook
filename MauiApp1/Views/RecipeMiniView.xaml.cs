using Models;

namespace Views;

public partial class RecipeMiniView : ContentPage
{
	public RecipeMiniView(Food food)
	{
		InitializeComponent();

        this.BindingContext = food;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}