using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using PedidosApp.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace PedidosApp.Helpers
{
    public class DatabaseHelper
    {
        //conexão com banco de dados
        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "PedidosDB.db";

        public DatabaseHelper()
        {
            //cria pasta base local para o dispositivo
            var pasta = new LocalRootFolder();
            //cria o arquivo
            var arquivo = pasta.CreateFile(DbFileName, CreationCollisionOption.OpenIfExists);
            //abre o BD
            sqliteconnection = new SQLiteConnection(arquivo.Path);
            //cria a tabela no BD
            sqliteconnection.CreateTable<Pedido>();
        }

        //Pegar todos os dados
        public List<Pedido> GetAllPedidosData()
        {
            return (from data in sqliteconnection.Table<Pedido>() select data).ToList();
        }

        //Pegar dados pelo Id
        public Pedido GetPedidoData(int id)
        {
            return sqliteconnection.Table<Pedido>().FirstOrDefault(p => p.Id == id);
        }

        //Deletar todos os dados
        public void DeleteAllPedidos()
        {
            sqliteconnection.DeleteAll<Pedido>();
        }

        //Deletar dados pelo Id
        public void DeletePedido(int id)
        {
            sqliteconnection.Delete<Pedido>(id);
        }

        //Inserir dados
        public void InsertPedido(Pedido pedido)
        {
            sqliteconnection.Insert(pedido);
        }

        //Atualizar dados
        public void IUpdatePedido(Pedido pedido)
        {
            sqliteconnection.Update(pedido);
        }

    }
}
