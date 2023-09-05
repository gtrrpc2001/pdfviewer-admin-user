using FarPoint.Win.Spread;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsPdf
{
    public class clsPdfController
    {
        private static clsPdfSelect _Select;
        private static clsPdfSave _Save;
        private static clsPdfSearch _Search;
        public static clsPdfSelect Select
        {
            get
            {
                if (_Select is null)
                    _Select = new clsPdfSelect();
                return _Select;
            }
        }
        public static clsPdfSave Save
        {
            get
            {
                if (_Save is null)
                    _Save = new clsPdfSave();
                return _Save;
            }
        }
        public static clsPdfSearch Search
        {
            get
            {
                if (_Search is null)
                    _Search = new clsPdfSearch();
                return _Search;
            }
        }
        public static bool pdfCodeChecked(SheetView sv)
        {
            var strList = new List<string>();
            for (int i = 0, loopTo = sv.GetLastNonEmptyRow(NonEmptyItemFlag.Data); i <= loopTo; i++)
            {
                var value = sv.Cells[i, sv.Columns["pdfCode"].Index].Value.ToString();
                if (sv.Cells[i, sv.Columns["pdfCode"].Index].Value != null)
                {
                    if (strList.Contains(value))
                        return true;
                    strList.Add(value);
                }
            }
            return false;
        }
        public static bool GetFileExist(string path)
        {
            return File.Exists(path);
        }
    }
}
