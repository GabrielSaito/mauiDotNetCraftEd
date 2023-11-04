using CraftEd.Models.Aluno;

namespace CraftEd.Views;

public partial class Alunos : ContentPage
{
    public Alunos()
    {
        InitializeComponent();




        //var alunos = new List<Aluno>
        //    {
        //        new Aluno { Nome = "João", Idade = 20, Curso = "Engenharia" },
        //        new Aluno { Nome = "Maria", Idade = 22, Curso = "Medicina" },
        //        new Aluno { Nome = "Carlos", Idade = 21, Curso = "Informática" }
        //    };

        //var listView = new ListView
        //{
        //    ItemsSource = alunos,
        //    HasUnevenRows = true,
        //    ItemTemplate = new DataTemplate(() =>
        //    {
        //        var nomeLabel = new Label();
        //        nomeLabel.SetBinding(Label.TextProperty, "Nome");

        //        var idadeLabel = new Label();
        //        idadeLabel.SetBinding(Label.TextProperty, "Idade");

        //        var cursoLabel = new Label();
        //        cursoLabel.SetBinding(Label.TextProperty, "Curso");

        //        return new ViewCell
        //        {
        //            View = new StackLayout
        //            {
        //                Orientation = StackOrientation.Horizontal,
        //                Children =
        //                    {
        //                        new StackLayout
        //                        {
        //                            HorizontalOptions = LayoutOptions.StartAndExpand,
        //                            Children = { nomeLabel, idadeLabel }
        //                        },
        //                        new StackLayout
        //                        {
        //                            HorizontalOptions = LayoutOptions.EndAndExpand,
        //                            Children = { cursoLabel }
        //                        }
        //                    }
        //            }
        //        };
        //    })
        //};

        //Content = listView;
    }
    private void Sair(object sender, EventArgs args)
    {
        Navigation.PopModalAsync();
    }
}
