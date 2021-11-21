using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Control
{
    public class ClienteCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            ClienteDAO dao = new ClienteDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Cliente)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Cliente)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "cliente":
                    return dao.BuscarPorCPF((Int64)_parametro);
                case "filtro":
                    return dao.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }
    }
}