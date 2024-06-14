using MauiFlix.Filmes.animacao;
using MauiFlix.Filmes.aventura;

namespace MauiFlix;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}

    private void bntjumanji_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new jumanji());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void bntuncharted_Cliked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new uncharted());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void bntsenhorda_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SdA());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void bntviagem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new viagem());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}