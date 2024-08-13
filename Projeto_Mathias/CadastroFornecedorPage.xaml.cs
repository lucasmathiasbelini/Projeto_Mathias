using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class CadastroFornecedorPage : ContentPage
    {
        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastro do fornecedor
            string nomeEmpresa = NomeEmpresaEntry.Text;
            string cnpj = CNPJEntry.Text;
            string departamento = DepartamentoEntry.Text;
            string pais = PaisEntry.Text;
            string cidade = CidadeEntry.Text;
            string cep = CEPEntry.Text;
            string telefone = TelefoneEntry.Text;

            // Adicionar lógica para salvar os dados
            await DisplayAlert("Cadastro", "Fornecedor cadastrado com sucesso!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à tela anterior
            await Navigation.PopAsync();
        }
    }
}
