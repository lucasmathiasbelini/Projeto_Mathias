using Microsoft.Maui.Controls;

namespace Projeto_Mathias
{
    public partial class gerenciamentoDeMaterial: ContentPage
    {
        public gerenciamentoDeMaterial()
        {
            InitializeComponent();
        }

        public void botao2(object sender, EventArgs e)
        {
            Application.Current.MainPage = new gerenciamentoDeFornecedor();
        }

        public void OnEditarMateriaisClicked(object sender, EventArgs e)
        {
            //aaaaaaaaaaa
        }
    }
}
