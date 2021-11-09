using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ProdutoDAO
    {
        #region Métodos para manipulação de arquivos

        #endregion

        #region Métodos de acesso a dados

        public Dictionary<Int64, Produto> BuscarTodos()
        {
            Dictionary<Int64, Produto> mapaProduto = new Dictionary<Int64, Produto>();

            try
            {
                String SQL = "SELECT  " +
                    "[id_produto]," +
                    "[descricao]," +
                    "[tipo]," +
                    "[preco]," +
                    "FROM [produto] ORDER BY id_produto;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Produto p = new Produto();

                    p.IdProduto = data.GetInt64(0);
                    p.Descricao = data.GetString(1);
                    p.Tipo = data.GetString(2);
                    p.Preco = data.GetFloat(3);
                  

                    mapaProduto.Add(p.IdProduto, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaProduto;
        }

        public Dictionary<Int64, Produto> BuscarListaFiltrada(String _filtro)
        {
            Dictionary<Int64, Produto> mapaProduto = new Dictionary<Int64, Produto>();
            try
            {
                String SQL = "SELECT * FROM produto WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtro, out saida))
                {
                    SQL += String.Format("id_produto = {0}", _filtro);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtro);
                }

                SQL += " ORDER BY id_produto;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Produto p = new Produto();

                    p.IdProduto = data.GetInt64(0);
                    p.Descricao = data.GetString(1);
                    p.Tipo = data.GetString(2);
                    p.Preco = data.GetFloat(3);

                    mapaProduto.Add(p.IdProduto, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELOS FILTROS / " + ex.Message);
            }

            return mapaProduto;
        }

        public Produto BuscarPorIdProduto(Int64 _idProduto)
        {
            Produto p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM produto WHERE id_produto = {0};", _idProduto);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Produto();

                    p.IdProduto = data.GetInt64(0);
                    p.Descricao = data.GetString(1);
                    p.Tipo = data.GetString(2);
                    p.Preco = data.GetFloat(3);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELO ID / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Produto _obj)
        {
            int linhasAfetasdas = 0;

            try
            {


                String SQL = String.Format("INSERT INTO produto (" +
                    "[id_produto]," +
                    "[descricao]," +
                    "[tipo]," +
                    "[preco]," +
                    ") " +
                    "VALUES ({0}, '{1}', '{2}', '{3}');",
                    _obj.IdProduto,
                    _obj.Descricao,
                    _obj.Tipo,
                    _obj.Preco                    
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

        public Boolean Deletar(Int64 _idProduto)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM produto WHERE id_produto = " + _idProduto;

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

        public Boolean Alterar(Produto _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE cliente SET " +
                    "descricao = '{0}'," +
                    "tipo = '{1}'," +
                    "preco = '{2}'," +
                    " WHERE id_produto = {10}",
                    _obj.Descricao,
                    _obj.Tipo,
                    _obj.Preco,
                    _obj.IdProduto
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
