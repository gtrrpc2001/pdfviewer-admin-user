using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class.clsQuery
{
    public class clsQueryDelete : clsQueryController
    {
        public clsQueryDelete()
        {

        }
        private MysqlController myCon = ExtensionSource.myCon;
        private string Gubun = ExtensionSource.Gubun;
        private string DBname = ExtensionSource.DBname;
        public void SetNodeDelete(string fullPath, TreeNode selectedNode)
        {
            string Sql = $@"DELETE FROM tv
WHERE tv_gubun = '{Gubun}' AND tv_name LIKE '{fullPath}%'";
            myCon.My_EXECUTE(Sql, DBname);
        }
        public void GetPDFdelete(string fullpath)
        {
            string Sql = $@"UPDATE tv SET tv_Code = '', tv_Page = 0
WHERE tv_gubun = '{Gubun}' AND tv_name = '{fullpath}'";
            myCon.My_EXECUTE(Sql, DBname);
        }
    }
}
