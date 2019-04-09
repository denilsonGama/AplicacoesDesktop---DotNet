using ADO_NETProject01;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DAL_ProdutoNotaDeEntrada
{
    private SqlConnection connection = DBConnection.DB_Connection;

    private void InsertProdutosNotaDeEntrada(long? idNotaDeEntrada, IList<ProdutoNotaEntrada> produtos)
    {
        var command = new SqlCommand("insert into PRODUTOSNOTASDEENTRADA(IdNotaDeEntrada, IdProduto, PrecoCustoCompra," +
                                     "QuantidadeCompra) values(@IdNotaDeEntrada, @IdProduto," +
                                     "@PrecoCustoCompra, @QuantidadeCompra", connection);
        connection.Open();

        foreach (var produto in produtos)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdNotaDeEntrada", idNotaDeEntrada);
            command.Parameters.AddWithValue("@IdProduto", produto.Id);
            command.Parameters.AddWithValue("@PrecoCustoCompra", produto.PrecoCustoCompra);
            command.Parameters.AddWithValue("@QuantidadeCompra", produto.QuantidadeCompra);
            command.ExecuteNonQuery();
        }
        connection.Close();
    }

    private void InsertProduto(NotaEntrada notaEntrada, ProdutoNotaEntrada produto)
    {
        notaEntrada.Produtos.Add(produto);
        var command = new SqlCommand("insert into PRODUTOSNOTASDEENTRADA(IdNotaDeEntrada, IdProduto," +
                                    "PrecoCustoCompra, QuantidadeCompra) " +
            "values(@idnotadeentrada, @idproduto, @precocustocompra, @quantidadecompra)", connection);
        command.Parameters.AddWithValue("@idnotadeentrada", notaEntrada.Id);
        command.Parameters.AddWithValue("@idproduto", produto.ProdutoNota.Id);
        command.Parameters.AddWithValue("@precocustocompra", produto.PrecoCustoCompra);
        command.Parameters.AddWithValue("@quantidadecompra", produto.QuantidadeCompra);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void UpdateProduto(ProdutoNotaEntrada produto)
    {
        var command = new SqlCommand("update PRODUTOSNOTASDEENTRADA set IdProduto = @idproduto," +
                                     "PrecoCustoCompra = @precocustocompra, QuantidadeCompra = @quantidadecompra where (Id = @id)", connection);
        command.Parameters.AddWithValue("@idproduto", produto.ProdutoNota.Id);
        command.Parameters.AddWithValue("@precocustocompra", produto.PrecoCustoCompra);
        command.Parameters.AddWithValue("@quantidadecompra", produto.QuantidadeCompra);
        command.Parameters.AddWithValue("@id", produto.Id); //produto.Id
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void SaveProduto(NotaEntrada notaEntrada, ProdutoNotaEntrada produto
        )
    {
        if (produto.Id == null)
            this.InsertProduto(notaEntrada, produto);
        else
            this.UpdateProduto(produto);
    }

    public DataTable GetAllAsDataTable()
    {
        var adapter = new SqlDataAdapter("select PRODUTOSNOTASDEENTRADA.Id as NR_ITEM, NOTASDEENTRADA.Numero as NR_NOTA, " +
                                        "PRODUTOS.Id as COD_PRODUTO, PRODUTOS.Descricao as PRODUTO, PrecoCustoCompra as VLR_COMPRA," +
                                        "QuantidadeCompra as QTDE_COMPRA from PRODUTOSNOTASDEENTRADA, PRODUTOS, NOTASDEENTRADA where PRODUTOSNOTASDEENTRADA.IdProduto = PRODUTOS.Id AND NOTASDEENTRADA.ID = PRODUTOSNOTASDEENTRADA.IdNotaDeEntrada ORDER BY NUMERO ASC", connection);

        var builder = new SqlCommandBuilder(adapter);
        var table = new DataTable();
        adapter.Fill(table);

        connection.Close();
        return table;
    }

}
