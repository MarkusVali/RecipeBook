using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace Views
{
    public partial class retseptPage : ContentPage
    {
        bool isAnimating = false;

        public retseptPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (!isAnimating)
            {
                isAnimating = true;
                await AnimateImages();
                isAnimating = false;
            }
        }

        async Task AnimateImages()
        {
            while (true)
            {
                await Task.WhenAll(
                    imgToit.TranslateTo(10, 0, 3000),
                    imgBun.TranslateTo(10, 50, 3000),
                    imgMug.TranslateTo(-10, 0, 3000),
                    imgFry.TranslateTo(-10, -50, 3000),
                    imgChick.TranslateTo(10, -100, 3000),
                    imgSushi.TranslateTo(10, -50, 3000),
                    imgHot.TranslateTo(10, 20, 3000),
                    imgkokk.TranslateTo(-10, -50, 3000)
                );

                await Task.Delay(10);

                await Task.WhenAll(
                    imgToit.TranslateTo(-10, 0, 3000),
                    imgBun.TranslateTo(-10, -50, 3000),
                    imgMug.TranslateTo(10, 0, 3000),
                    imgFry.TranslateTo(10, 50, 3000),
                    imgChick.TranslateTo(-10, 50, 3000),
                    imgSushi.TranslateTo(-10, 50, 3000),
                    imgHot.TranslateTo(-10, -50, 3000),
                    imgkokk.TranslateTo(10, 50, 3000)
                );

                await Task.Delay(10);
            }
        }

        async void ExploreButton_Clicked(System.Object sender, System.EventArgs e)
                => Application.Current.MainPage = new NavigationPage(new PAGEEEE());
    }
}
