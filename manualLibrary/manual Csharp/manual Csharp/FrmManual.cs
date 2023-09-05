using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gb = manual_Csharp.Class.clsStatic;
using DevExpress.XtraBars.Navigation;
using manual_Csharp.Class.clsNode;
using manual_Csharp.Class.clsPdf;

namespace manual_Csharp
{
  public partial class FrmManual : DevExpress.XtraBars.Ribbon.RibbonForm
  {

    #region "전역"
    private AccordionControlElement SelectedEle;
    private string _fullpath;
    private bool myLoadChecked;
    private bool _myOpenChecked;
    private int page;
    private int prevHeaderPage;
    private int NextHeaderPage;
    #endregion

    #region "property"
    string Gubun { get { return gb.Gubun; } set { gb.Gubun = value; } }
   public bool myOpenChecked { get { return _myOpenChecked; } set { _myOpenChecked = value; } }
   public string fullpath { get { return _fullpath; } set { _fullpath = value; } }
    private string manualPath { get; set; }
    #endregion

    #region "Set"
    private void SetMyOpen()
    {
      Activate();
      SetPDFLoad();
      if (GetDefaultPathChecked())
        return;
      var selectedEle = clsNodeController.Select.GetAddElement(fullpath);
      if (selectedEle is null)
        return;
      DevAcc.Elements.Clear();
      DevAcc.Elements.Add(selectedEle);
      SetPdfSelect(fullpath);

    }

    private bool GetDefaultPathChecked()
    {
      if (fullpath == "<default>")
      {
        SetNodeSelect(); pdf.CurrentPageNumber = 1; return true;
      }
      return false;
    }

    private void SetNodeLoad()
    {
      SetNodeSelect();
      Activate();
      SetPDFLoad();
      var selectedEle = clsNodeController.Select.GetSelectedNode(DevAcc.GetElements(), fullpath);
      if (selectedEle is null)
        return;
      DevAcc.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Normal;
      clsNodeController.Select.DevAcc_LeftOnlyOneElement(DevAcc.Elements, selectedEle, fullpath);
      SetPdfSelect(selectedEle.Tag.ToString());
    }

    private void SetPDFLoad()
    {
      if (Gubun != "0")
      {
        manualPath = Application.StartupPath + @"\manual\u클릭설명서.pdf";
      }
      else
      {
        manualPath = Application.StartupPath + @"\manual\e클릭설명서.pdf";
      }
      clsPdfController.Save.SetUpdate();
      if (pdf.DocumentFilePath == "")
        pdf.DocumentFilePath = manualPath;
    }

    private void SetNodeSelect()
    {
      DevAcc.Clear();
      DevAcc.SelectedElement = null;
      clsNodeController.Select.SetNodesSelect(DevAcc.Elements);
    }

    private void SetPdfSelect(string tv_name, bool elementEventClickChecked = false)
    {
      page = clsPdfController.Select.GetPDFpage(tv_name,ref prevHeaderPage,ref NextHeaderPage);
      int[] pageRange = null;
      if (fullpath != "<default>")
      {
        if (!elementEventClickChecked)
        {
          var ms = clsPdfController.Select.GetPdfPageCompare(fullpath, pdf.DocumentFilePath, pdf.PageCount, ref pageRange);
          pdf.LoadDocument(ms);
        }
        else
        {
          pageRange = clsPdfController.Select.GetPageSelect(fullpath, pdf.PageCount);
        }
        pdf.CurrentPageNumber = GetPdfPage(pageRange);
      }
      else
      {
        if (page > 0)
          pdf.CurrentPageNumber = page;
      }
    }

    private int GetPdfPage(int[] pageRange)
    {
      if (page > 0)
      {
        int cnt = 0;
        foreach (int pr in pageRange)
        {
          cnt += 1;
          if (pr == page)
          {
            page = cnt;
            return page;
          }
        }
      }
      return 1;
    }

    #endregion



    public FrmManual(string fullpath, string Gubun = "0")
    {
      try
      {
        InitializeComponent();
      }
      catch (ApplicationException ex)
      {
        MessageBox.Show(ex.Message);
      }
      this.Gubun = Convert.ToInt32(Gubun) >= 1 ? "1" : "0";
      this.fullpath = fullpath;
    }

    private void FrmManual_Load(object sender, EventArgs e)
    {
      myLoadChecked = true;
      try
      {
        SetNodeLoad();
        clsNodeController.DevAcc_FilterContent(DevAcc.Controls);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void DevAcc_ElementClick(object sender, ElementClickEventArgs e)
    {
      SetPdfSelect(Convert.ToString(e.Element.Tag), true);
      e.Element.Image = Properties.Resources.Forward_16x16;
      if (SelectedEle != null & SelectedEle != e.Element)
        SelectedEle.Image = null;
      SelectedEle = e.Element;

    }

    private void pdf_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
        return;
    }

    private void pdfFilePrintBarItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      switch (e.Item.Caption)
      {
        case "인쇄":
          {
            var t = new Timer { Enabled = true, Interval = 500 };
            t.Start();            
            t.Tick += (s,ev) => clsPdfController.Edit.SetPrintText(t);
            break;
          }          
      }
    }

    private void pdf_DocumentChanged(object sender, DevExpress.XtraPdfViewer.PdfDocumentChangedEventArgs e)
    {
      clsPdfController.Edit.ConvertRibbonText(this.Controls);
      pdf.ShowFindDialog();
      if (pdf.IsFindDialogVisible)
      {
        clsPdfController.Edit.SetPdfFindToolItemModify();
        pdf.HideFindDialog();
      }

    }
  }
}
