using DevExpress.Pdf;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfViewer.Class.data
{
    public class dataController
    {
        private static clsDataQuery _Query;
        public static clsDataQuery DataQuery
        {
            get
            {
                if (_Query is null)
                    _Query = new clsDataQuery();
                return _Query;
            }
            set
            {
                _Query = value;
            }
        }
        public static List<dataModel> GetDataList()
        {
            var dataList = new List<dataModel>();
            var dT = DataQuery.GetSelectData();
            foreach (DataRow dR in dT.Rows)
                dataList.Add(new dataModel(dR["tv_Code"].ToString(), dR["tv_Name"].ToString(),Conversions.ToInteger(dR["tv_Page"])));
            return dataList;
        }
        public static List<int> GetCodeCountChecked(List<string> Filepath, string Code)
        {
            string pdfPath = GetPdfPath(Filepath);
            var pageList = GetCodeCheckPageList(pdfPath, Code);
            return pageList;
        }
        public static List<int> GetCodeCountChecked(string Filepath, string Code)
        {
            string pdfPath = Filepath;
            var pageList = GetCodeCheckPageList(Filepath, Code);
            return pageList;
        }
        private static List<int> GetCodeCheckPageList(string pdfPath, string Code)
        {
            var pdf = new PdfDocumentProcessor();
            pdf.LoadDocument(pdfPath);
            var pages = pdf.Document.Pages.Count;
            if (Code.Contains("|"))
            {
                return GetCode_Enter(pdf, Code, pages);
            }
            else
            {
                return GetCode_NoEnter(pdf, Code, pages);
            }
            SetPDFclose(pdf);
        }
        private static List<int> GetCode_Enter(PdfDocumentProcessor pdf, string Code, int pages)
        {
            var intList = new List<int>();
            string searchTxt = Code.Replace("|", Constants.vbCrLf);
            char word = Conversions.ToChar("|");
            var strArr = Code.Split(word).ToArray();
            for (int i = 5, loopTo = pages - 1; i <= loopTo; i++)
            {
                var txt = pdf.GetPageText(i);
                if (txt.Contains(searchTxt))
                {
                    intList.Add(i);
                }
            }
            if (intList.Count == 0)
                intList.Add(0);
            return intList;
        }
        private static List<int> GetCode_NoEnter(PdfDocumentProcessor pdf, string Code, int pages)
        {
            var intList = new List<int>();
            int prevPdfPage = 0;
            int pdfPage = 0;
            for (int j = 0, loopTo = pages - 1; j <= loopTo; j++)
            {
                prevPdfPage = pdf.FindText(Code).PageNumber;
                if (pdfPage != prevPdfPage)
                {
                    pdfPage = prevPdfPage;
                    foreach (var Page in intList)
                    {
                        if (Page == pdfPage)
                            return intList;
                    }
                    if (pdfPage != 0)
                        intList.Add(pdfPage);
                }
            }
            if (intList.Count == 0)
                intList.Add(0);
            return intList;
        }
        public static string GetPdfPath(List<string> Filepath)
        {
            var pdfPath = (from p in Filepath
                           where p.Contains(".pdf")
                           select p).ToArray();
            return pdfPath[0];
        }
        public static void SetDataUpdate(ProgressBarControl bar, string filePath)
        {
            var dataList = GetDataList();
            int i = 0;
            foreach (var _Data in dataList)
            {
                i += 1;
                var dataCheckList = GetCodeCountChecked(filePath, _Data.code);
                if (dataCheckList.Count == 1)
                {
                    DataQuery.GetDataUpdate(_Data.path, dataCheckList[0]);
                }
                else
                {
                    Interaction.MsgBox($"중복되는 코드가 {dataCheckList.ToArray()} 페이지에서 발견 됬습니다.");
                    return;
                }
                SetBarValue(bar, dataList.Count, i);
            }
        }
        public static void SetBarValue(ProgressBarControl bar, int dataCount, int row)
        {
            float value = (float)(100d * (row / (double)dataCount));
            bar.EditValue = value;
            Application.DoEvents();
        }
        public static void SetPDFclose(PdfDocumentProcessor pdf)
        {
            pdf.CloseDocument();
            pdf.Dispose();
        }
    }
}
