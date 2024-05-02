using System.Text.Json;
namespace Tempo;

public partial class MainPage : ContentPage
{	Results resultado; 
    
	Resposta resposta;

    const string Url="https://api.hgbrasil.com/weather?=455927&key=d5a0f6cf";
    
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
		LabelGraus.Text=resultado.Temp.ToString();
		Labeldescricao.Text=resultado.Description;
		LabelUmidade.Text=resultado.Humidity.ToString();
		LabelSunrise.Text=resultado.Sunrise;
		LabelSunset.Tex=resultado.Sunset;
		LabelGraus.Text=resultado.Graus;
	}
	async void AtualizaTempo()
	{ 
	    try
		{   
			var navegador=new HttpClient();
			var response=await navegador.GetAsync(Url);
			if (response.IsSuccessStatusCode)
            {  
				var content= await response.Content.ReadAsStringAsync();
                resposta = JsonSerializer.Deserialize<Resposta>(content);
            }

			preencherTela();
        } 
		catch (Exception e) 
		{
              //Erro
		}
	}

}
		


