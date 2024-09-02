using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class DicionarFornecedor : ContentPage
    {
        public DicionarFornecedor() // Corrigido para usar o nome correto do construtor
        {
            InitializeComponent();
        }
         public void SelecionarNaTelaFuncionarios(object sender, EventArgs e)
        {
            Application.Current.MainPage = new gerenciamentoDeMaterial();
        }
           public void Voltar (object sender, EventArgs e)
        {
            Application.Current.MainPage = new gerenciamentoDeMaterial();
        }
        public void QuandoSelecionarUmItemNaLista(object sender, EventArgs e)
        {
            //mathias da a bunda
        }
    }
}
