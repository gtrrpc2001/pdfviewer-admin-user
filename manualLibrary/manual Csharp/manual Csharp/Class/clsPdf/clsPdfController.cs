using DevExpress.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manual_Csharp.Class.clsPdf
{
  public class clsPdfController
  {
    #region "전역"
    private static clsPdfSelect _Select;
    private static clsPdfSave _Save;
    private static clsPdfEdit _Edit;
    private static clsPdfQuery _Query;
    #endregion

    #region "property"
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
    public static clsPdfEdit Edit
    {
      get
      {
        if (_Edit is null)
          _Edit = new clsPdfEdit();
        return _Edit;
      }
    }
    public static clsPdfQuery Query
    {
      get
      {
        if (_Query is null)
          _Query = new clsPdfQuery();
        return _Query;
      }
    }
    #endregion

    public static void SetPDFclose(PdfDocumentProcessor pdf)
    {
      pdf.CloseDocument();
      pdf.Dispose();
    }
    public static bool GetFileExist(string path)
    {
      return File.Exists(path);
    }
  }
}
