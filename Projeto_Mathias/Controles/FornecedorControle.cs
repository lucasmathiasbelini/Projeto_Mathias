using Projeto_Mathias.Modelos;

namespace Controles;

public class ForncedorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ForncedorControle() : base()
  {
    NomeDaTabela = "Fornecedor";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idForncedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idForncedor);
  }

  //----------------------------------------------------------------------------

  public virtual List<Fornecedor>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return new List<Fornecedor>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idForncedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Delete(idForncedor);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Fornecedor fornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Upsert(fornecedor);
  }

  //----------------------------------------------------------------------------
}