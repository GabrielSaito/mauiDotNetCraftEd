using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Maui.Controls;
using System.Security.Cryptography;

namespace CraftEd.Views
{
    public partial class Chat : ContentPage
    {
        private HubConnection hubConnection;

        private byte[] encryptionKey = new byte[16];

        public DataTemplate UserMessageTemplate { get; set; }
        public DataTemplate OtherMessageTemplate { get; set; }
        public Chat()
        {
            var encryptionService = new EncryptionService(encryptionKey);


            InitializeComponent();

            hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7254/ChatHub")
                .Build();

            hubConnection.On<string, string>("ReceiveMessage", (user, encryptedMessage) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    string decryptedMessage = encryptionService.Decrypt(encryptedMessage);

                    bool isCurrentUser = user == "Você";

                    AddMessageToChat(user, decryptedMessage, isCurrentUser);
                });
            });

            hubConnection.StartAsync();
        }


        private void AddMessageToChat(string user, string message, bool isCurrentUser)
        {



            var messageFrame = new Frame
            {
                Padding = new Thickness(10),
                CornerRadius = 10,
                Margin = new Thickness(10, 10, 10, 10),
            };

            if (isCurrentUser)
            {
                messageFrame.HorizontalOptions = LayoutOptions.Center;
                messageFrame.WidthRequest = 400;

                messageFrame.BackgroundColor = Color.FromHex("#1877f2"); // Sua cor de fundo
            }
            else
            {
                messageFrame.HorizontalOptions = LayoutOptions.End;
                messageFrame.WidthRequest = 400;

                messageFrame.BackgroundColor = Color.FromHex("#eb3d34"); // Cor de fundo para mensagens de outras pessoas
            }

            var userLabel = new Label
            {
                Text = user,
                FontSize = 16,
                TextColor = Color.FromHex("#000000"),
            };

            var messageLabel = new Label
            {
                Text = message,
                FontSize = 14,
                TextColor = Color.FromHex("#000000"),
            };

            messageFrame.Content = new StackLayout
            {
                Children = { userLabel, messageLabel },
            };

    
            chatContainer.Children.Add(messageFrame);

            Device.BeginInvokeOnMainThread(() =>
            {
                RoleParaParteInferior();
            });
        }

        private void RoleParaParteInferior()
        {
            if (scrollView != null)
            {
                scrollView.ScrollToAsync(chatContainer, ScrollToPosition.End, true);
            }
        }            

        private async void OnSendMessageClicked(object sender, EventArgs e)
        {
            var encryptionService = new EncryptionService(encryptionKey);


            var user = "Você";
            var message = messageInput.Text;

            if (!string.IsNullOrWhiteSpace(message))
            {
                string encryptedMessage = encryptionService.Encrypt(message);

                string decryptedMessage = encryptionService.Decrypt(encryptedMessage); 

                await hubConnection.InvokeAsync("SendMessage", user, decryptedMessage);
                messageInput.Text = string.Empty;
            }

        }
        private void Sair(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }
    }
}
