using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace DAO
{
    public static class BD
    {
        private static String strConn = @"Data Source=C:\Users\lscamacho\Documents\Faculdade\CTPI\AppAula20212-master\BD.sdf;Password=1998";
        private static SqlCeConnection conexao;

       
        public static void AbrirConexao() 
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = strConn;
                        conexao.Open();
                    }
                }

                else
                {
                    conexao = new SqlCeConnection(strConn);
                    conexao.Open();
                }

            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO ABRIR CONEXÃO"+ ex.Message);
            }
        }

        public static void FecharConexao() 
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO FEHCAR CONEXÃO" + ex.Message);
            }
        }
       
        public static DataTableReader ExecutarSelect(String _SQL)
        {
            try
            {
                AbrirConexao();

                DataTable dt = new DataTable();
                SqlCeCommand cmd = new SqlCeCommand(_SQL, conexao);
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                adapter.Fill(dt);

                DataTableReader data = dt.CreateDataReader();

                FecharConexao();

                return data;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECUTAR SELECT" + ex.Message);
            }
        }
        public static int ExecutarIDU(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand cmd = new SqlCeCommand(_SQL, conexao);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                FecharConexao();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECUTAR IDU" + ex.Message);
            }
        }
        public static int ExecutarIDU(String _SQL, List<SqlCeParameter> _parameters)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand cmd = new SqlCeCommand(_SQL, conexao);

                cmd.Parameters.AddRange(_parameters.ToArray());

                int linhasAfetadas = cmd.ExecuteNonQuery();

                FecharConexao();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECUTAR IDU" + ex.Message);
            }
        }
        public static Object ExecutarInsertComRetornoDeValor(String _SQL, List<SqlCeParameter> _parameters)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand cmd = new SqlCeCommand(_SQL, conexao);

                cmd.Parameters.AddRange(_parameters.ToArray());
                int linhasAfetadas = cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTIFY";
                Object pk = cmd.ExecuteScalar();

                FecharConexao();

                return pk;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECUTAR INSERT COM PK" + ex.Message);
            }
        }

        public static Object SelectImagemBD(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand cmd = new SqlCeCommand(_SQL, conexao);

                Object imagem = cmd.ExecuteScalar();

                FecharConexao();

                return imagem;
            }
            catch (Exception ex)
            {

                throw new Exception("ERRO AO EXECUTAR SELECAO DE IMAGEM NO BD" + ex.Message);
            }
        }
    }
}
