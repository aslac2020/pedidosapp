using PedidosApp.Models;
using System.Collections.Generic;

namespace PedidosApp.Services
{
    public interface IPedidoRepository
    {
        List<Pedido> GetAllPedidosData();

        //Obtem um dado especifico por Id
        Pedido GetPedidoData(int pedidoID);

        //delete todos os dados
        void DeleteAllPedidos();

        //delete um dado especifico
        void DeletePedido(int pedidoID);

        //Insere um novo dado no BD
        void InsertPedido(Pedido pedido);

        //Atualiza os dados
        void UpdatePedido(Pedido pedido);

    }
}
