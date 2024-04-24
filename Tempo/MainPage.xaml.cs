namespace Tempo;

public partial class MainPage : ContentPage
{	Results resultado; 
    
	Resposta resposta;

    const string Url=""
    
	int count = 0;
	public MainPage()

	{   
		InitializeComponent();
		TestaLayout();
		preencherTela();

	}

    void TestaLayout()
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
		resultado.Wind_Speedy="4.99 km/h";
		resultado.Wind_Direction=40;
		resultado.Sunrise="06:11 am";
		resultado.Sunset="06:39 pm";
		resultado.moon_phase="cheia";
		
	}
	
	void preencherTela()
	{
		
	}


}
		


