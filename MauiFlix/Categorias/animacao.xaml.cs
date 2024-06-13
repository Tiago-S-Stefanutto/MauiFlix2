using MauiFlix.Filmes.animacao;

namespace MauiFlix;

public partial class animacao : ContentPage
{
	public animacao()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void dragonbtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new dragon());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void bntaranha_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new homenaranha());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void carrosbnt_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new carros());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void up_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new up());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

}