
using pdfViewer.usercontrol;
using System.Windows.Forms;

namespace pdfViewer
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ExpandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.bar = new DevExpress.XtraEditors.ProgressBarControl();
            this.Manager = new pdfViewer.usercontrol.pdfManager();
            this.exPnl = new DevComponents.DotNetBar.ExpandablePanel();
            this.Search1 = new pdfViewer.usercontrol.Search();
            this.pdf = new DevExpress.XtraPdfViewer.PdfViewer();
            this.ExpandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar.Properties)).BeginInit();
            this.exPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog2";
            // 
            // ExpandablePanel1
            // 
            this.ExpandablePanel1.CanvasColor = System.Drawing.Color.Silver;
            this.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExpandablePanel1.Controls.Add(this.bar);
            this.ExpandablePanel1.Controls.Add(this.Manager);
            this.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExpandablePanel1.HideControlsWhenCollapsed = true;
            this.ExpandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.ExpandablePanel1.Name = "ExpandablePanel1";
            this.ExpandablePanel1.Size = new System.Drawing.Size(499, 628);
            this.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ExpandablePanel1.Style.BackColor1.Color = System.Drawing.Color.Silver;
            this.ExpandablePanel1.Style.BackColor2.Color = System.Drawing.Color.Silver;
            this.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.ExpandablePanel1.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ExpandablePanel1.Style.GradientAngle = 90;
            this.ExpandablePanel1.TabIndex = 18;
            this.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ExpandablePanel1.TitleStyle.GradientAngle = 90;
            this.ExpandablePanel1.TitleText = "노드";
            this.ExpandablePanel1.SizeChanged += new System.EventHandler(this.ExpandablePanel1_SizeChanged);
            // 
            // bar
            // 
            this.bar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bar.Location = new System.Drawing.Point(0, 289);
            this.bar.Name = "bar";
            this.bar.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.bar.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.bar.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bar.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bar.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.bar.Properties.FlowAnimationEnabled = true;
            this.bar.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.bar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bar.Properties.ShowTitle = true;
            this.bar.Size = new System.Drawing.Size(497, 18);
            this.bar.TabIndex = 54;
            this.bar.Visible = false;
            // 
            // Manager
            // 
            this.Manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manager.FirstNodeClick = false;
            this.Manager.LabelEdit = false;
            this.Manager.Location = new System.Drawing.Point(0, 26);
            this.Manager.Name = "Manager";
            this.Manager.SelectedNode = null;
            this.Manager.Size = new System.Drawing.Size(499, 602);
            this.Manager.TabIndex = 0;
            this.Manager.FirstNodeSelect += new pdfViewer.usercontrol.pdfManager.FirstNodeSelectEventHandler(this.Manager_FirstNodeSelect);
            this.Manager.Insert += new pdfViewer.usercontrol.pdfManager.InsertEventHandler(this.Manager_Insert);
            this.Manager.Delete += new pdfViewer.usercontrol.pdfManager.DeleteEventHandler(this.Manager_Delete);
            this.Manager.Search += new pdfViewer.usercontrol.pdfManager.SearchEventHandler(this.Manager_Search);
            this.Manager.NodeMouseClick += new pdfViewer.usercontrol.pdfManager.NodeMouseClickEventHandler(this.Manager_NodeMouseClick);
            this.Manager.NodeMouseDoubleClick += new pdfViewer.usercontrol.pdfManager.NodeMouseDoubleClickEventHandler(this.Manager_NodeMouseDoubleClick);
            this.Manager.MenuNodeModify += new pdfViewer.usercontrol.pdfManager.MenuNodeModifyEventHandler(this.Manager_MenuNodeModify);
            this.Manager.MenuNodePdfDel += new pdfViewer.usercontrol.pdfManager.MenuNodePdfDelEventHandler(this.Manager_MenuNodePdfDel);
            this.Manager.MenuNodeDel += new pdfViewer.usercontrol.pdfManager.MenuNodeDelEventHandler(this.Manager_MenuNodeDel);
            this.Manager.ChangeIndexCmbGubun += new pdfViewer.usercontrol.pdfManager.ChangeIndexCmbGubunEventHandler(this.Manager_ChangeIndexCmbGubun);
            this.Manager.ToolPdfFileOpen += new pdfViewer.usercontrol.pdfManager.ToolPdfFileOpenEventHandler(this.Manager_ToolPdfFileOpen);
            this.Manager.PdfUpdate += new pdfViewer.usercontrol.pdfManager.PdfUpdateEventHandler(this.Manager_PdfUpdate);
            this.Manager.PdfInsert += new pdfViewer.usercontrol.pdfManager.PdfInsertEventHandler(this.Manager_PdfInsert);
            this.Manager.pdfOpen += new pdfViewer.usercontrol.pdfManager.pdfOpenEventHandler(this.Manager_pdfOpen);
            this.Manager.pdfClose += new pdfViewer.usercontrol.pdfManager.pdfCloseEventHandler(this.Manager_pdfClose);
            // 
            // exPnl
            // 
            this.exPnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.exPnl.Controls.Add(this.Search1);
            this.exPnl.DisabledBackColor = System.Drawing.Color.Empty;
            this.exPnl.HideControlsWhenCollapsed = true;
            this.exPnl.Location = new System.Drawing.Point(911, 1);
            this.exPnl.Name = "exPnl";
            this.exPnl.Size = new System.Drawing.Size(354, 65);
            this.exPnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.exPnl.Style.BackColor1.Color = System.Drawing.Color.White;
            this.exPnl.Style.BackColor2.Color = System.Drawing.Color.White;
            this.exPnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.exPnl.Style.BorderColor.Color = System.Drawing.Color.White;
            this.exPnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.exPnl.Style.GradientAngle = 90;
            this.exPnl.TabIndex = 34;
            this.exPnl.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.exPnl.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.exPnl.TitleStyle.BackColor2.Color = System.Drawing.Color.White;
            this.exPnl.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.exPnl.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.exPnl.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.exPnl.TitleStyle.GradientAngle = 90;
            this.exPnl.TitleText = "검색";
            // 
            // Search1
            // 
            this.Search1.BackColor = System.Drawing.Color.White;
            this.Search1.Location = new System.Drawing.Point(1, 25);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(351, 40);
            this.Search1.TabIndex = 41;
            this.Search1.PageMove_withTxt += new pdfViewer.usercontrol.Search.PageMove_withTxtEventHandler(this.Search1_PageMove_withTxt);
            this.Search1.TxtValueChanged += new pdfViewer.usercontrol.Search.TxtValueChangedEventHandler(this.Search1_TxtValueChanged);
            // 
            // pdf
            // 
            this.pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf.Location = new System.Drawing.Point(499, 0);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(785, 628);
            this.pdf.TabIndex = 41;
            this.pdf.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1284, 628);
            this.Controls.Add(this.exPnl);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.ExpandablePanel1);
            this.Name = "frmMain";
            this.Text = "관리자 페이지";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ExpandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar.Properties)).EndInit();
            this.exPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private OpenFileDialog OpenFileDialog1;

        
        private pdfManager Manager;

        
        private DevComponents.DotNetBar.ExpandablePanel ExpandablePanel1;

        
        private DevComponents.DotNetBar.ExpandablePanel exPnl;

        
        private Search Search1;

        
        private DevExpress.XtraPdfViewer.PdfViewer pdf;

        
        private DevExpress.XtraEditors.ProgressBarControl bar;

        
        #endregion
    }
}

