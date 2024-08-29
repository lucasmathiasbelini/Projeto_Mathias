using Projeto_Mathias.Modelos;

namespace Controles;

public class CuControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CuControle() : base()
  {
    NomeDaTabela = "Cu";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCu)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCu);
  }

  //----------------------------------------------------------------------------

  public virtual List<Cu>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cu>(NomeDaTabela);
    return new List<Cu>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCu)
  {
    var collection = liteDB.GetCollection<Cu>(NomeDaTabela);
    collection.Delete(idCu);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cu cu)
  {
    var collection = liteDB.GetCollection<Cu>(NomeDaTabela);
    collection.Upsert(cu);
  }

  //----------------------------------------------------------------------------
}