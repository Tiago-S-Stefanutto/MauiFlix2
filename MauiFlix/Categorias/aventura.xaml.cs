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

    private void unchartedfilmbtn_Clicked(object sender, EventArgs e)
    {

    }

    private void tombfilmbtn_Clicked(object sender, EventArgs e)
    {

    }

    private void jurassicfilmbtn_Clicked(object sender, EventArgs e)
    {

    }
}