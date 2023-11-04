
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
                // Aqui voc� pode fazer algo com o arquivo selecionado, como salv�-lo em um local espec�fico ou utilizar seus dados.
            }
        }
    }

    private void OnSaveTaskClicked(object sender, EventArgs e)
    {
        //string title = titleEntry.Text;
        //string summary = summaryEntry.Text;

        // Aqui voc� pode salvar os dados da tarefa (t�tulo, resumo, imagem e arquivo) no local de armazenamento de sua escolha.
    }
}
