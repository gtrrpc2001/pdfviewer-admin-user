using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsQuery
{
    public class clsQueryTVselect : clsQueryController
    {
        private MysqlController myCon = ExtensionSource.myCon;
        private string Gubun = ExtensionSource.Gubun;
        private string DBname = ExtensionSource.DBname;
        public DataTable GetSelect_No(string fullPath)
        {
            string sql = $@"SELECT tv_no FROM tv 
WHERE tv_gubun = '{Gubun}' AND tv_name = '{fullPath}' 
ORDER BY tv_no, tv_dup ASC";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public DataTable GetSelectAll(string where)
        {
            string sql = $@"SELECT * FROM tv
WHERE {where}";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public DataTable GetSelect_Count(string fullPath)
        {
            string sql = $@"SELECT tv_no FROM tv 
WHERE tv_gubun = '{Gubun}' AND tv_name LIKE '{fullPath}|%' 
ORDER BY tv_no, tv_dup ASC";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public DataTable GetJoinSelect_Code_No()
        {
            string Sql = $@"SELECT tv_no,tv_name,tv_dup,tv_Code FROM tv
WHERE tv_gubun = '{Gubun}'
ORDER BY tv_no,tv_dup ASC";
            var dT = myCon.My_SELECT(Sql, DBname);
            return dT;
        }
        public DataTable GetSelect_Node(string fullPath)
        {
            string Sql = $@"SELECT tv_name,tv_dup,tv_Code,tv_Page FROM tv
WHERE tv_gubun = '{Gubun}' AND tv_name LIKE '{fullPath}|%'
ORDER BY tv_no,tv_dup ASC";
            var dT = myCon.My_SELECT(Sql, DBname);
            return dT;
        }
        public DataTable GetSelectFirstNode()
        {
            string sql = $@"SELECT tv_name,tv_dup,tv_Code,tv_Page FROM tv
Where tv_gubun = '{Gubun}' AND tv_no = 0
ORDER BY tv_dup ASC";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public DataTable GetSelectFirstNode(string tv_name, int dup, int auto, bool UpdateOnlyIndex)
        {
            string sql = $@"SELECT tv_auto,tv_name,tv_Code FROM tv
WHERE tv_gubun = '{Gubun}' AND tv_no = 0";
            if (UpdateOnlyIndex)
            {
                sql += $" AND tv_name = '{tv_name}' ";
            }
            sql += $@" AND tv_dup = {dup} AND tv_auto <> {auto}
ORDER BY tv_dup ASC";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public DataTable GetJoinCode_PageSelect(string fullPath)
        {
            string sql = $@"SELECT tv_auto,tv_name ,tv_Code,tv_Page FROM tv
WHERE tv_gubun = '{Gubun}' AND tv_name LIKE '{fullPath}%'
ORDER BY tv_no ASC";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
        public DataTable GetFullPahSelect(string selectOldname)
        {
            string Sql = $@"SELECT tv_no,tv_name,tv_dup FROM tv
WHERE tv_gubun = '{Gubun}' AND tv_no <> 0 AND tv_name LIKE '{selectOldname}%'
ORDER BY tv_no,tv_dup ASC";
            var dT = myCon.My_SELECT(Sql, DBname);
            return dT;
        }
        public DataTable GetSelectPDFpage(string fullpath)
        {
            string sql = $@"SELECT tv_Page FROM tv
WHERE tv_gubun = '{Gubun}' AND tv_Name = '{fullpath}'";
            var dT = myCon.My_SELECT(sql, DBname);
            return dT;
        }
    }
}
