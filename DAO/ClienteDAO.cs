using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteDAO
    {
        #region Métodos para manipulação de arquivos

        #endregion

        #region Métodos de acesso a dados

        public Dictionary<Int64, Cliente> BuscarTodos()
        {
            Dictionary<Int64, Cliente> mapaCliente = new Dictionary<Int64, Cliente>();

            try
            {
                String SQL = "SELECT  " +
                    "[cpf]," +
                    "[nome]," +
                    "[logradouro]," +
                    "[data_nascimento]," +
                    "[estado_civil]," +
                    "[telefone]," +
                    "[renda_mensal]," +
                    "[estado]," +
                    "[cidade]," +
                    "[cep]," +
                    "FROM [cliente] ORDER BY cpf;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cliente p = new Cliente();

                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Logradouro = data.GetString(2);
                    p.DataNascimento = data.GetString(3);
                    p.Telefone = data.GetString(4);
                    p.EstadoCivil = data.GetString(5);
                    p.RendaMensal = data.GetString(6);
                    p.Estado = data.GetString(7);
                    p.Cidade = data.GetString(8);
                    p.Cep = data.GetString(9);

                    mapaCliente.Add(p.Cpf, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaCliente;
        }

        public Dictionary<Int64, Cliente> BuscarListaFiltrada(String _filtro)
        {
            Dictionary<Int64, Cliente> mapaCliente = new Dictionary<Int64, Cliente>();
            try
            {
                String SQL = "SELECT * FROM funcionario WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtro, out saida))
                {
                    SQL += String.Format("cpf = {0}", _filtro);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtro);
                }

                SQL += " ORDER BY cpf;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cliente p = new Cliente();

                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Logradouro = data.GetString(2);
                    p.DataNascimento = data.GetString(3);
                    p.Telefone = data.GetString(4);
                    p.EstadoCivil = data.GetString(5);
                    p.RendaMensal = data.GetString(6);
                    p.Estado = data.GetString(7);
                    p.Cidade = data.GetString(8);
                    p.Cep = data.GetString(9);


                    mapaCliente.Add(p.Cpf, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELOS FILTROS / " + ex.Message);
            }

            return mapaCliente;
        }

        public Cliente BuscarPorCPF(Int64 _cpf)
        {
            Cliente p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM cliente WHERE cpf = {0};", _cpf);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Cliente();

                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Logradouro = data.GetString(2);
                    p.DataNascimento = data.GetString(3);
                    p.Telefone = data.GetString(4);
                    p.EstadoCivil = data.GetString(5);
                    p.RendaMensal = data.GetString(6);
                    p.Estado = data.GetString(7);
                    p.Cidade = data.GetString(8);
                    p.Cep = data.GetString(9);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELO CPF / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Cliente _obj)
        {
            int linhasAfetasdas = 0;

            try
            {


                String SQL = String.Format("INSERT INTO cliente (" +
                    "[cpf]," +
                    "[nome]," +
                    "[logradouro]," +
                    "[data_nascimento]," +
                    "[estado_civil]," +
                    "[sexo]," +
                    "[telefone]," +
                    "[renda_mensal]," +
                    "[estado]," +
                    "[cidade]," +
                    "[cep]" +
                    ") " +
                    "VALUES ({0}, '{1}', '{2}', '{3}', '{4}','{5}','{6}','{7}','{8}','{9}', '{10}');",
                    _obj.Cpf,
                    _obj.Nome,
                    _obj.Logradouro,
                    _obj.DataNascimento,
                    _obj.EstadoCivil,
                    _obj.Sexo,
                    _obj.Telefone,
                    _obj.RendaMensal,
                    _obj.Estado,
                    _obj.Cidade,
                    _obj.Cep
                    );

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean Deletar(Int64 _cpf)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM cliente WHERE matricula = " + _cpf;

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("DELETE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Alterar(Cliente _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE cliente SET " +
                    "nome = '{0}'," +
                    "logradouro = '{1}'," +
                    "data_nascimento = '{2}'," +
                    "estado_civil = '{3}'," +
                    "telefone = '{4}'," +
                    "renda_mensal = '{5}'," +
                    "estado = '{6}'," +
                    "cidade = '{7}'," +
                    "cep = '{8}'," +
                    " WHERE cpf = {10}",
                    _obj.Nome,
                    _obj.Logradouro,
                    _obj.DataNascimento,
                    _obj.EstadoCivil,
                    _obj.Telefone,
                    _obj.RendaMensal,
                    _obj.Estado,
                    _obj.Cidade,
                    _obj.Cep,
                    _obj.Cpf
                    );


                {
                    linhasAfetasdas = BD.ExecutarIDU(SQL);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("UPDATE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
