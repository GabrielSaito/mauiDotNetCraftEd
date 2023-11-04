namespace CraftEd.Views;

public partial class Tarefas : ContentPage
{
	public Tarefas()
	{
		InitializeComponent();
	}
    public class Tarefa
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }

    private void Sair(object sender, EventArgs args)
    {
        Navigation.PopModalAsync();
    }
}