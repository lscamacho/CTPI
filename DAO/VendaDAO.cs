using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class VendaDAO
    {
        #region Métodos para manipulação de arquivos

        #endregion

        #region Métodos de acesso a dados

        public Dictionary<Int64, Venda> BuscarTodos()
        {
            Dictionary<Int64, Venda> mapaVenda = new Dictionary<Int64, Venda>();

            try
            {
                String SQL = "SELECT  " +
                    "[id_venda]," +
                    "[data]," +
                    "[valor]," +
                    "[matricula_funcionario]," +
                    "[cpf_cliente]," +
                    "[id_produto]," +
                    "FROM [venda] ORDER BY id_venda;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Venda p = new Venda();

                    p.IdVenda = data.GetInt64(0);
                    p.Data = data.GetDateTime(1);
                    p.Valor = data.GetFloat(2);
                    p.MatriculaFuncionario = data.GetInt64(3);
                    p.CpfCliente = data.GetInt64(4);
                    p.IdProduto = data.GetInt64(5);


                    mapaVenda.Add(p.IdVenda, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaVenda;
        }

        public Dictionary<Int64, Venda> BuscarListaFiltrada(String _filtro)
        {
            Dictionary<Int64, Venda> mapaVenda = new Dictionary<Int64, Venda>();
            try
            {
                String SQL = "SELECT * FROM Venda WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtro, out saida))
                {
                    SQL += String.Format("id_venda = {0}", _filtro);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtro);
                }

                SQL += " ORDER BY id_venda;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Venda p = new Venda();

                    p.IdVenda = data.GetInt64(0);
                    p.Data = data.GetDateTime(1);
                    p.Valor = data.GetFloat(2);
                    p.MatriculaFuncionario = data.GetInt64(3);
                    p.CpfCliente = data.GetInt64(4);
                    p.IdProduto = data.GetInt64(5);

                    mapaVenda.Add(p.IdVenda, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELOS FILTROS / " + ex.Message);
            }

            return mapaVenda;
        }

        public Venda BuscarPorIdProduto(Int64 _idVenda)
        {
            Venda p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM venda WHERE id_venda = {0};", _idVenda);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Venda();

                    p.IdVenda = data.GetInt64(0);
                    p.Data = data.GetDateTime(1);
                    p.Valor = data.GetFloat(2);
                    p.MatriculaFuncionario = data.GetInt64(3);
                    p.CpfCliente = data.GetInt64(4);
                    p.IdProduto = data.GetInt64(5);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELO ID / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Venda _obj)
        {
            int linhasAfetasdas = 0;

            try
            {


                String SQL = String.Format("INSERT INTO venda (" +
                    "[id_venda]," +
                    "[data]," +
                    "[valor]," +
                    "[matricula_funcionario]," +
                    "[cpf_cliente]," +
                    "[id_produto]," +
                    ") " +
                    "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}');",
                    _obj.IdVenda,
                    _obj.Data,
                    _obj.Valor,
                    _obj.MatriculaFuncionario,
                    _obj.CpfCliente,
                    _obj.IdProduto
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

        public Boolean Deletar(Int64 _idVenda)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM venda WHERE id_venda = " + _idVenda;

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

        public Boolean Alterar(Venda _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE venda SET " +
                    "data = '{0}'," +
                    "valor = '{1}'," +
                    "matricula_funcionario = '{2}'," +
                    "cpf_cliente = '{3}'," +
                    "id_produto = '{4}'," +
                    " WHERE id_venda = {10}",
                    _obj.Data,
                    _obj.Valor,
                    _obj.MatriculaFuncionario,
                    _obj.CpfCliente,
                    _obj.IdProduto,
                    _obj.IdVenda
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
