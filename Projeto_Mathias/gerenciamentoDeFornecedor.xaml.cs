namespace Projeto_Mathias;
public class GerenciamentoFornecedor {

    // Variáveis da classe
    String criterioSelecao;
    int id;
    String avaliacaoDesempenho;
    String analisar;

    ///*****************************************************************************************///
    /// <summary> Classe para definir o email </summary>
    public void setEmail(String email) {
        this.criterioSelecao = email;  // Corrigi a atribuição para o email
    }

    ///*****************************************************************************************///
    /// <summary> Classe para definir o ID </summary>
    public void setId(int id) {
        this.id = id;
    }

    ///*****************************************************************************************///
    /// <summary> Classe para obter o email </summary>
    public String getEmail() {
        return this.criterioSelecao;  // Ajustado para retornar o email correto
    }

    ///*****************************************************************************************///
    /// <summary> Classe para definir a avaliação de desempenho </summary>
    public void setAvaliacaoDesempenho(String avaliacaoDesempenho) {
        this.avaliacaoDesempenho = avaliacaoDesempenho;
    }

    ///*****************************************************************************************///
    /// <summary> Classe para obter a avaliação de desempenho </summary>
    public String getAvaliacaoDesempenho() {
        return this.avaliacaoDesempenho;
    }

    ///*****************************************************************************************///
    /// <summary> Classe para definir a análise </summary>
    public void setAnalisar(String analisar) {
        this.analisar = analisar;
    }

    ///*****************************************************************************************///
    /// <summary> Classe para obter a análise </summary>
    public String getAnalisar() {
        return this.analisar;
    }
    private void OnEditarMateriaisClicked(object sender, EventArgs args) {

    }

}
