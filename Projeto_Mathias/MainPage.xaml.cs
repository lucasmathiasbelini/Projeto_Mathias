using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
     	 private void OnMenuClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroFornecedorPage();
        }
		 private void OnCadastroClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new gerenciamentoDeMaterial();
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            
			Application.Current.MainPage = new login();
        }

        private void OnTelaInicialClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new  DicionarFornecedor();
        }
        private void OnCadastroFuncionariosClicked(object sender, EventArgs e)
        {
            // Lógica para quando o botão "Cadastro Funcionários" for clicado
            DisplayAlert("Cadastro Funcionários", "Cadastro Funcionários Button Clicked", "OK");
        }
     
    }
}
