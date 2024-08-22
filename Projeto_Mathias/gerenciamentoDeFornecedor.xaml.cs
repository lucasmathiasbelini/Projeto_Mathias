using System;
using Microsoft.Maui.Controls;

namespace Projeto_Mathias;
public partial class GerenciamentoDeFornecedor : ContentPage
{

    // Variáveis da classe
    String criterioSelecao;
    int id;
    String avaliacaoDesempenho;
    String analisar;

    public GerenciamentoDeFornecedor()
    {
        InitializeComponent();

    }

    ///*****************************************************************************************///
    /// <summary> Classe para definir o email </summary>
    public void setEmail(String email)
    {
        this.criterioSelecao = email;  // Corrigi a atribuição para o email
    }

    ///*****************************************************************************************///
    /// <summary> Classe para definir o ID </summary>
    public void setId(int id)
    {
        this.id = id;
    }

    ///*****************************************************************************************///
    /// <summary> Classe para obter o email </summary>
    public String getEmail()
    {
        return this.criterioSelecao;  // Ajustado para retornar o email correto
    }

    ///*****************************************************************************************///
    /// <summary> Classe para definir a avaliação de desempenho </summary>
   

    ///*****************************************************************************************///
    /// <summary> Classe para obter a avaliação de desempenho </summary>


    ///*****************************************************************************************///
    /// <summary> Classe para definir a análise </summary>
 

    ///*****************************************************************************************///
    /// <summary> Classe para obter a análise </summary>
   

    private void OnGerenciamentoFornecedorClicked(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }

    private void OnEditarMateriaisClicked(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }

}
