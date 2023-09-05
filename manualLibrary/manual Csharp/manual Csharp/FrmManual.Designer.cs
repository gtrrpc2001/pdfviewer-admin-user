using System.Windows.Forms;

namespace manual_Csharp
{
    partial class FrmManual

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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.pdfFileOpenBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
      this.pdfFileSaveAsBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
      this.pdfFilePrintBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
      this.pdfFindTextBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
      this.pdfPreviousPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
      this.pdfNextPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
      this.pdfSetPageNumberBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem();
      this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
      this.pdfZoomOutBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
      this.pdfZoomInBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
      this.pdfExactZoomListBarSubItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
      this.pdfZoom10CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
      this.pdfZoom25CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
      this.pdfZoom50CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
      this.pdfZoom75CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
      this.pdfZoom100CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
      this.pdfZoom125CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
      this.pdfZoom150CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
      this.pdfZoom200CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
      this.pdfZoom400CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
      this.pdfZoom500CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
      this.pdfSetActualSizeZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
      this.pdfSetPageLevelZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
      this.pdfSetFitWidthZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
      this.pdfSetFitVisibleZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
      this.pdfRibbonPage1 = new DevExpress.XtraPdfViewer.Bars.PdfRibbonPage();
      this.pdfFileRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup();
      this.pdfFindRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup();
      this.pdfNavigationRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup();
      this.pdfZoomRibbonPageGroup1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup();
      this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.DevAcc = new DevExpress.XtraBars.Navigation.AccordionControl();
      this.pdf = new DevExpress.XtraPdfViewer.PdfViewer();
      this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController(this.components);
      this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DevAcc)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbonStatusBar1
      // 
      this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 980);
      this.ribbonStatusBar1.Name = "ribbonStatusBar1";
      this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
      this.ribbonStatusBar1.Size = new System.Drawing.Size(1371, 24);
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 35, 30, 35);
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.pdfFileOpenBarItem1,
            this.pdfFileSaveAsBarItem1,
            this.pdfFilePrintBarItem1,
            this.pdfFindTextBarItem1,
            this.pdfPreviousPageBarItem1,
            this.pdfNextPageBarItem1,
            this.pdfSetPageNumberBarItem1,
            this.pdfZoomOutBarItem1,
            this.pdfZoomInBarItem1,
            this.pdfExactZoomListBarSubItem1,
            this.pdfZoom10CheckItem1,
            this.pdfZoom25CheckItem1,
            this.pdfZoom50CheckItem1,
            this.pdfZoom75CheckItem1,
            this.pdfZoom100CheckItem1,
            this.pdfZoom125CheckItem1,
            this.pdfZoom150CheckItem1,
            this.pdfZoom200CheckItem1,
            this.pdfZoom400CheckItem1,
            this.pdfZoom500CheckItem1,
            this.pdfSetActualSizeZoomModeCheckItem1,
            this.pdfSetPageLevelZoomModeCheckItem1,
            this.pdfSetFitWidthZoomModeCheckItem1,
            this.pdfSetFitVisibleZoomModeCheckItem1});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 25;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pdfRibbonPage1});
      this.ribbonControl1.SetPopupContextMenu(this.ribbonControl1, this.popupMenu1);
      this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1});
      this.ribbonControl1.Size = new System.Drawing.Size(1371, 160);
      this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
      // 
      // pdfFileOpenBarItem1
      // 
      this.pdfFileOpenBarItem1.Id = 1;
      this.pdfFileOpenBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
      this.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1";
      // 
      // pdfFileSaveAsBarItem1
      // 
      this.pdfFileSaveAsBarItem1.Id = 2;
      this.pdfFileSaveAsBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
      this.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1";
      // 
      // pdfFilePrintBarItem1
      // 
      this.pdfFilePrintBarItem1.Id = 3;
      this.pdfFilePrintBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
      this.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1";
      this.pdfFilePrintBarItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pdfFilePrintBarItem1_ItemClick);
      // 
      // pdfFindTextBarItem1
      // 
      this.pdfFindTextBarItem1.Id = 4;
      this.pdfFindTextBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
      this.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1";
      // 
      // pdfPreviousPageBarItem1
      // 
      this.pdfPreviousPageBarItem1.Id = 5;
      this.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1";
      // 
      // pdfNextPageBarItem1
      // 
      this.pdfNextPageBarItem1.Id = 6;
      this.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1";
      // 
      // pdfSetPageNumberBarItem1
      // 
      this.pdfSetPageNumberBarItem1.Edit = this.repositoryItemPageNumberEdit1;
      this.pdfSetPageNumberBarItem1.Id = 7;
      this.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1";
      // 
      // repositoryItemPageNumberEdit1
      // 
      this.repositoryItemPageNumberEdit1.AutoHeight = false;
      this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
      this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
      // 
      // pdfZoomOutBarItem1
      // 
      this.pdfZoomOutBarItem1.Id = 8;
      this.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1";
      // 
      // pdfZoomInBarItem1
      // 
      this.pdfZoomInBarItem1.Id = 9;
      this.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1";
      // 
      // pdfExactZoomListBarSubItem1
      // 
      this.pdfExactZoomListBarSubItem1.Id = 10;
      this.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
      this.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1";
      this.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
      // 
      // pdfZoom10CheckItem1
      // 
      this.pdfZoom10CheckItem1.Id = 11;
      this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
      // 
      // pdfZoom25CheckItem1
      // 
      this.pdfZoom25CheckItem1.Id = 12;
      this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
      // 
      // pdfZoom50CheckItem1
      // 
      this.pdfZoom50CheckItem1.Id = 13;
      this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
      // 
      // pdfZoom75CheckItem1
      // 
      this.pdfZoom75CheckItem1.Id = 14;
      this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
      // 
      // pdfZoom100CheckItem1
      // 
      this.pdfZoom100CheckItem1.Id = 15;
      this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
      // 
      // pdfZoom125CheckItem1
      // 
      this.pdfZoom125CheckItem1.Id = 16;
      this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
      // 
      // pdfZoom150CheckItem1
      // 
      this.pdfZoom150CheckItem1.Id = 17;
      this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
      // 
      // pdfZoom200CheckItem1
      // 
      this.pdfZoom200CheckItem1.Id = 18;
      this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
      // 
      // pdfZoom400CheckItem1
      // 
      this.pdfZoom400CheckItem1.Id = 19;
      this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
      // 
      // pdfZoom500CheckItem1
      // 
      this.pdfZoom500CheckItem1.Id = 20;
      this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
      // 
      // pdfSetActualSizeZoomModeCheckItem1
      // 
      this.pdfSetActualSizeZoomModeCheckItem1.Id = 21;
      this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
      // 
      // pdfSetPageLevelZoomModeCheckItem1
      // 
      this.pdfSetPageLevelZoomModeCheckItem1.Id = 22;
      this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
      // 
      // pdfSetFitWidthZoomModeCheckItem1
      // 
      this.pdfSetFitWidthZoomModeCheckItem1.Id = 23;
      this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
      // 
      // pdfSetFitVisibleZoomModeCheckItem1
      // 
      this.pdfSetFitVisibleZoomModeCheckItem1.Id = 24;
      this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
      // 
      // pdfRibbonPage1
      // 
      this.pdfRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pdfFileRibbonPageGroup1,
            this.pdfFindRibbonPageGroup1,
            this.pdfNavigationRibbonPageGroup1,
            this.pdfZoomRibbonPageGroup1});
      this.pdfRibbonPage1.Name = "pdfRibbonPage1";
      // 
      // pdfFileRibbonPageGroup1
      // 
      this.pdfFileRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
      this.pdfFileRibbonPageGroup1.ItemLinks.Add(this.pdfFilePrintBarItem1);
      this.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1";
      this.pdfFileRibbonPageGroup1.Text = "파일";
      // 
      // pdfFindRibbonPageGroup1
      // 
      this.pdfFindRibbonPageGroup1.AllowTextClipping = false;
      this.pdfFindRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
      this.pdfFindRibbonPageGroup1.ItemLinks.Add(this.pdfFindTextBarItem1);
      this.pdfFindRibbonPageGroup1.Name = "pdfFindRibbonPageGroup1";
      this.pdfFindRibbonPageGroup1.Text = "검색";
      // 
      // pdfNavigationRibbonPageGroup1
      // 
      this.pdfNavigationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
      this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfPreviousPageBarItem1);
      this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfNextPageBarItem1);
      this.pdfNavigationRibbonPageGroup1.ItemLinks.Add(this.pdfSetPageNumberBarItem1);
      this.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1";
      this.pdfNavigationRibbonPageGroup1.Text = "페이지이동";
      // 
      // pdfZoomRibbonPageGroup1
      // 
      this.pdfZoomRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
      this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfZoomOutBarItem1);
      this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfZoomInBarItem1);
      this.pdfZoomRibbonPageGroup1.ItemLinks.Add(this.pdfExactZoomListBarSubItem1);
      this.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1";
      this.pdfZoomRibbonPageGroup1.Text = "비율";
      // 
      // ribbonPage2
      // 
      this.ribbonPage2.Name = "ribbonPage2";
      this.ribbonPage2.Text = "ribbonPage2";
      // 
      // DevAcc
      // 
      this.DevAcc.Appearance.AccordionControl.Font = new System.Drawing.Font("굴림", 7F);
      this.DevAcc.Appearance.AccordionControl.Options.UseFont = true;
      this.DevAcc.Appearance.Group.Default.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
      this.DevAcc.Appearance.Group.Default.Options.UseFont = true;
      this.DevAcc.Appearance.Item.Default.Font = new System.Drawing.Font("굴림", 10F);
      this.DevAcc.Appearance.Item.Default.Options.UseFont = true;
      this.DevAcc.Appearance.Item.Normal.Font = new System.Drawing.Font("굴림", 10F);
      this.DevAcc.Appearance.Item.Normal.Options.UseFont = true;
      this.DevAcc.Dock = System.Windows.Forms.DockStyle.Left;
      this.DevAcc.Location = new System.Drawing.Point(0, 160);
      this.DevAcc.LookAndFeel.SkinName = "WXI";
      this.DevAcc.LookAndFeel.UseDefaultLookAndFeel = false;
      this.DevAcc.Name = "DevAcc";
      this.DevAcc.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
      this.ribbonControl1.SetPopupContextMenu(this.DevAcc, this.popupMenu1);
      this.DevAcc.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
      this.DevAcc.Size = new System.Drawing.Size(333, 820);
      this.DevAcc.TabIndex = 108;
      this.DevAcc.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
      this.DevAcc.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.DevAcc_ElementClick);
      // 
      // pdf
      // 
      this.pdf.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pdf.Location = new System.Drawing.Point(333, 160);
      this.pdf.MenuManager = this.ribbonControl1;
      this.pdf.Name = "pdf";
      this.ribbonControl1.SetPopupContextMenu(this.pdf, this.popupMenu1);
      this.pdf.Size = new System.Drawing.Size(1038, 820);
      this.pdf.TabIndex = 114;
      this.pdf.DocumentChanged += new DevExpress.XtraPdfViewer.PdfDocumentChangedEventHandler(this.pdf_DocumentChanged);
      this.pdf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pdf_MouseClick);
      // 
      // pdfBarController1
      // 
      this.pdfBarController1.BarItems.Add(this.pdfFileOpenBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfFileSaveAsBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfFilePrintBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfFindTextBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfPreviousPageBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfNextPageBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfSetPageNumberBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoomOutBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoomInBarItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem1);
      this.pdfBarController1.BarItems.Add(this.pdfExactZoomListBarSubItem1);
      this.pdfBarController1.Control = this.pdf;
      // 
      // popupMenu1
      // 
      this.popupMenu1.Name = "popupMenu1";
      this.popupMenu1.Ribbon = this.ribbonControl1;
      // 
      // FrmManual
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1371, 1004);
      this.Controls.Add(this.pdf);
      this.Controls.Add(this.DevAcc);
      this.Controls.Add(this.ribbonStatusBar1);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "FrmManual";
      this.Ribbon = this.ribbonControl1;
      this.StatusBar = this.ribbonStatusBar1;
      this.Text = "매뉴얼";
      this.Load += new System.EventHandler(this.FrmManual_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DevAcc)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem pdfFileOpenBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem pdfFilePrintBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem pdfFindTextBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem pdfPreviousPageBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem pdfSetPageNumberBarItem1;
    private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem pdfZoomOutBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem pdfZoomInBarItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem1;
    private DevExpress.XtraPdfViewer.Bars.PdfRibbonPage pdfRibbonPage1;
    private DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup pdfFileRibbonPageGroup1;
    private DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup pdfFindRibbonPageGroup1;
    private DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup pdfNavigationRibbonPageGroup1;
    private DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup pdfZoomRibbonPageGroup1;
    internal DevExpress.XtraBars.Navigation.AccordionControl DevAcc;
    private DevExpress.XtraPdfViewer.PdfViewer pdf;
    private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
    private DevExpress.XtraBars.PopupMenu popupMenu1;
  }
}
