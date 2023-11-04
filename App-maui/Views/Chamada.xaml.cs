using App_maui.Models.PortalProfessor;
using Microsoft.Maui.Controls;
 using System.Drawing;
using System.Security.Cryptography;
using Color = Microsoft.Maui.Graphics.Color;

namespace CraftEd.Views;

public partial class Chamada : ContentPage
{
    private List<Aluno> alunos;
    private DateTime selectedDate;
    public Chamada()
    {
        InitializeComponent();

        // Inicialize a lista de alunos e defina o DatePicker como invisível
        alunos = new List<Aluno>();
        AlunosListView.ItemsSource = alunos;
        AlunosListView.IsVisible = false;
    }

    private void OnDateClicked(object sender, DateChangedEventArgs e)
    {
        selectedDate = e.NewDate;
        AlunosListView.ItemsSource = GetAlunosParaDataSelecionada(selectedDate);
        AlunosListView.IsVisible = true;
    }

    private List<Aluno> GetAlunosParaDataSelecionada(DateTime dataSelecionada)
    {
        // Implemente a lógica para obter a lista de alunos para a data selecionada
        // Por exemplo, você pode consultar um banco de dados ou outra fonte de dados.
        // Certifique-se de ajustar essa lógica de acordo com seus requisitos.
        return new List<Aluno>
            {
                new Aluno { Nome = "Aluno 1", Presente = false },
                new Aluno { Nome = "Aluno 2", Presente = true },
            };
    }

    private void OnSwitchToggled(object sender, ToggledEventArgs e)
    {
        // Implemente a lógica para atualizar o estado de presença do aluno conforme necessário
        // Certifique-se de ajustar essa lógica de acordo com seus requisitos.

    }
    private void FecharTela(object sender, EventArgs args)
    {
        Navigation.PopModalAsync();
    }
}