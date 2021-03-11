using System.Threading.Tasks;

namespace PedidosApp.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await PedidosApp.App.Current.MainPage.DisplayAlert("Pedidos", message, "OK");
        }
        public async Task ShowAsync(string title, string message, string text)
        {
            await PedidosApp.App.Current.MainPage.DisplayAlert(title, message, text);
        }
        public async Task ShowAsync(string title, string message, string text1, string text2)
        {
            await PedidosApp.App.Current.MainPage.DisplayAlert(title, message, text1, text2);
        }

        public async Task<bool> ShowAsyncBool(string title, string message, string text1, string text2)
        {
           return await PedidosApp.App.Current.MainPage.DisplayAlert(title, message, text1, text2);
        }
    }
}
