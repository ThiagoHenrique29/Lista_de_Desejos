using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_ListaDeDesejos;

public partial class Lista_Desejos : ContentPage
{
    public Lista_Desejos()
    {
        InitializeComponent();
    }
    private async void add (object sender, EventArgs e)
    {
        var Novapagina2 = new ADD_Item();
		
        await Navigation.PushAsync(Novapagina2);
            
		
    }
    private async void detalhes (object sender, EventArgs e)
    {
        var Novapagina2 = new Detalhes();
		
        await Navigation.PushAsync(Novapagina2);
            
		
    }
}