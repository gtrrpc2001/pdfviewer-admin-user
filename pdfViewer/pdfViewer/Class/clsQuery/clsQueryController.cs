using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfViewer.Class.clsQuery
{
    public class clsQueryController
    {
        private static clsQueryTvInsert _InsertTv;
        private static clsQueryTvUpdate _UpdateTv;
        private static clsQueryDelete _DeleteNodeCode;
        private static clsQueryTVselect _SelectTv;

        public static clsQueryTvInsert InsertTv
        {
            get
            {
                if (_InsertTv is null)
                    _InsertTv = new clsQueryTvInsert();
                return _InsertTv;
            }
        }

        public static clsQueryTvUpdate UpdateTv
        {
            get
            {
                if (_UpdateTv is null)
                    _UpdateTv = new clsQueryTvUpdate();
                return _UpdateTv;
            }
        }

        public static clsQueryDelete Delete
        {
            get
            {
                if (_DeleteNodeCode is null)
                    _DeleteNodeCode = new clsQueryDelete();
                return _DeleteNodeCode;
            }
        }

        public static clsQueryTVselect SelectTv
        {
            get
            {
                if (_SelectTv is null)
                    _SelectTv = new clsQueryTVselect();
                return _SelectTv;
            }
        }
    }
}
