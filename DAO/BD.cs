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
        //Data Source=C:\Users\lscamacho\Documents\Faculdade\CTPI\AppAula20212-master\BD.sdf;Password=1998
        public static void AbrirConexao() 
        {
            
        }

        public static void FecharConexao() 
        {

        }
        public static DataTableReader ExecutarSelect(String _SQL)
        {

        }
        public static int ExecutarIDU(String _SQL)
        {

        }
        public static int ExecutarIDU(String _SQL, List<SqlCeParameter> parameters)
        {

        }
        public static Object ExecutarInsertComRetornoDeValor(String _Sql, List<SqlCeParameter> parameters)
        {

        }
    }
}
