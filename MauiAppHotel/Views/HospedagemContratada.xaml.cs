namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Voltar (object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ContratacaoHospedagem());
    }
}