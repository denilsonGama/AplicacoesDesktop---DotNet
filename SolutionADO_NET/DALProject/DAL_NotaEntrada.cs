using ADO_NETProject01;
using DALProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DAL_NotaEntrada
{
    private SqlConnection connection = DBConnection.DB_Connection;
    private void Insert(NotaEntrada notaEntrada)
    {
        var command = new SqlCommand("insert into NOTASDEENTRADA(IdFornecedor, Numero, DataEmissao," +
                                     "DataEntrada) values(@IdFornecedor, @Numero, @DataEmissao, @DataEntrada)", connection);
        command.Parameters.AddWithValue("@IdFornecedor", notaEntrada.FornecedorNota.Id);
        command.Parameters.AddWithValue("@Numero", notaEntrada.Numero);
        command.Parameters.AddWithValue("@DataEmissao", notaEntrada.DataEmissao);
        command.Parameters.AddWithValue("@DataEntrada", notaEntrada.DataEntrada);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void Update(NotaEntrada notaEntrada)
    {
        var command = new SqlCommand("update NOTASDEENTRADA set IdFornecedor = @IdFornecedor, Numero = @Numero, DataEmissao = @DataEmissao," +
                                     "DataEntrada = @DataEntrada where(Id = @Id)", connection);
        command.Parameters.AddWithValue("@IdFornecedor", notaEntrada.FornecedorNota.Id);
        command.Parameters.AddWithValue("@Numero", notaEntrada.Numero);
        command.Parameters.AddWithValue("@DataEmissao", notaEntrada.DataEmissao);
        command.Parameters.AddWithValue("@DataEntrada", notaEntrada.DataEntrada);
        command.Parameters.AddWithValue("@Id", notaEntrada.Id);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
        DeleteAllProdutosFromNotaEntrada(notaEntrada.Id);
        InsertProdutosNotaDeEntrada(notaEntrada.Id, notaEntrada.Produtos);
    }

    private void InsertProdutosNotaDeEntrada(long? id, IList<ProdutoNotaEntrada> produtos)
    {
        throw new NotImplementedException();
    }

    private void DeleteAllProdutosFromNotaEntrada(long? idNotaEntrada)
    {
        var command = new SqlCommand("delete from NOTASDEENTRADA where(Id = @Id)", connection);
        command.Parameters.AddWithValue("@Id", idNotaEntrada);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void Save(NotaEntrada notaEntrada)
    {
        if (notaEntrada.Id == null)
            this.Insert(notaEntrada);
        else
            this.Update(notaEntrada);
    }

    public DataTable GetAllAsDataTable()
    {
        var adapter = new SqlDataAdapter("select notasdeentrada.id as NR_ITEM, idfornecedor as NR_FORNECEDOR," +
                                        "fornecedores.nome as FORNECEDOR, numero as NR_NOTA, dataemissao as EMISSÃO," +
                                        "dataentrada as ENTRADA from NOTASDEENTRADA, FORNECEDORES " +
                                        "where NOTASDEENTRADA.IDFORNECEDOR = FORNECEDORES.ID", connection);

        var builder = new SqlCommandBuilder(adapter);
        var table = new DataTable();
        adapter.Fill(table);

        connection.Close();
        return table;
    }

    public NotaEntrada GetById(long id)
    {
        NotaEntrada notaEntrada = new NotaEntrada();
        DAL_Fornecedor dalFornecedor = new DAL_Fornecedor();
        long idFornecedorNota = -1;
        var command = new SqlCommand("select id, idfornecedor, numero, dataemissao," +
                                     "dataentrada from NOTASDEENTRADA where id = @id", connection);

        command.Parameters.AddWithValue("@id", id);
        connection.Open();

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                notaEntrada.Id = reader.GetInt64(0);
                idFornecedorNota = reader.GetInt64(1);
                notaEntrada.Numero = reader.GetString(2);
                notaEntrada.DataEmissao = reader.GetDateTime(3);
                notaEntrada.DataEntrada = reader.GetDateTime(4);
            }
        }
        connection.Close();
        if (idFornecedorNota > 0)
            notaEntrada.FornecedorNota = dalFornecedor.GetById(idFornecedorNota);

        return notaEntrada;
    }

    /*public ProdutoNotaEntrada ProdutoGetById(long id)
    {
        ProdutoNotaEntrada produtoNotaEntrada = new ProdutoNotaEntrada();
        DAL_Produto dal_Produto = new DAL_Produto();
        long idProduto = -1;
        var command = new SqlCommand("select id, idProduto, precoCustoCompra, QuantidadeCompra," +
                                     "from PRODUTONOTADEENTRADA where id = @id", connection);

        command.Parameters.AddWithValue("@id", id);
        connection.Open();

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                produtoNotaEntrada.Id = reader.GetInt64(0);
                idProduto = reader.GetInt64(1);
                produtoNotaEntrada.PrecoCustoCompra = reader.GetDouble(2);
                produtoNotaEntrada.QuantidadeCompra = reader.GetDouble(3);
                
            }
        }
        connection.Close();
        if (idProduto > 0)
            produtoNotaEntrada.ProdutoNota = DAL.ProdutoGetById(idProduto);

        return produtoNotaEntrada;
    }*/
}