using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace crudMySql.BLL
{
    internal class FornecedorBLL
    {
        Conexao objDAL = new Conexao();
        string tabela = "tbl_fornecedor";
        public DataTable ListarCategorias()
        {
            return objDAL.ExecutarConsulta($"select * from {tabela} order by descricao;");
        }
    }
        public DataTable ListarCategorias()
        {
            return objDAL.ExecutarConsulta($"select * from {tabela} order by descricao;");
        }
}
