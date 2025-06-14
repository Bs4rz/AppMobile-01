using AppCadastro;

namespace LoginTeste
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            btnLogout.Text += " - " + Preferences.Default.Get("usuario", "");
        }

      
        

        private async void btnLogout_Clicked(object sender, EventArgs e)
        {
            Preferences.Default.Remove("usuario");

            await Shell.Current.GoToAsync("Login");
        }
        protected override bool OnBackButtonPressed() { return true; }

        private async void btnPagCadastro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroProdutoPage());
        }

        private async void btnProdutosPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdutosPage());
        }

    }

}
