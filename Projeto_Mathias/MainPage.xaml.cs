using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
     	 private async void OnMenuClicked(object sender, EventArgs e)
        {
            // Navegar para a página Menu (se você tiver uma página Menu)
			  DisplayAlert("Login gerenciamento de fornecedor", "", "OK");
            await Navigation.PushAsync(new CadastroFornecedorPage());
        }l
		 private async void OnCadastroClicked(object sender, EventArgs e)
        {
            // Navegar para a página Menu (se você tiver uma página Menu)
			  DisplayAlert("Gerenciamento fornecedor", "", "OK");
            await Navigation.PushAsync(new gerenciamentoDeMaterial());
        }
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão "Cadastro" for clicado
            DisplayAlert("Cadastro", "Cadastro Button Clicked", "OK");
			await Navigation.PushAsync(new CadastroFornecedorPage());
        }

        private void OnTelaInicialClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão "Tela Inicial" for clicado
            DisplayAlert("Tela Inicial", "Tela Inicial Button Clicked", "OK");
        }

        private void OnAdicionarDividasClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão "Adicionar Dívidas" for clicado
            DisplayAlert("Adicionar Dívidas", "Adicionar Dívidas Button Clicked", "OK");
        }

        private void OnCadastroFuncionariosClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão "Cadastro Funcionários" for clicado
            DisplayAlert("Cadastro Funcionários", "Cadastro Funcionários Button Clicked", "OK");
        }
    }
}
