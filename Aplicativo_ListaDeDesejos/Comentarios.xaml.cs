using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_ListaDeDesejos;

public partial class Comentarios : ContentPage
{
    public Comentarios()
    {
        InitializeComponent();
    }
    private async void add_comentario (object sender, EventArgs e)
    {
        var novapagina = new ADD_Comentario();
		
        await Navigation.PushAsync(novapagina);
            
		
    }
}