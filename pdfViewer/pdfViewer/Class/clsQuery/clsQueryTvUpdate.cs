using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsQuery
{
    public class clsQueryTvUpdate : clsQueryController
    {
        public clsQueryTvUpdate()
        {

        }
        private MysqlController myCon = ExtensionSource.myCon;
        private string Gubun = ExtensionSource.Gubun;
        private string DBname = ExtensionSource.DBname;
        public void SetUpdateIndexAfterDelete(string name, int index)
        {
            string sql = $@"SET @tv_dup:=-1;
    UPDATE tv SET tv_dup = @tv_dup := @tv_dup + 1 WHERE tv_gubun = '{Gubun}' AND tv_no = {index}";
            if (index != 0 | !string.IsNullOrEmpty(name))
                sql += $" AND tv_name LIKE '{name}%'";
            sql += " ORDER BY tv_dup";
            myCon.My_EXECUTE(sql, DBname);
        }
        public void SetNodeUpdate(string tv_name, string fullPath, string pdfCode, int tv_dup, int page, ref int auto)
        {
            string Sql = $@"UPDATE tv 
SET tv_name = '{fullPath + tv_name}',tv_dup = {tv_dup} ,tv_Code = '{pdfCode}', tv_Page = {page}
WHERE tv_gubun = '{Gubun}' AND tv_auto = {auto}";
            myCon.My_EXECUTE(Sql, DBname);
        }
        public void SetNodeUpdate(string tv_name, string Afterfullpath, string pdfName)
        {
            string where = $"WHERE tv_gubun = '{Gubun}' AND tv_name = '{tv_name}'";
            string sql = $"UPDATE tv SET tv_name = '{Afterfullpath}' ";
            if (!string.IsNullOrEmpty(pdfName))
            {
                sql += $",tv_Code = '{pdfName}' ";
            }
            sql += where;
            myCon.My_EXECUTE(sql, DBname);
        }
        public void SetPathUpdate(string newName, string svOldName, int No, int dup)
        {
            string Sql = $@"UPDATE tv SET tv_name = '{newName}' 
WHERE tv_gubun = '{Gubun}' AND tv_no = {No} AND tv_dup = {dup} AND tv_name LIKE '{svOldName}%'";
            myCon.My_EXECUTE(Sql, DBname);
        }
    }
}
