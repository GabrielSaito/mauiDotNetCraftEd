
using Plugin.Media.Abstractions;

namespace CraftEd.Views;

public partial class CadastrarTarefaNova : ContentView
{
    private MediaFile? selectedImageFile;
    private FileResult? selectedFileResult;
    public CadastrarTarefaNova()
	{
		InitializeComponent();
	}
    private async void OnAddImageClicked(object sender, EventArgs e)
    {
        //selectedImageFile = await MediaPicker.PickPhotoAsync();
        if (selectedImageFile != null)
        {
            //taskImage.Source = ImageSource.FromStream(() => selectedImageFile.GetStream());
        }
    }

    private async void OnAddFileClicked(object sender, EventArgs e)
    {
        selectedFileResult = await FilePicker.PickAsync(new PickOptions
        {
            //FileTypes = FilePickerFileType.Images | FilePickerFileType.Presentation | FilePickerFileType.Documents
        });

        if (selectedFileResult != null)
        {
            if (selectedFileResult is not FileResult fileResult || string.IsNullOrWhiteSpace(fileResult.FullPath))
                return;

            // Verifica se o arquivo existe antes de exibi-lo na tela
            if (System.IO.File.Exists(fileResult.FullPath))
            {
                // Aqui você pode fazer algo com o arquivo selecionado, como salvá-lo em um local específico ou utilizar seus dados.
            }
        }
    }

    private void OnSaveTaskClicked(object sender, EventArgs e)
    {
        //string title = titleEntry.Text;
        //string summary = summaryEntry.Text;

        // Aqui você pode salvar os dados da tarefa (título, resumo, imagem e arquivo) no local de armazenamento de sua escolha.
    }
}
