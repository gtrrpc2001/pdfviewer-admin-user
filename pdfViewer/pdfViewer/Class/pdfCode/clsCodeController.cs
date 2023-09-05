using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.pdfCode
{
   public class clsCodeController
    {

        private static MysqlController myCon = ExtensionSource.myCon;
        private static string DBname = ExtensionSource.DBname;
        private static string Gubun = ExtensionSource.Gubun;
        private static clsCodeEditor _Editor;
        public static clsCodeEditor Editor
        {
            get
            {
                if (_Editor is null)
                    _Editor = new clsCodeEditor();
                return _Editor;
            }
        }
        public static bool GetCodeChecked(string Code, string fullpath)
        {
            string sql = $"SELECT tv_Name,tv_Code FROM tv WHERE tv_Code = '{Code}' AND tv_Code <> ''";
            var dT = myCon.My_SELECT(sql, DBname);
            var dR = dT.Rows.Count > 0 ? dT.Rows[0] : null;
            if (dR is null)
                return false;
            if ((fullpath ?? "") != (dR["tv_Name"].ToString() ?? ""))
            {
                Interaction.MsgBox("이미 저장된 코드입니다.");
                return true;
            }
            else if ((fullpath ?? "") == (dR["tv_Name"].ToString() ?? ""))
            {
                return true;
            }

            return default;
        }
    }
}
