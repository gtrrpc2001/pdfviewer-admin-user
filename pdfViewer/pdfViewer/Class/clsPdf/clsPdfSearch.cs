using DevExpress.Pdf;
using Microsoft.VisualBasic.CompilerServices;
using pdfViewer.Class.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsPdf
{
    public class clsPdfSearch : clsPdfController
    {
        public int CheckedPage(string keyword, string pdfSrc, ref int nowPage)
        {
            var proc = new PdfDocumentProcessor();
            proc.LoadDocument(pdfSrc);
            var pages = proc.Document.Pages.Count;
            repeat:
            ;
            for (int i = nowPage, loopTo = pages - 1; i <= loopTo; i++)
            {
                var txt = proc.GetPageText(i);
                if (txt.Contains(keyword))
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(i, nowPage, false)))
                    {
                        nowPage = Conversions.ToInteger(i);
                        dataController.SetPDFclose(proc);
                        return nowPage;
                    }
                }
                if (nowPage != 0)
                {
                    if (Operators.ConditionalCompareObjectEqual(i, pages - 1, false))
                    {
                        nowPage = 0;
                        goto repeat;
                    }
                }
            }
            dataController.SetPDFclose(proc);
            return default;          
        }
    }
}
