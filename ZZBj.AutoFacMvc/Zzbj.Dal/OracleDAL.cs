using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zzbj.IDal;

namespace Zzbj.Dal
{
    public class OracleDAL : IDAL
    {
        public void Insert(string commandText)
        {
            Console.WriteLine("使用OracleDAL添加相关信息");
        }
    }
}
