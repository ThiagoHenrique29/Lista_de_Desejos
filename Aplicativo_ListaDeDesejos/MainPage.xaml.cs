namespace Aplicativo_ListaDeDesejos;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Botao (object sender, EventArgs e)
	{
		var novapagina = new Pagina_Principal();
		
		await Navigation.PushAsync(novapagina);
            
		
	}
	private async void cadastro (object sender, EventArgs e)
	{
		var novapagina = new Cadastro();
		
		await Navigation.PushAsync(novapagina);
            
		
	}
}

