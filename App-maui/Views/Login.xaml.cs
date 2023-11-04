using App_maui;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Text;

namespace CraftEd.Views;

public partial class Login : ContentPage
{
    string ApiUrl = "http://localhost:5000/v1/login";
    public Login()
	{
		InitializeComponent();
	}
    private async void TelaPrincipal(object sender, EventArgs args)
    {
        string email = EmailEntry.Text;
        string senha = SenhaEntry.Text;

       // string jwt = await GetJwtAsync(email, senha);

       // if (jwt != null) {
          //  Navigation.PushModalAsync(new Principal());

        //}
        Navigation.PushModalAsync(new Principal());

        //ErrorLabel.Text = "Email ou senha inválidos";


        //App.Current.MainPage = new Principal();
    }

    private async Task<string> GetJwtAsync(string email, string senha)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                 var jsonContent = new StringContent(
                    $"{{\"email\":\"{email}\",\"senha\":\"{senha}\"}}",
                    Encoding.UTF8,
                    "application/json"
                );

                 HttpResponseMessage response = await httpClient.PostAsync(ApiUrl, jsonContent);

                 if (response.IsSuccessStatusCode)
                {
                     string jwt = await response.Content.ReadAsStringAsync();
                    return jwt;
                }
                else
                {
                     Console.WriteLine($"Erro ao obter o JWT. Código de status: {response.StatusCode}");
                    return null;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter o JWT: {ex.Message}");
            return null;
        }
    }

    private void CadastrarUsuario(object sender, EventArgs args)
    {
        Navigation.PushModalAsync(new CadastrarUsuario());
        //App.Current.MainPage = new CadastrarUsuario();
    }
}