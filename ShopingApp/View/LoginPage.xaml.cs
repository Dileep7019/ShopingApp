namespace ShopingApp.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async  void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new HomePage());

    }
}