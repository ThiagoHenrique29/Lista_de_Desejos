using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_ListaDeDesejos;

public partial class Detalhes : ContentPage
{
    public Detalhes()
    {
        InitializeComponent();
    }
    private async void comentarios (object sender, EventArgs e)
    {
        var novapagina = new Comentarios();
		
        await Navigation.PushAsync(novapagina);
            
		
    }
}