using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class.clsQuery;
using pdfViewer.Class.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsPdf
{
    public class clsPdfSelect : clsPdfController
    {
        public int GetPDFpage(string tv_name)
        {
            var dT = clsQueryController.SelectTv.GetSelectPDFpage(tv_name);
            DataRow dR = dT.Rows[0];
            return Conversions.ToInteger(dR["tv_Page"]);
        }
        public int GetCodePage(string pdfPath, string Code)
        {
            var pageList = dataController.GetCodeCountChecked(pdfPath, Code);
            if (pageList.Count() == 1)
                return pageList[0];
            return -1;
        }
    }
}
