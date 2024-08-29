using LiteDB;

namespace Projeto_Mathias.Modelos;

public class Cu : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Material { get; set; }
}