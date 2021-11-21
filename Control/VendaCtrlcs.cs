using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Control
{
    class VendaCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            VendaDAO dao = new VendaDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Venda)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Venda)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "pagamento":
                    return dao.BuscarPorIdVenda((Int64)_parametro);
                case "filtro":
                    return dao.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }
    }
}


