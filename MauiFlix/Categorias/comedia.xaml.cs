using MauiFlix.Filmes.aventura;
using MauiFlix.Filmes.comedia;

namespace MauiFlix;

public partial class comedia : ContentPage
{
	public comedia()
	{
		InitializeComponent();
	}

    private void bntbranquelas_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new branquelas());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void bntnorbit_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new norbit());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void vovozonabtnfiml_Clicked(object sender, EventArgs e)
    {

    }

    private void anjosbtnfiml_Clicked(object sender, EventArgs e)
    {

    }
}