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

namespace pdfViewer.Class.clsPdf
{
    public class clsPdfSave : clsPdfController
    {
        private string fixPath;
        private string pathVerision;
        private string pathPdf;
        public clsPdfSave()
        {
            fixPath = GetDirectoryPath();
            pathVerision = Path.Combine(fixPath, "manualVersion.txt");
            pathPdf = Path.Combine(fixPath, "e클릭설명서.pdf");
        }
        public string GetDirectoryPath()
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
                repeat:
                ;
                var txt = Client.GetStringAsync(Url);
                if (txt.Result is null)
                    goto repeat;
                txt.Wait();
                result = txt.Result.ToString();
                txt.Dispose();
            }
            return result;
        }
        private bool GetDownChecked(string Url, string path)
        {
            if (!GetFileExist(path))
            {
                SetDown(Url, path);
                return true;
            }
            return false;
        }

        private static void SetDown(string Url, string path)
        {
            var net = new Network();
            net.DownloadFile(Url, path, "", "", true, 100, true);
        }
        public void SetUpdate(string filepath,string fileName)
        {
            // SetCreateFold()
            try
            {
                if (fileName.Contains(".pdf"))
                {
                SetDown(filepath, pathPdf);            // 
                Interaction.MsgBox("PDF저장이 완료되었습니다...");
                }
                else
                {
                    SetDown(filepath, pathVerision);
                    Interaction.MsgBox("새로운 버전이 저장이 완료되었습니다...");
                }
            }
            catch
            {
                try
                {
                    var fs = new ServerComputer();
                    if (fileName.Contains(".pdf"))
                    {
                    fs.FileSystem.CopyFile(filepath, pathPdf, true);
                    }
                    else
                    {
                        fs.FileSystem.CopyFile(filepath, pathVerision, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Constants.vbCrLf + "PDF를 화면에서 지우고 시도해보세요!");
                }
            }
        }
        public void SetUpload(string Filepath, string fileName, string version)
        {
            var savePath = new SaveFileDialog() { FileName = fileName };            
            savePath.ShowDialog();
            var newPath = savePath.FileName;
            // My.MySettings.Default.ftp_ip
            string user = ""; // My.MySettings.Default.ftp_user
            string pwd = ""; // My.MySettings.Default.ftp_pwd
            if (fileName.Contains(".txt"))
            {
                string NextVersion = "version =" + (Conversion.Val(version.Replace("version =", "")) + 1d);
                File.WriteAllText(Filepath, NextVersion);
            }
            var net = new Network();
            try
            {
            net.UploadFile(Filepath, newPath, user, pwd, true, 100, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
            }
            catch
            {

            }
        }
    }
}
