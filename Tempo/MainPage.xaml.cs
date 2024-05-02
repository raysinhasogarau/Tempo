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
		LabelGraus.Text=resultado.Temp;
		labeldescricao.Text=resultado.Description;
		labelHumidity.Text=resultado.ToString;
		labelSunrise.Text=resultado.ToString;
	}
	async void AtualizaTempo()
	{ 
	    try
		{   
			var httpClient=new HttpClient();
			var response=await httpClient.GetAsync(Url);
			if (response.IsSccessStatusCode)
            {  
				string content=response.Content.ReadAsStringAsync();
                resposta = JsonSerialier.Deserialize<Resposta>(content);

            }

        } 
		catch (Exception e) {
              //Erro


		}


		

	  
    





	}

}
		


