using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class.clsQuery;
using pdfViewer.Class.pdfCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsNode
{
    public class clsNodeEditor : clsNodeController
    {
        private MysqlController myCon = ExtensionSource.myCon;
        private string DBname = ExtensionSource.DBname;
        private string Gubun = ExtensionSource.Gubun;
        public clsNodeEditor()
        {

        }
        public int UpdateDataBaseIndex(string Fullpath)
        {
            var dT = clsQueryController.SelectTv.GetSelect_No(Fullpath);
            var dR = dT.Rows.Count > 0 ? dT.Rows : null;
            var tv_no = default(int);
            if (dR != null)
            {
                tv_no = Conversions.ToInteger(dR[0]["tv_no"]);
            }
            return tv_no + 1;
        }
        public bool GetDataUpdate(string Where, string fullPath, string tv_name, int tv_dup, int page, string pdfCode, ref int auto, bool NodekeyChecked)
        {
            var dT = clsQueryController.SelectTv.GetSelectAll(Where);
            if (dT.Rows.Count > 0)
            {
                auto = Conversions.ToInteger(dT.Rows[0]["tv_auto"]);
                var NodeText = dT.Rows[0]["tv_name"].ToString().Replace(fullPath, "");
                // 여기부분
                if (NodekeyChecked)
                {
                    if (NodeText != tv_name)
                        tv_name = NodeText;
                }
                if (NodeText != tv_name)
                {
                    for (int i = 0, loopTo = dT.Rows.Count - 1; i <= loopTo; i++)
                        clsCodeController.Editor.FullPathUpdate(dT.Rows[i]["tv_name"] + "|", fullPath + tv_name);
                }
                if (dT.Rows[0]["tv_Code"].ToString() != pdfCode | Conversions.ToInteger(dT.Rows[0]["tv_dup"]) != tv_dup | NodeText != tv_name)
                {
                    clsQueryController.UpdateTv.SetNodeUpdate(tv_name, fullPath, pdfCode, tv_dup, page,ref auto);
                }
                return true;
            }
            return false;
        }
        public void SetFirstNodeEdit(DataTable dT, string tv_name, string filename, int dup, int i, int page, bool UpdateOnlyIndex, [Optional, DefaultParameterValue(0)] ref int auto)
        {
            if (dT.Rows.Count > 0)
            {
                DataRow dR = dT.Rows[0];
                string Where = $"WHERE tv_gubun = '{Gubun}' AND tv_no = 0 AND tv_dup = {dup} AND tv_auto <> {auto}";
                string SelectCol = "";
                if (UpdateOnlyIndex == false)
                {
                    if (dR["tv_name"].ToString() != tv_name)
                        clsCodeController.Editor.FullPathUpdate(dR["tv_name"] + "|", tv_name);
                    SelectCol = $"tv_name = '{tv_name}', tv_dup = {i} ";
                }
                else
                {
                    SelectCol = $"tv_dup = {i} ";
                    Where += $" AND tv_name LIKE '{tv_name}%'";
                }
                if (!string.IsNullOrEmpty(filename))
                    SelectCol += $",tv_Code = '{filename}',tv_Page = {page} ";
                string sql = $"UPDATE tv SET {SelectCol} {Where}";
                myCon.My_EXECUTE(sql, DBname);
                auto = Conversions.ToInteger(dR["tv_auto"]);
            }
        }
    }
}
