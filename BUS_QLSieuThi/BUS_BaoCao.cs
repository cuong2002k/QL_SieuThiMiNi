using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSieuThi;
namespace BUS_QLSieuThi
{
   public class BusBaoCao
    {
        DALBaoCao dalbaocao = new DALBaoCao();
        public DataTable dshanghoaban()
        {
            return dalbaocao.dshanghoaban();
        }
        public DataTable dsnhanvien()
        {
            return dalbaocao.dsnhanvien();
        }
    }
}
