using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Control
{
    class PagamentoCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            PagamentoDAO dao = new PagamentoDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Pagamento)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Pagamento)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "pagamento":
                    return dao.BuscarPorIdPagamento((Int64)_parametro);
                case "filtro":
                    return dao.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }
    }
}


