namespace Aplicativo_ListaDeDesejos.Classes;

public class Usuario
{
    public int IdUsuario { get; set; }
    //public int IdUsuario {get => idUsuario; set => idUsuario
    int idUsuario;
    string nome;
    string email;
    string senha;
    //lista de amigos
    List<Amigo> ListadDeAmigo;
    //lista de amigosfavoritos
    List<Favorito> ListadDeFavorito;
}
