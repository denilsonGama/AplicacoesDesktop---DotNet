
using ADO_NETProject01;
using ModelProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DALProject
{
    public class DAL_Fornecedor
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("delete from FORNECEDORES where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetAllAsDataTable()
        {
            var adapter = new SqlDataAdapter("select id, nome, Cnpj from FORNECEDORES ORDER BY nome ASC", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            connection.Close();
            return table;
        }

        public IList<Fornecedor> GetAllAsIList()
        {
            IList<Fornecedor> fornecedores = new List<Fornecedor>();

            var adapter = new SqlDataAdapter("select id, nome, Cnpj from FORNECEDORES ORDER BY nome ASC", connection);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                fornecedores.Add(new Fornecedor()
                    {
                        Id = Convert.ToInt64(row["id"]),
                        CNPJ = (string)row["cnpj"],
                        Nome = (string)row["nome"]
                    }
                );
            }
            return fornecedores;
        }

        private void Update(Fornecedor fornecedor)
        {
            var command = new SqlCommand("update FORNECEDORES set cnpj=@Cnpj, nome=@Nome where id=@Id", connection);
            command.Parameters.AddWithValue("@Cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@Id", fornecedor.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Fornecedor fornecedor)
        {
            if (fornecedor.Id != null)
                this.Update(fornecedor);
            else
            {
                this.Insert(fornecedor);
            }
        }

       
        private void Insert(Fornecedor fornecedor)
        {

            var command = new SqlCommand("insert into FORNECEDORES(Nome, Cnpj) VALUES(@Nome, @Cnpj)", connection);
            command.Parameters.AddWithValue("@Nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@Cnpj", fornecedor.CNPJ);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Fornecedor GetById(long id)
        {
            Fornecedor fornecedor = new Fornecedor();
            var command = new SqlCommand("select id, cnpj, nome from FORNECEDORES where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fornecedor.Id = reader.GetInt64(0);
                    fornecedor.CNPJ = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
            }
            connection.Close();
            return fornecedor;
        }
    }
}