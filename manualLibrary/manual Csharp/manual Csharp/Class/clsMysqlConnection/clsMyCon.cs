using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manual_Csharp.Class.clsMysqlConnection
{
  class clsMyCon
  {
    private static MySqlConnection _svCon;
    private static MySqlConnection svCon
    {
      get
      {
        if (_svCon is null)
          _svCon = new MySqlConnection();
        return _svCon;
      }
      set { _svCon = value; }
    }
    public static DataTable GetSVConData(string sql)
    {
      ServerConnectMariaDB();
      var dT = My_SELECT( sql, "manual");
      CloseSVCon();
      return dT;
    }
    #region "private"
    private static string ServerConnectMariaDB()
    {
      string ConStr;
      var myset = Properties.Settings.Default;
      try
      {
        ConStr = $"SERVER={myset.ip};";
        ConStr += $"PORT={myset.port};";
        ConStr += $"UID={myset.id};";
        ConStr += $"PWD={myset.pwd};";
        ConStr += $"DATABASE={myset.db};";
        ConStr += $"ALLOW USER VARIABLES=TRUE;";
        svCon.ConnectionString = ConStr;
        svCon.Open();
      }
      catch
      {
        return "서버데이터베이스와 연결하지 못했습니다." + Constants.vbCrLf + "환경설정(Sever Setup 83~86번)이나 인터넷(네트워크)을 확인하세요.!!";
      }
      return "Y";
    }
    private static DataTable My_SELECT(string SQuery, string DBNm = "")
    {
      return MySelectBase(SQuery, DBNm);
    }
    private static DataTable MySelectBase(string sql, string database)
    {
      using (var da = new MySqlDataAdapter())
      {
        using (var cmd = new MySqlCommand() { CommandTimeout = 300, Connection = svCon })
        {
          var dT = new DataTable();
          if (Strings.Trim(database) == "")
            database = "manual";
          CheckConnectIsNormal();
          if (Strings.UCase(svCon.Database) != Strings.UCase(database))
            svCon.ChangeDatabase(database);
          cmd.CommandText = sql;
          da.SelectCommand = cmd;
          da.Fill(dT);
          return dT;
        }
      }

    }
    private static bool CheckConnectIsNormal()
    {
      try
      {
        if (svCon.Ping() == false)
        {
          if (svCon is null || svCon.State == ConnectionState.Closed)
          {
            var reconnectTask = Task.Run(() => ReConnect());
            reconnectTask.Wait();
            return reconnectTask.Result;
          }

        }
        return false;
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message, ex);
        return false;
      }
    }

    private static bool ReConnect()
    {
      var Sw = new Stopwatch();
      Sw.Start();
      using (var frmRe = new frmReConnect())
      {
        frmRe.Show();
        frmRe.BringToFront();
        frmRe.TopMost = true;
        Task<bool> reConnectionTask = null;
        do
        {
          if (frmRe.IsExit)
          {
            Application.Exit();
            return false;
          }
            
          if (Sw.ElapsedMilliseconds > 30000)
          {
          Interaction.MsgBox("서버연결에 실패하였습니다. 프로그램을 종료합니다.");
          Application.Exit();
          return false;
          }
          frmRe.ShowText("서버연결이 불안정해 재연결을 시도합니다...(" + Sw.ElapsedMilliseconds / 1000 + ")");
          if (reConnectionTask is null)
            reConnectionTask = Task.Run(() => ReConnection());
          if (reConnectionTask.IsCompleted)
          {
            if (reConnectionTask.Result)
              return true;
            reConnectionTask.Dispose();
            reConnectionTask = null;
          }
        }
        while (true);
        return false;
      }
    }

    private static bool ReConnection()
    {
      try
      {
        var database = string.IsNullOrWhiteSpace(svCon.Database) ? "" : $"database={svCon.Database}";
        svCon.Close();
        svCon.ConnectionString += $";pwd={Properties.Settings.Default.DB_PWD};{database}";
        svCon.Open();
        return true;
      }
      catch
      {
        return false;
      }
    }

    private static void CloseSVCon()
    {
      if (svCon != null)
      {
        svCon.Close();
        svCon.Dispose();
        svCon = null;
      }
    }
    #endregion
  }
}
