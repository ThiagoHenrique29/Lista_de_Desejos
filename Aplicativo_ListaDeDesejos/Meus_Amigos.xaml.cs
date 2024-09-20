using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_ListaDeDesejos;

public partial class Meus_Amigos : ContentPage
{
    public Meus_Amigos()
    {
        InitializeComponent();
    }
    private async void add (object sender, EventArgs e)
    {
        var Novapagina2 = new ADD_Amigo();
		
        await Navigation.PushAsync(Novapagina2);
            
		
    }
}