using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FuncionarioDAO
    {
        #region Métodos para manipulação de arquivos

        #endregion

        #region Métodos de acesso a dados

        public Dictionary<Int64, Funcionario> BuscarTodos()
        {
            Dictionary<Int64, Funcionario> mapaFuncionario = new Dictionary<Int64, Funcionario>();

            try
            {
                String SQL = "SELECT  " +
                    "[matricula]," +
                    "[nome]," +
                    "[cargo]," +
                    "[endereco]," +
                    "[telefone]," +
                    "FROM [funcionario] ORDER BY matricula;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Funcionario p = new Funcionario();

                    p.Matricula = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Cargo = data.GetString(2);
                    p.Endereco = data.GetString(3);
                    p.Telefone = data.GetString(4);
                    
                    

                    mapaFuncionario.Add(p.Matricula, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaFuncionario;
        }

        public Dictionary<Int64, Funcionario> BuscarListaFiltrada(String _filtro)
        {
            Dictionary<Int64, Funcionario> mapaFuncionario = new Dictionary<Int64, Funcionario>();
            try
            {
                String SQL = "SELECT * FROM funcionario WHERE ";

                Int64 saida;
                if (Int64.TryParse(_filtro, out saida))
                {
                    SQL += String.Format("matricula = {0}", _filtro);
                }
                else
                {
                    SQL += String.Format("nome LIKE '%{0}%'", _filtro);
                }

                SQL += " ORDER BY matricula;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Funcionario p = new Funcionario();

                    p.Matricula = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Cargo = data.GetString(2);
                    p.Endereco = data.GetString(3);
                    p.Telefone = data.GetString(4);


                    mapaFuncionario.Add(p.Matricula, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELOS FILTROS / " + ex.Message);
            }

            return mapaFuncionario;
        }

        public Funcionario BuscarPorMATRICULA(Int64 _matricula)
        {
            Funcionario p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM funcionario WHERE matricula = {0};", _matricula);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Funcionario();

                    p.Matricula = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Cargo = data.GetString(2);
                    p.Endereco = data.GetString(3);
                    p.Telefone = data.GetString(4);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELO CPF / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Funcionario _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                

                String SQL = String.Format("INSERT INTO funcionario (" +
                    "matricula," +
                    "nome," +
                    "cargo," +
                    "endereco," +
                    "telefone," +
                    ") " +
                    "VALUES ({0}, '{1}', '{2}', '{3}', '{4}');",
                    _obj.Matricula,
                    _obj.Nome,
                    _obj.Cargo,
                    _obj.Endereco,
                    _obj.Telefone                  
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

        public Boolean Deletar(Int64 _matricula)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM funcionario WHERE matricula = " + _matricula;

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

        public Boolean Alterar(Funcionario _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE funcionario SET " +
                    "nome = '{0}'," +
                    "cargo = '{1}'," +
                    "endereco = '{2}'," +
                    "telefone = '{3}'," +                  
                    " WHERE matricula = {10}",
                    _obj.Nome,
                    _obj.Cargo,
                    _obj.Endereco,
                    _obj.Telefone,
                    _obj.Matricula
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
