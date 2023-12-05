namespace ShopingApp.View;

public partial class LaptopPage : ContentPage
{
	public LaptopPage()
	{
		InitializeComponent();
	}

   

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Laptop1DetailPage());
    }
}