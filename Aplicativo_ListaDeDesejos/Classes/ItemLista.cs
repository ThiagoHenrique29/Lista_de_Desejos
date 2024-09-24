using System.Reflection.Metadata;
namespace Aplicativo_ListaDeDesejos.Classes;

public class ItemLista
{
    public int IdItemLista { get; set; }
    Usuario usuario;
    string nome;
    string link;
    Blob image;
    bool amigosFavoritos;
    bool comentario;
}