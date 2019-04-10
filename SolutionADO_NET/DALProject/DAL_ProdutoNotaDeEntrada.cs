using ADO_NETProject01;
using System;
using System.Data;
using System.Data.SqlClient;

public class DAL_ProdutoNotaDeEntrada
{
    private SqlConnection connection = DBConnection.DB_Connection;

    private void InsertProduto(NotaEntrada notaEntrada, ProdutoNotaEntrada produto)
    {
        notaEntrada.Produtos.Add(produto);
        var command = new SqlCommand("insert into PRODUTOSNOTASDEENTRADA(IdNotaDeEntrada, IdProduto," +
                                    "PrecoCustoCompra, QuantidadeCompra) " +
            "values(@idnotadeentrada, @idproduto, @precocustocompra, @quantidadecompra)", connection);
        command.Parameters.AddWithValue("@idnotadeentrada", notaEntrada.Id);
        command.Parameters.AddWithValue("@idproduto", produto.ProdutoCompra.Id);
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
        command.Parameters.AddWithValue("@idproduto", produto.ProdutoCompra.Id);
        command.Parameters.AddWithValue("@precocustocompra", produto.PrecoCustoCompra);
        command.Parameters.AddWithValue("@quantidadecompra", produto.QuantidadeCompra);
        command.Parameters.AddWithValue("@id", produto.Id); //produto.Id
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void SaveProduto(NotaEntrada notaEntrada, ProdutoNotaEntrada produto){

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

    public ProdutoNotaEntrada GetById(long id)
    {
        ProdutoNotaEntrada produtoNotaEntrada = new ProdutoNotaEntrada();
        DAL_Produto dalProduto = new DAL_Produto();
        long idProdutoNota = -1;
        var command = new SqlCommand("select id, idProduto, precoCustoCompra," +
                                     "quantidadeCompra from PRODUTOSNOTASDEENTRADA where id = @id", connection);

        command.Parameters.AddWithValue("@id", id);
        connection.Open();

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                produtoNotaEntrada.Id = reader.GetInt64(0);
                idProdutoNota = reader.GetInt64(1);
                produtoNotaEntrada.PrecoCustoCompra = Convert.ToDouble(reader[2]);
                produtoNotaEntrada.QuantidadeCompra = Convert.ToDouble(reader[3]);
            }
        }
        connection.Close();
        if (idProdutoNota > 0)
            produtoNotaEntrada.ProdutoCompra = dalProduto.GetById(idProdutoNota);

        return produtoNotaEntrada;
    }

    public void RemoveById(long? id)
    {
        var command = new SqlCommand("delete from PRODUTOSNOTASDEENTRADA where id = @id", connection);
        command.Parameters.AddWithValue("@id", id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
