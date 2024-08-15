using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class gerenciamentoEstoque : ContentPage
    {
        public gerenciamentoEstoque()
        {
            InitializeComponent();
        }

        // Evento para o botão "Gerenciamento de fornecedor"
        private void OnGerenciamentoFornecedorClicked(object sender, EventArgs e)
        {
            // Mostrar ou ocultar as seções conforme necessário
            FornecedorSection.IsVisible = true;
            MateriasSection.IsVisible = false;
            EstoqueSection.IsVisible = false;
        }

        // Evento para o botão "Gerenciamento de matérias"
        private void OnGerenciamentoMateriasClicked(object sender, EventArgs e)
        {
            // Mostrar ou ocultar as seções conforme necessário
            FornecedorSection.IsVisible = false;
            MateriasSection.IsVisible = true;
            EstoqueSection.IsVisible = false;
        }

        // Evento para o botão "Gerenciamento de estoque"
        private void OnGerenciamentoEstoqueClicked(object sender, EventArgs e)
        {
            // Mostrar ou ocultar as seções conforme necessário
            FornecedorSection.IsVisible = false;
            MateriasSection.IsVisible = false;
            EstoqueSection.IsVisible = true;
        }
    }
}
