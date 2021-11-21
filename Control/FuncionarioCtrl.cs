using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Control
{
    class FuncionarioCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Funcionario)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Funcionario)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "funcionario":
                    return dao.BuscarPorMATRICULA((Int64)_parametro);
                case "filtro":
                    return dao.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }
    }
}

