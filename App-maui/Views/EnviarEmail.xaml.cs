namespace CraftEd.Views;

public partial class EnviarEmail : ContentPage
{
	public EnviarEmail()
	{
		InitializeComponent();

	}
    private async void Enviar (object sender, EventArgs e)
    {
        var message = new EmailMessage
        {
            Subject = AssuntoEntry.Text,
            Body = CorpoEditor.Text,
            To = { DestinatarioEntry.Text }
        };

        try
        {
            await Email.ComposeAsync(message);
        }
        catch (FeatureNotSupportedException)
        {
         }
        catch (Exception ex)
        {
         }
    }

    private void Sair(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}