namespace Tempo;

public partial class MainPage : ContentPage
{	Results resultado;
    
	int count = 0;
	public MainPage()

	{   
		InitializeComponent();
		TestaLayout();
		preencherTela();

	}

    void TestaLayout	()
	{     
      resultado= new Results();
		resultado.Temp=23;
		resultado.Description="tempo nublado";
		resultado.Rain=10;
		resultado.date=220424;
		resultado.time=0809;
		resultado.Currently= "dia";
		resultado.City="Apucarana";
		resultado.img_id=28;
		resultado.Humidity=90;
		resultado.Wind_Speedy=
		resultado.Wind_Direction=
		resultado.Sunrise=
		resultado.Sunset=
		resultado.moon_phase=
		
	}
	
	void preencherTela()
    { 
		
}

