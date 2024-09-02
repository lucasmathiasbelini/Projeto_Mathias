using System;
using Controles;
using Microsoft.Maui.Controls;
using Projeto_Mathias.Modelos;

namespace Projeto_Mathias;
public partial class gerenciamentoDeFornecedor : ContentPage
{
    Cu cu;
    CuControle cuControle;

    public gerenciamentoDeFornecedor()
    {
        InitializeComponent();
        cu = new Cu();
        cuControle = new CuControle();
    }

    

    private void OnGerenciamentoFornecedorClicked(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }

    private void OnEditarMateriaisClicked(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }

}
