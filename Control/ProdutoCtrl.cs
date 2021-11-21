using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Control
{
    class ProdutoCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
             ProdutoDAO dao = new ProdutoDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Produto)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Produto)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "produto":
                    return dao.BuscarPorIdProduto((Int64)_parametro);
                case "filtro":
                    return dao.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }
    }
}

