using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPdfViewer.Forms;
using DevExpress.XtraPdfViewer.Native;


namespace manual_Csharp.Class.clsPdf
{
  public class clsPdfEdit : clsPdfController
  {
    #region "FindTool"
    public void SetPdfFindToolItemModify()
    {
      var findToolWindow = GetFindToolWindow();
      var controls = new List<Control>();
      if (TryGetFindToolWindowControls(findToolWindow, controls))
        ConvertTextControls(controls);

    }

    private PdfFindToolWindow GetFindToolWindow()
    {
      FormCollection forms = Application.OpenForms;
      var findForms = (from Form s in forms
                       where object.ReferenceEquals(s.GetType(), typeof(PdfFindToolWindow))
                       select s).ToList();
      return (findForms?.Count) > 0 ? findForms[0] as PdfFindToolWindow : null;
    }
    private bool TryGetFindToolWindowControls(Control parent, List<Control> controls)
    {
      if (parent is null)
        return false;
      foreach (Control control in parent.Controls)
      {
        controls.Add(control);
        if (control.HasChildren)
          TryGetFindToolWindowControls(control, controls);
      }
      return controls.Count > 0;
    }

    private void ConvertTextControls(List<Control> controls)
    {
      foreach (Control control in controls)
      {
        var controlType = control.GetType();
        switch (true)
        {
          case object _ when ReferenceEquals(controlType, typeof(SimpleButton)):
            {
              SimpleButton button = control as SimpleButton;
              switch (button.Text)
              {
                case "Previous":
                  {
                    button.Text = "이전";
                    break;
                  }
                case "Next":
                  {
                    button.Text = "다음";
                    break;
                  }
                case "Close":
                  {
                    button.Text = "닫기";
                    break;
                  }
              }
              break;
            }
          case object _ when ReferenceEquals(controlType, typeof(LabelControl)):
          {
              var label = control as LabelControl;
              label.Text = "검색";
              break;
          }
          case object _ when ReferenceEquals(controlType, typeof(PdfSearchParametersButton)):
            {
              var button = control as PdfSearchParametersButton;
              button.Visible = false;
              break;
            }
        }
      }
    }
    #endregion

    #region "ribbon"
    public void ConvertRibbonText(Control.ControlCollection controls)
    {
      DevExpress.XtraBars.Ribbon.RibbonControl ribbon = controls.OfType<DevExpress.XtraBars.Ribbon.RibbonControl>().FirstOrDefault();
      repeat:;
      for (int i = 0, loopTop = ribbon.Items.Count - 1;i <= loopTop; i++)
      {
        var ribbonCaption = ribbon.Items[i].Caption;
        if (ribbonCaption == "Open" | ribbonCaption == "Save As" | ribbonCaption == "Fit Visible")
        {
          ribbon.Items.RemoveAt(i);
          goto repeat;
        }
        else
        {
          switch (ribbonCaption)
          {
            case "Print":
              {
                ribbonCaption = "인쇄";
                break;
              }
            case "Find":
              {
                ribbonCaption = "검색";
                break;
              }
            case "Previous":
              {
                ribbonCaption = "이전";
                break;
              }
            case "Next":
              {
                ribbonCaption = "다음";
                break;
              }
            case "Zoom Out":
              {
                ribbonCaption = "축소";
                break;
              }
            case "Zoom In":
              {
                ribbonCaption = "확대";
                break;
              }
            case "Zoom":
              {
                ribbonCaption = "줌 설정";
                break;
              }
            case "Fit Width":
              {
                ribbonCaption = "PDF에 맞게 넓이 조정";
                break;
              }
            case "Actual Size":
              {
                ribbonCaption = "실제 사이즈";
                break;
              }
            case "Zoom to Page Level":
              {
                ribbonCaption = "줌에 따라 넓이 조정";
                break;
              }
          }
        }
      }
    }
    #endregion

    #region "print"
    public void SetPrintText(Timer t)
    {
      FormCollection forms = Application.OpenForms;
      var setupPrint = (from Form p in forms where object.ReferenceEquals(p.GetType(), typeof(PdfPageSetupDialog)) select p).ToArray();
      if (setupPrint is null)
        return;
      int index = setupPrint.Length - 1;
      if (index == -1)
      {
        t.Stop();
        return;
      }
      var printDialog = setupPrint[index] as PdfPageSetupDialog;
      var ctrlList = new List<Control>();
      if (SetPrintChildCtrl(printDialog.Controls, ctrlList))
        SetCtrlType(ctrlList);
    }
    private bool SetPrintChildCtrl(Control.ControlCollection controls,List<Control> ctrlList)
    {
      foreach (Control ctrl in controls)
      {
        ctrlList.Add(ctrl);
        if (ctrl.HasChildren)
          SetPrintChildCtrl(ctrl.Controls, ctrlList);
      }
      return ctrlList.Count > 0;
    }

    private void SetCtrlType(List<Control> controls)
    {
      foreach (Control control in controls)
      {
        var controltype = control.GetType();
        switch (true)
        {
          case object _ when ReferenceEquals(controltype, typeof(LabelControl)):
            {
              var label = control as LabelControl;
              SetCtrlTextChange(label);
              break;
            }
            case object _ when ReferenceEquals(controltype, typeof(SimpleButton)):
            {
              var button = control as SimpleButton;
              SetCtrlTextChange(button);
              break;
            }
            case object _ when ReferenceEquals(controltype, typeof(CheckEdit)):
            {
              var chkedit = control as CheckEdit;
              SetCtrlTextChange(chkedit);
              break;
            }
          case object _ when ReferenceEquals(controltype, typeof(ControlNavigator)):
            {
              var ctrlNavi = control as ControlNavigator;
              if (ctrlNavi.Name == "cnPagePreviewNumber")
              {
                var prevTxt = ctrlNavi.TextStringFormat.Replace("Page", "페이지");
                ctrlNavi.TextStringFormat = prevTxt.Replace("of","/");
              }
              break;
            }
        }
      }
    }

    private void SetCtrlTextChange(Control control)
    {
      switch (control.Name)
      {
        #region "label"
        case "lbPrinterName":
          {
            control.Text = "프린터:";
            break;
          }
        case "lbPrinterStatus":
          {
            control.Text = "인쇄 준비";
            break;
          }
        case "lbPrinterStatusCaption":
          {
            control.Text = "상태:";
            break;
          }
        case "lbPrinterLocationCaption":
          {
            control.Text = "위치:";
            break;
          }
        case "lbPrinterCommentCaption":
          {
            control.Text = "주석:";
            break;
          }
        case "lbPrinterDocumentsInQueueCaption":
          {
            control.Text = "대기열에 있는 문서:";
            break;
          }
        case "lbCopies":
          {
            control.Text = "복사본:";
            break;
          }
        case "lbPageRange":
          {
            control.Text = "인쇄할 페이지:";
            break;
          }
        case "lbPageRangeExample":
          {
            control.Text = "예) 5 - 12";
            break;
          }
        case "lbPageSizing":
          {
            control.Text = "페이지 크기 조정:";
            break;
          }
        case "lbPageOrientation":
          {
            control.Text = "방향";
            break;
          }
        case "lbPaperSource":
          {
            control.Text = "문서 속성";
            break;
          }
        case "lbFilePath":
          {
            control.Text = "파일 경로:";
            break;
          }
        case "lbFitScale":
          {
            var prevTxt = control.Text.Replace("Scale", "비율");
            control.Text = prevTxt;
            break;
          }
        #endregion

        #region "button"
        case "btnPrinterPreferences":
          {
            control.Text = "속성";
          break;
          }
        case "btnPrint":
          {
            control.Text = "인쇄";
            break;
          }
        case "btnCancel":
          {
            control.Text = "취소";
            break;
          }

        #endregion

        #region "radiobutton"
        case "rbPrintRangeAll":
          {
            control.Text = "모두";
            break;
          }
        case "rbPrintRangeCurrent":
          {
            control.Text = "현재";
            break;
          }
        case "rbPrintRangeSome":
          {
            control.Text = "페이지";
            break;
          }
        case "rbPageScaleFit":
          {
            control.Text = "맞추기";
            break;
          }
        case "rbPageScaleActualSize":
          {
            control.Text = "실제 크기";
            break;
          }
        case "rbPageScaleCustom":
          {
            control.Text = "비율 조정:";
            break;
          }
        case "rbAutoOrientation":
          {
            control.Text = "자동";
            break;
          }
        case "rbPortraitOrientation":
          {
            control.Text = "세로 방향";
            break;
          }
        case "rbLandscapeOrientation":
          {
            control.Text = "가로 방향";
            break;
          }
        #endregion

        #region "Checkedit"
        case "cbCollate":
          {
            control.Text = "한 부씩 인쇄";
            break;
          }
        case "cbPrintToFile":
          {
            control.Text = "인쇄 파일 선택";
            break;
          }
          #endregion
      }
    }
    #endregion
  }
}
