using PedidosApp.Helpers;
using PedidosApp.Models;
using System.Collections.Generic;

namespace PedidosApp.Services

{
    //implementa o repositorio
    public class PedidoRepository : IPedidoRepository
    {
        DatabaseHelper _databaseHelper;
        public PedidoRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public void DeleteAllPedidos()
        {
            _databaseHelper.DeleteAllPedidos();
        }
        public void DeletePedido(int pedidoID)
        {
            _databaseHelper.DeletePedido(pedidoID);
        }
        public List<Pedido> GetAllPedidosData()
        {
            return _databaseHelper.GetAllPedidosData();
        }
        public Pedido GetPedidoData(int pedidoID)
        {
            return _databaseHelper.GetPedidoData(pedidoID);
        }
        public void InsertPedido(Pedido pedido)
        {
            _databaseHelper.InsertPedido(pedido);
        }

        public void UpdatePedido(Pedido pedido)
        {
            _databaseHelper.IUpdatePedido(pedido);
        }

    }
}
