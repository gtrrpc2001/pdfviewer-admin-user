using manual_Csharp.Class.clsMysqlConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb = manual_Csharp.Class.clsStatic;

namespace manual_Csharp.Class.clsNode
{
 public class clsNodeQuery : clsNodeController
  {

    public DataTable GetNodeElementData(string fullpath)
    {
      var sql = $"SELECT tv_name,tv_Code FROM tv" +
        $"WHERE tv_gubun = '{gb.Gubun}' AND tv_name = '{fullpath}'";
      var dT = clsMyCon.GetSVConData(sql);
        return dT;
    }
    public DataTable GetNodeElements_Data(string OwnPath)
    {
      var sql = $"SELECT tv_name,tv_Code FROM tv" +
        $"WHERE tv_gubun = '{gb.Gubun}' AND tv_name LIKE '{OwnPath}|%' ORDER BY tv_dup ASC";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
  }
}
