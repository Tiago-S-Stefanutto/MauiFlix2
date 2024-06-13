using MauiFlix.Filmes.acao;

namespace MauiFlix;

public partial class acao : ContentPage
{
	public acao()
	{
		InitializeComponent();
	}

    private void btnmissao_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new mission());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void btnjonh_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new jonh());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void btnmad_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new mad());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void btntop_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new topgun());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}