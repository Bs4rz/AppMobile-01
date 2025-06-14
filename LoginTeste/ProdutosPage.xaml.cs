using LoginTeste;

namespace AppCadastro;

public partial class ProdutosPage : ContentPage
{
    public ProdutosPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        listaProdutosView.ItemsSource = null;
        listaProdutosView.ItemsSource = AppData.Produtos;
    }

    private async void btnVoltar_Clicked2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
