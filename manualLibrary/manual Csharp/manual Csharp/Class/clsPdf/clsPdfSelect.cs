using DevExpress.Pdf;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using gb = manual_Csharp.Class.clsStatic;

namespace manual_Csharp.Class.clsPdf
{
  public class clsPdfSelect : clsPdfController
  {
    public int GetPDFpage(string tv_name, [Optional, DefaultParameterValue(0)] ref int prevHeaderPage, [Optional, DefaultParameterValue(0)] ref int NextHeaderPage)
    {
      var dT = Query.GetPdfCurrentPageDT(tv_name);
      if (dT.Rows.Count == 0)
      {
        SetPageClear(ref prevHeaderPage, ref NextHeaderPage);
        return 0;
      }

      var dR = dT.Rows[0];
      int Page = Convert.ToInt32(dR["tv_page"]);
      return Page;
    }

    private int[] GetJiwonPageSelect(string fullpath, int pdfCount)
    {
      int firstPage = 1;
      int lastPage = pdfCount;
      var dT = Query.GetPdfJiwonPrintPageDT(fullpath);
      if (dT.Rows.Count > 0)
      {
        var dR = dT.Rows[0];
        firstPage = Convert.ToInt32(dR["tv_page"]);
        if (dR["tv_dup"] == dR["max_dup"])
        {
          dT = Query.GetpdfJiwonMaxDup_PrintPageDT(Convert.ToInt32(dR["parent_dup"]) + 1);
          if (dT.Rows.Count > 0)
            lastPage = Convert.ToInt32(dT.Rows[0]["page"]) + 1;
        }
        else
        {
          dT = Query.GetPdfJiwonNextPrintPageDT(Convert.ToInt32(dR["tv_dup"]) + 1);
          if (dT.Rows.Count > 0)
            lastPage = Convert.ToInt32(dT.Rows[0]["tv_page"]) - 1;
        }
      }
      return GetPageArray(firstPage, lastPage);
    }

    private int[] GetPrintPageSelect(string fullpath, int pdfCount)
    {
      int firstPage = 1;
      int lastPage = pdfCount;
      var parentPath = fullpath.Split(Convert.ToChar("|"))[0];
      var dT = Query.GetPdfPrintFirstPageDT(parentPath);
      if (dT.Rows.Count > 0)
      {
        var dR = dT.Rows[0];
        firstPage = Convert.ToInt32(dR["min(tv_page)"]);
        var parentDup = Convert.ToInt32(dR["parent_dup"]);
        dT = Query.GetPdfPrintLastPageDT(Convert.ToString(parentDup + 1));
        if (dT.Rows.Count > 0)
          lastPage = Convert.ToInt32(dT.Rows[0]["lastPage"]) - 1;
      }
      return GetPageArray(firstPage, lastPage);

    }

    private int[] GetPageArray(int firstPage, int lastPage)
    {
      var pageArr = new List<int>();
      for (int i = 0, loopTop = lastPage; i <= loopTop; i++)
      {
        pageArr.Add(i);
      }
      return pageArr.ToArray();
    }

    public MemoryStream GetPdfPageCompare(string fullpath, string path, int PdfPageCount, ref int[] pageRange)
    {
      pageRange = GetPageSelect(fullpath, PdfPageCount);
      var PageLoadControl = new PdfDocumentProcessor();
      PageLoadControl.LoadDocument(path);
      var delPages = new List<int>();
      for (int i = 1, loopTop = PdfPageCount; i <= loopTop; i++)
      {
        if (!pageRange.Contains(i))
          delPages.Add(i);
      }
      PageLoadControl.DeletePages(delPages);
      var ms = new MemoryStream();
      PageLoadControl.SaveDocument(ms);
      return ms;
    }
    public int[] GetPageSelect(string fullpath, int PdfPageCount)
    {
      int[] pageRange = null;
      if (fullpath.Contains("지원실"))
      {
        pageRange = GetJiwonPageSelect(fullpath, PdfPageCount);
      }
      else
      {
        pageRange = GetPrintPageSelect(fullpath, PdfPageCount);
      }
      return pageRange;
    }

    private void SetPageClear(ref int prevHeaderPage, ref int NextHeaderPage)
    {
      prevHeaderPage = 0;
      NextHeaderPage = 0;
    }
  }
}
