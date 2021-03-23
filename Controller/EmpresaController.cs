using CRUD.DB;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace CRUD.Controller
{
    public class EmpresaController
    {
        private DBUtil db = new DBUtil();
        public void iniciarConexao()
        {
            if (db.conectar())
            {

            }
            else
            {
                MessageBox.Show("Falha ao conectar com o banco de dados!");
            }
        }

        public void desconectar()
        {
            if (db.desconectar())
            {

            }
            else
            {
                MessageBox.Show("Problemas ao encerrar a conexão com o banco de dados!");
            }
        }

        private bool consistirValores(string nome, string qtde)
        {
            if (nome.Trim().Length == 0)
            {
                MessageBox.Show("Nome não informado!");
                return false;
            }

            if ((qtde.Trim().Length == 0) || (qtde.Equals("0")))
            {
                MessageBox.Show("Quantidae de funcionários não informada!");
                return false;
            }

            return true;
        }

        public void add(string nome, string site, string qtde)
        {
            if (consistirValores(nome, qtde))
            {
                string command = "INSERT INTO Empresa (Nome,Site,QuantidadeFuncionarios) VALUES (@NOME, @SITE, @QTDE);";

                try
                {
                    SqlCommand objCmd = new SqlCommand(command, db.getConexao());
                    objCmd.Parameters.Add(new SqlParameter("@NOME", nome));
                    objCmd.Parameters.Add(new SqlParameter("@SITE", site));
                    objCmd.Parameters.Add(new SqlParameter("@QTDE", int.Parse(qtde)));

                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public Empresa getEmpresaById(string id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Empresa empresa = new Empresa();
            try
            {
                using (var cmd = db.getConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empresa WHERE Id=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, db.getConexao());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        empresa.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                        empresa.Nome = dt.Rows[0]["Nome"].ToString();
                        empresa.Site = dt.Rows[0]["Site"].ToString();
                        empresa.QuantidadeFuncionarios = Convert.ToInt32(dt.Rows[0]["QuantidadeFuncionarios"]);
                        return empresa;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma empresa encontrada!");
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(string id, string nome, string site, string qtde)
        {
            try
            {
                if (consistirValores(nome, qtde))
                {
                    using (var cmd = db.getConexao().CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Empresa SET Nome=@Nome, Site=@Site, QuantidadeFuncionarios=@Qtd WHERE Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", int.Parse(id));
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Site", site);
                        cmd.Parameters.AddWithValue("@Qtd", int.Parse(qtde));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro atualizado com sucesso!");
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(string id)
        {
            try
            {
                using (var cmd = db.getConexao().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Empresa Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", int.Parse(id)); 
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
