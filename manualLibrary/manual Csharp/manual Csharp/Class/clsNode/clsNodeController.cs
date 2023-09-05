using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manual_Csharp.Class.clsNode
{
  public class clsNodeController
  {
    private static clsNodeSelect _Select;
    private static clsNodeQuery _Query;
    public static clsNodeSelect Select
    {
      get
      {
        if (_Select is null)
          _Select = new clsNodeSelect();
        return _Select;
      }
    }
   public static clsNodeQuery Query
    {
      get
      {
        if (_Query is null)
          _Query = new clsNodeQuery();
        return _Query;
      }
    }

    public static void DevAcc_FilterContent(Control.ControlCollection Controls)
    {
      foreach (Control control in Controls)
      {
        var filter = control as AccordionSearchControl;
        if (filter != null)
        {
          filter.NullValuePrompt = "검색";
          break;
        }
      }
    }
  }
}
