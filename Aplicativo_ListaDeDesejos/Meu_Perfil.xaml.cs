using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_ListaDeDesejos;

public partial class Meu_Perfil : ContentPage
{
    public Meu_Perfil()
    {
        InitializeComponent();
    }
    private async void editar (object sender, EventArgs e)
    {
        var Novapagina2 = new Editar_Perfil();
		
        await Navigation.PushAsync(Novapagina2);
            
		
    }
}