using manual_Csharp.Class.clsMysqlConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb = manual_Csharp.Class.clsStatic;

namespace manual_Csharp.Class.clsPdf
{
  public class clsPdfQuery : clsPdfController
  {
    public DataTable GetPdfCurrentPageDT(string tv_name)
    {
      var sql = $"SELECT tv_Page FROM tv" +
        $"WHERE tv_gubun = '{gb.Gubun}' AND tv_Name = '{tv_name}'";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
    public DataTable GetPdfJiwonPrintPageDT(string fullpath)
    {
      var sql = $"SELECT tv_page,tv_dup," +
        $"(SELECT tv_dup FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_name = '지원실') parent_dup," +
        $"(SELECT max(tv_dup) FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_name LIKE '지원실|%' ORDER BY tv_page ASC) max_dup" +
        $"FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_name = '{fullpath}' AND tv_page <> 0;";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
    public DataTable GetpdfJiwonMaxDup_PrintPageDT(int parent_dup)
    {
      var sql = $"SELECT min(sv.tv_page) page FROM" +
        $"(SELECT tv_name, tv_page FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_no = 0 AND tv_dup = {parent_dup}) tv" +
        $"LEFT JOIN" +
        $"(SELECT tv_name,tv_page FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_page <> 0) sv" +
        $"ON sv.tv_name LIKE CONCAT(tv.tv_name,'|%')" +
        $"WHERE sv.tv_page <> 0" +
        $"ORDER BY sv.tv_page ASC";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
    public DataTable GetPdfJiwonNextPrintPageDT(int nextDup)
    {
      var sql = $"SELECT tv_page FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_name LIKE '지원실|%' AND tv_dup = {nextDup} AND tv_page <> 0";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
    public DataTable GetPdfPrintFirstPageDT(string parentPath)
    {
      var sql = $"SELECT min(tv_page)," +
        $"(SELECT tv_dup FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_name = '{parentPath}') parent_dup" +
        $"FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_name LIKE '{parentPath}|%' AND tv_page <> 0 ORDER BY tv_page ASC";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
    public DataTable GetPdfPrintLastPageDT(string parentDup)
    {
      var sql = $"SELECT min(tv_page) lastPage FROM (SELECT tv_name FROM tv WHERE tv_gubun = '{gb.Gubun}' AND tv_no = 0 AND tv_dup = {parentDup} ORDER BY tv_page ASC) tvname" +
        $"LEFT JOIN (SELECT tv_name,tv_page FROM tv WHERE tv_gubun = '{gb.Gubun}') tv" +
        $"ON tv.tv_name LIKE CONCAT(tvname.tv_name, '|%')" +
        $"WHERE tv_page <> 0" +
        $"ORDER BY tv_page ASC";
      var dT = clsMyCon.GetSVConData(sql);
      return dT;
    }
  }
}
