using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp.Services
{
   public interface INavigationService
    {
        Task NavigateToAddPedido();
        Task NavigateToDetailsPage(int ID);
        Task NavigateToPedidoLista();
        void PopAsyncService();

    }
}
