using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.data
{
    public class clsDataQuery : dataController
    {
        private static string DBname;
        private static string Gubun;
        private static MysqlController myCon;
        public clsDataQuery()
        {
            myCon = ExtensionSource.myCon;
            DBname = ExtensionSource.DBname;
            Gubun = ExtensionSource.Gubun;
        }
        public DataTable GetSelectData()
        {
            string sql = $"SELECT * FROM tv WHERE tv_gubun = '{Gubun}' ORDER BY tv_Page ASC";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public bool GetDataUpdate(string NodePath, int newPage)
        {
            string sql = $"UPDATE tv SET tv_Page = {newPage} WHERE tv_gubun = '{Gubun}' AND tv_Name = '{NodePath}'";
            try
            {
                myCon.My_EXECUTE(sql, DBname);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool GetDataUpdate(string NodePath, string NewCode, int newPage)
        {
            string sql = $"UPDATE tv SET tv_Code = '{NewCode}',tv_Page = {newPage} WHERE tv_gubun = '{Gubun}' AND tv_Name = '{NodePath}'";
            try
            {
                myCon.My_EXECUTE(sql, DBname);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
