namespace ShopingApp.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

   
  

    private void laptosp_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LaptopPage());
    }

    private void compu_Clicked(object sender, EventArgs e)
    {

    }
}