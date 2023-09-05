using DevExpress.XtraBars.Navigation;
using manual_Csharp.Class.clsMysqlConnection;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb = manual_Csharp.Class.clsStatic;

namespace manual_Csharp.Class.clsNode
{
 public class clsNodeSelect : clsNodeController
  {
    private List<TvModel> _tvList;
    private struct TvModel
    {
      public string Name;
      public int No;
      public int Dup;
      public TvModel(string Name, int No, int Dup)
      {
        this.Name = Name;
        this.No = No;
        this.Dup = Dup;
      }
    }
    private List<TvModel> tvList
    {
      get
      {
        if (_tvList is null)
          _tvList = new List<TvModel>();
        return tvList;
      }
    }
    #region "SelectAll"

    public void SetNodesSelect(AccordionControlElementCollection TreeNodeCollection)
    {
      var sql = $"SELECT tv_no,tv_name,tv_dup FROM tv" +
        $"WHERE tv_gubun = '{gb.Gubun}'" +
        $"ORDER BY tv_no, tv_dup ASC";
      var dT = clsMyCon.GetSVConData(sql);
      ListClear();
      foreach (DataRow dR in dT.Rows)
      {
        ListAdd(dR["tv_name"].ToString(), Convert.ToInt32(dR["tv_no"]), Convert.ToInt32(dR["tv_dup"]));
      }
    }

    #region "private"    
    private void ListClear()
    {
      tvList.Clear();
    }
    private void ListAdd(string name, int no, int dup)
    {
      tvList.Add(new TvModel(name, no, dup));
    }

    private void SelectNode(AccordionControlElementCollection AddTreeNode)
    {
      AccordionControlElement node = null;
      var tvArr = (from TvModel t in tvList
                   where t.No == 0
                   orderby t.Dup ascending
                   select new { t.Name, t.No, t.Dup }).ToArray();
      string tv_name = "";
      if (tvArr.Length != 0)
        SetTreeView(tvArr, node, tv_name, 0, AddTreeNode);
    }

    private void SetTreeView(Array tvArr, AccordionControlElement parentNodes, string tv_name, int i, AccordionControlElementCollection AddTreeNode = null)
    {
      AccordionControlElement childNode = null;
      if (parentNodes != null & i != -2)
        tvArr = (from t in tvList
                 where t.No == i + 1 & t.Name.Contains(tv_name)
                 select new { t.No, t.Name, t.Dup }).ToArray();
      int index = -1;
      Array svArr = null;
      foreach (dynamic tv in tvArr)
      {
        int PdfInt = 1;
        if (parentNodes is null)
        {
          childNode = AddTreeNode.Add();
          childNode.Text = tv.name;
          childNode.Tag = tv.name;
          SetTreeView(tvArr, childNode, tv.name & "|", tv.No);
        }
        else
        {
          string InputName = tv.name.ToString().Replace(tv_name, "");
          if (GetCheckName(tv_name, tv.name) == false)
            goto here;
          index += 1;
          childNode = parentNodes.Elements.Add();
          childNode.Text = InputName;
          childNode.Tag = tv_name + InputName;
          svArr = (from t in tvList
                   where t.No == tv.No + 1 & t.Name.Contains(tv.name + "|")
                   orderby t.Dup ascending
                   select new { t.No, t.Name, t.Dup }).ToArray();
          if (svArr.Length == 0)
          {
            svArr = null;
            childNode.Style = ElementStyle.Item;
          }
          if (svArr != null)
            SetTreeView(svArr, childNode, tv.name & "|", -2);

          here:;
        }
        if (childNode is null)
          continue;
      }
    }
    private bool GetCheckName(string PrevName, string NewName)
    {
      if (Strings.Mid(PrevName, 1, PrevName.IndexOf("|") + 1) != Strings.Mid(NewName, 1, NewName.IndexOf("|") + 1))
        return false;
      return true;
    }
    #endregion
    #endregion

    #region "필요한 부분만 element select 한다"

    public AccordionControlElement GetSelectedNode(List<AccordionControlElement> GetElements,string fullpath)
    {
      if (fullpath == "")
        return null;
      var dT = Query.GetNodeElementData(fullpath);
      if (dT.Rows.Count == 0)
        return null;
      var path = dT.Rows[0]["tv_name"].ToString();
      foreach (AccordionControlElement ele in GetElements)
      {
        if (ele.Tag.ToString() == path)
          return ele;
      }
      return null;
    }
    public AccordionControlElement GetAddElement(string fullpath)
    {
      if (fullpath == "")
        return null;
      var dT = Query.GetNodeElementData(fullpath);
      if (dT.Rows.Count == 0)
        return null;
      var path = dT.Rows[0]["tv_name"].ToString();      
      char[] separator = new char[] { Convert.ToChar("|") };      
      var txts = fullpath.Split(separator);
      if (fullpath.Contains("지원실|"))
      {
        var txt = txts[txts.Length - 1];
        var accordion = new AccordionControlElement { Tag = fullpath, Text = txt, Style = ElementStyle.Item };
        return accordion;
      }
      else
      {
        return GetOwnElement(txts[0]);
      }    
    }
    private AccordionControlElement GetOwnElement(string OwnPath)
    {
      var dT = Query.GetNodeElements_Data(OwnPath);
      if (dT.Rows.Count > 0)
      {
        var OwnElement = new AccordionControlElement { Text = OwnPath, Tag = OwnPath };
        foreach (DataRow dR in dT.Rows)
        {
          var path = dR["tv_name"]?.ToString();
          var txt = path.Replace($"{OwnPath}|", "");
          var itemElement = new AccordionControlElement { Text = txt, Tag = path, Style = ElementStyle.Item };
          OwnElement.Elements.Add(itemElement);
        }
        return OwnElement;
      }
      else
      {
        return null;
      }
    }
    public void DevAcc_LeftOnlyOneElement(AccordionControlElementCollection elementCollection, AccordionControlElement selectedEle, string fullpath) 
    {
      if (fullpath.Contains("지원실"))
      {
        elementCollection.Clear();
        elementCollection.Add(selectedEle);
      }
      else
      {
        repeat:;
        for (int i= 0, looptop = elementCollection.Count -1; i <= looptop; i++)
        {
          if (elementCollection[i].Text != selectedEle.OwnerElement.Text)
          {
            elementCollection.RemoveAt(i);
            goto repeat;       
            break;
          }
        }
      }
    }

    #endregion
  }
}
