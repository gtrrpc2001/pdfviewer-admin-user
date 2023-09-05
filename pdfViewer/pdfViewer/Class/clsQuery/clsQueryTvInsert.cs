using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsQuery
{
    public class clsQueryTvInsert : clsQueryController
    {
        public clsQueryTvInsert()
        { 
        
        }
        private string Gubun = ExtensionSource.Gubun;
        private MysqlController myCon = ExtensionSource.myCon;
        private string DBname = ExtensionSource.DBname;
        public void SetTVinsert(string tv_name, string Code, int i, int page, ref int auto)
        {
            string sql = $@"INSERT INTO tv(tv_gubun,tv_no,tv_name,tv_dup,tv_Code,tv_Page)VALUES
('{Gubun}',0,'{tv_name}',{i},'{Code}',{page});";           
            myCon.My_EXECUTE(sql, DBname,ref auto);
            
        }
    }
}
