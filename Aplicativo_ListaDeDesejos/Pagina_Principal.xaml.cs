using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_ListaDeDesejos;

public partial class Pagina_Principal : ContentPage
{
    public Pagina_Principal()
    {
        InitializeComponent();
    }
    
    private async void Meuperfil (object sender, EventArgs e)
    {
        var Novapagina1 = new Meu_Perfil();
		
        await Navigation.PushAsync(Novapagina1);
            
		
    }
    
    private async void Listadedesejos (object sender, EventArgs e)
    {
        var Novapagina2 = new Lista_Desejos();
		
        await Navigation.PushAsync(Novapagina2);
            
		
    }
    
    private async void Meusamigos (object sender, EventArgs e)
    {
        var Novapagina3 = new Meus_Amigos();
		
        await Navigation.PushAsync(Novapagina3);
            
		
    }
}