using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gb = manual_Csharp.Class.clsStatic;

namespace manual_Csharp.Class.clsPdf
{
  public class clsPdfSave : clsPdfController
  {
    #region "private fields"
    private string httpPdfUrl = "http://www.xn--py2b07lbpnmgc83d.xn--3e0b707e/emr/manual/";
    private string httpVersionUrl = "http://www.xn--py2b07lbpnmgc83d.xn--3e0b707e/emr/manual/";
    private string fixPath;
    private string pathVerision;
    private string pathPdf;
    private int prevPDFByte;
    #endregion

    #region "private methods"
    private string GetDirectoryPath()
    {
      var dirPath = Application.StartupPath + @"\manual";
      var di = new DirectoryInfo(dirPath);
      if (!di.Exists)
        di.Create();
      return di.FullName;
    }

    private string GetVersion(string Url)
    {
      string result = "";
      using (var Client = new HttpClient())
      {
        repeat:;
        var txt = Client.GetStringAsync(Url);
        if (txt.Result is null)
          goto repeat;
        txt.Wait();
        result = txt.Result.ToString();
        txt.Dispose();
      }
      var bytesResult = result.Split(Convert.ToChar(Constants.vbCrLf))[1].Trim().Replace("Pdfbyte = ", "");
      int.TryParse(bytesResult, out prevPDFByte);
      return result;
    }

    private bool GetDownChecked(string Url, string path)
    {
      if (!GetFileExist(path))
      {
        SetDown(Url, path);
        return true;
      }
      else
      {
        if (!GetByteChecked(path))
        {
          SetDown(Url, path);
          return true;
        }
      }
      return false;
    }

    private bool GetByteChecked(string path)
    {
      if (path.Contains(".txt"))
        return true;
      var prevFile = File.ReadAllBytes(path);
      if (prevPDFByte != prevFile.Length)
        return false;
      return true;
    }

    private void SetDown(string Url, string path)
    {
      var net = new Network();
      net.DownloadFile(Url, path, "", "", true, 100, true);
    }
    #endregion
    public clsPdfSave()
    {
      fixPath = GetDirectoryPath();
      pathVerision = Path.Combine(fixPath, GetFileName());
      pathPdf = Path.Combine(fixPath, GetPDFName());
      httpPdfUrl = GetPDFpath();
      httpVersionUrl = GetVersionPath();
    }

    private string GetFileName()
    {
      string name = "";
      if (gb.Gubun != "0")
      {
        name = "유통manualVersion.txt";
      }
      else
      {
        name = "manualVersion.txt";
      }
      return name;
    }

    private string GetPDFName()
    {
      string name = "";
      if (gb.Gubun != "0")
      {
        name = "u클릭설명서.pdf";
      }
      else
      {
        name = "e클릭설명서.pdf";
      }
      return name;
    }

    private string GetPDFpath()
    {
      string path = "";
      if (gb.Gubun != "0")
      {
        path = "http://www.xn--py2b07lbpnmgc83d.xn--3e0b707e/emr/manual/u클릭설명서.pdf";
      }
      else
      {
        path = "http://www.xn--py2b07lbpnmgc83d.xn--3e0b707e/emr/manual/e클릭설명서.pdf";
      }
      return path;
    }

    private string GetVersionPath()
    {
      string path = "";
      if (gb.Gubun != "0")
      {
        path = "http://www.xn--py2b07lbpnmgc83d.xn--3e0b707e/emr/manual/유통manualVersion.txt";
      }
      else
      {
        path = "http://www.xn--py2b07lbpnmgc83d.xn--3e0b707e/emr/manual/manualVersion.txt";
      }
      return path;
    }

    public void SetUpdate()
    {
      var fileExist = GetFileExist(pathVerision);
      var oldVersion = fileExist == true ? File.ReadAllText(pathVerision) : "";
      SetChangePath();
      var newVersion = GetVersion(httpVersionUrl);
      var pdfDownChecked = GetDownChecked(httpPdfUrl, pathPdf);
      var versionDownChecked = GetDownChecked(httpVersionUrl, pathVerision);
      if (oldVersion != newVersion)
      {
        if (!versionDownChecked)
          SetDown(httpVersionUrl, pathVerision);
        if (!pdfDownChecked)
          SetDown(httpPdfUrl, pathPdf);
      }
    }

    private void SetChangePath()
    {
      httpVersionUrl = GetVersionPath();
      httpPdfUrl = GetPDFpath();
    }

  }
}
