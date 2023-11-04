using App_maui;

namespace CraftEd.Views;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}
    private void Chamada(object sender, EventArgs args)
    {
        Navigation.PushModalAsync(new Chamada());
    }

    private void Logout(object sender, EventArgs args)
    {
        Navigation.PopModalAsync();
    }
    private void Tarefas(Object sender, EventArgs args)
    {
        Navigation.PushModalAsync(new Tarefas());
    }

    private void Alunos(Object sender, EventArgs args)
    {
        Navigation.PushModalAsync(new Alunos());
    }

    private void EnviarEmail(Object sender, EventArgs args)
    {
        Navigation.PushModalAsync(new EnviarEmail());
    }
    private void AbrirChat(Object sender, EventArgs args)
    {
        Navigation.PushModalAsync(new Chat());
    }

}