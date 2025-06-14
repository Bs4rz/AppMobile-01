namespace AppCadastro;

public partial class CadastroProdutoPage : ContentPage
{
    public CadastroProdutoPage()
    {
        InitializeComponent();
    }

    private void btnConcluirCadastro_Clicked(object sender, EventArgs e)
    {
        var novoProduto = new Produtos.Produto
        {
            nomeProd = nomeProd.Text,
            descProd = descProd.Text,
            categoriaProd = categoriaProd.Text,
            precoProd = decimal.Parse(precoProd.Text)
        };

        AppData.Produtos.Add(novoProduto);

        DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "OK");

        nomeProd.Text = "";
        descProd.Text = "";
        categoriaProd.Text = "";
        precoProd.Text = "";
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
