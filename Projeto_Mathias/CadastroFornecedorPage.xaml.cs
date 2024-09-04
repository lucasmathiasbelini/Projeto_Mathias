using Controles;
using Microsoft.Maui.Controls;
using Projeto_Mathias.Modelos;

namespace Projeto_Mathias
{
    public partial class CadastroFornecedorPage : ContentPage
    {

        public ForncedorControle forncedorControle = new ForncedorControle();
        public Modelos.Fornecedor fornecedor{get; set;}

        public CadastroFornecedorPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastro do fornecedor
            fornecedor.Nome = NomeEmpresaEntry.Text;
            fornecedor.Cnpj= CNPJEntry.Text;
            fornecedor.Telefone = DepartamentoEntry.Text;

            // Adicionar lógica para salvar os dados
            
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à tela anterior
              Application.Current.MainPage = new  MainPage();
        }
    }
}
