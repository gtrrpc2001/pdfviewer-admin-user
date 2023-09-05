using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manual_Csharp.Class
{
 public class clsManual
  {
    public void ShowManual(string fullpath,string gubun = "0")
    {
      var OpenForm = Application.OpenForms["FrmManual"];
      FrmManual frmM;
      if (OpenForm is null)
      {
        try
        {
          frmM = new FrmManual(fullpath, gubun);
          frmM.Show();
          frmM.Activate();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else
      {
        frmM = OpenForm as FrmManual;
        frmM.myOpenChecked = true;
        frmM.fullpath = fullpath;
        frmM.Activate();
      }
    }
  }
}
