using System.Threading.Tasks;

namespace PedidosApp.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToAddPedido()
        {
            await PedidosApp.App.Current.MainPage.Navigation.PushAsync(new AddPedido());
        }
        public async Task NavigateToDetailsPage(int ID)
        {
            await PedidosApp.App.Current.MainPage.Navigation.PushAsync(new DetailsPage(ID));
        }
        public async Task NavigateToPedidoLista(int ID)
        {
            await PedidosApp.App.Current.MainPage.Navigation.PushAsync(new PedidoLista(ID));
        }
        public async void PopAsyncService()
        {
            await PedidosApp.App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
