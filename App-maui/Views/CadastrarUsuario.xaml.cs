using CraftEd.Models.User;
using System.Net.Http.Json;

namespace CraftEd.Views;

public partial class CadastrarUsuario : ContentPage
{
    public CadastrarUsuario()
    {
        InitializeComponent();
    }

    private void Image_SizeChanged(object sender, EventArgs e)
    {
    }
    public void Close(object sender, EventArgs args)
    {
        Navigation.PopModalAsync();
    }

    private async void OnCreateUserClicked(object sender, EventArgs e)
    {
        string apiUrl = "http://localhost:5000/v1/users";


        UserRegister user = new()
        {
            Email = EmailEntry.Text,
            Nickname = NicknameEntry.Text,
            Password = PasswordEntry.Text
        };

        using (HttpClient client = new HttpClient())
        {
            var response = await client.PostAsJsonAsync(apiUrl, user);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Usuário criado com sucesso");
            }
            else
            {
                Console.WriteLine($"Erro ao criar o usuário. Status code: {response.StatusCode}");
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errorContent);
            }
        }
    }
}