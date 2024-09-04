using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }
        // Aqui você pode adicionar manipuladores de eventos para os botões
       
        public void botao1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new gerenciamentoDeFornecedor();
        }

        private void OnTenhoUmaContaClicked(object sender, EventArgs e)
        {
            // Ação ao clicar em "Tenho uma conta"
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Ação ao clicar em "Cadastrar-se"
        }

        private void OnGoogleClicked(object sender, EventArgs e)
        {
            // Ação ao clicar no botão "Google"
        }

        private void OnFacebookClicked(object sender, EventArgs e)
        {
            // Ação ao clicar no botão "Facebook"
        }
    }
}
