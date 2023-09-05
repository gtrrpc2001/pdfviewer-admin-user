using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.data
{
    public class dataModel
    {
        public string code { get; set; }
        public string path { get; set; }
        public int page { get; set; }

        public dataModel(string Code, string Path, int Page)
        {
            code = Code;
            path = Path;
            page = Page;
        }
    }
}
