namespace IosImageAspectFill;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Task.Run(async () =>
        {
            await Task.Delay(2000);
            Border.HeightRequest = 250;
            Border.WidthRequest = 250;
        });
    }
}