
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace pdfViewer.usercontrol
{
    partial class pdfManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pdfManager));
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.chkPdf = new System.Windows.Forms.CheckBox();
            this.btnFirstNodes = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnInsert = new DevComponents.DotNetBar.ButtonX();
            this.btnPdfUpload = new DevComponents.DotNetBar.ButtonItem();
            this.btnPDFInsert = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPDFoption = new DevComponents.DotNetBar.ButtonX();
            this.btnPDFopen = new DevComponents.DotNetBar.ButtonItem();
            this.btnPDFclose = new DevComponents.DotNetBar.ButtonItem();
            this.cmbGubun = new System.Windows.Forms.ComboBox();
            this.Line1 = new DevComponents.DotNetBar.Controls.Line();
            this.txtGumsek = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.spr = new FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, resources.GetObject("resource1"));
            this.spr_Sheet1 = this.spr.GetSheet(0);
            this.btnDown = new DevComponents.DotNetBar.ButtonX();
            this.btnUp = new DevComponents.DotNetBar.ButtonX();
            this.btnItemPdfDel = new DevComponents.DotNetBar.ButtonItem();
            this.BtnNodeDel = new DevComponents.DotNetBar.ButtonItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.node수정 = new System.Windows.Forms.ToolStripMenuItem();
            this.Code수정 = new System.Windows.Forms.ToolStripMenuItem();
            this.Code삭제 = new System.Windows.Forms.ToolStripMenuItem();
            this.node삭제 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Row추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Row제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tv_manager = new pdfViewer.usercontrol.UserTreeView();
            this.pnl.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.ContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Controls.Add(this.chkPdf);
            this.pnl.Controls.Add(this.btnFirstNodes);
            this.pnl.Controls.Add(this.btnReset);
            this.pnl.Controls.Add(this.btnInsert);
            this.pnl.Controls.Add(this.btnDelete);
            this.pnl.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 281);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(499, 25);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.pnl.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 24;
            // 
            // _chkPdf
            // 
            this.chkPdf.AutoSize = true;
            this.chkPdf.ForeColor = System.Drawing.Color.Black;
            this.chkPdf.Location = new System.Drawing.Point(5, 6);
            this.chkPdf.Name = "chkPdf";
            this.chkPdf.Size = new System.Drawing.Size(107, 16);
            this.chkPdf.TabIndex = 9;
            this.chkPdf.Text = "PDF페이지체크";
            this.chkPdf.UseVisualStyleBackColor = true;
            // 
            // _btnFirstNodes
            // 
            this.btnFirstNodes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFirstNodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.btnFirstNodes.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnFirstNodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstNodes.Location = new System.Drawing.Point(408, 1);
            this.btnFirstNodes.Name = "btnFirstNodes";
            this.btnFirstNodes.Size = new System.Drawing.Size(90, 26);
            this.btnFirstNodes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFirstNodes.Symbol = "";
            this.btnFirstNodes.SymbolColor = System.Drawing.Color.White;
            this.btnFirstNodes.SymbolSize = 13F;
            this.btnFirstNodes.TabIndex = 7;
            this.btnFirstNodes.Text = "목차";
            this.btnFirstNodes.TextColor = System.Drawing.Color.White;
            this.btnFirstNodes.Click += new System.EventHandler(this._btnFirstNodes_Click);
            // 
            // _btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(311, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 25);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnReset.Symbol = "";
            this.btnReset.SymbolColor = System.Drawing.Color.White;
            this.btnReset.SymbolSize = 13F;
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "리셋";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.Click += new System.EventHandler(this._btnReset_Click);
            // 
            // _btnInsert
            // 
            this.btnInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Location = new System.Drawing.Point(117, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 25);
            this.btnInsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsert.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPdfUpload,
            this.btnPDFInsert});
            this.btnInsert.Symbol = "";
            this.btnInsert.SymbolColor = System.Drawing.Color.White;
            this.btnInsert.SymbolSize = 13F;
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "저장";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.Click += new System.EventHandler(this._btnInsert_Click);
            // 
            // _btnPdfUpload
            // 
            this.btnPdfUpload.GlobalItem = false;
            this.btnPdfUpload.Image = global::pdfViewer.Properties.Resources.pdf01;
            this.btnPdfUpload.Name = "btnPdfUpload";
            this.btnPdfUpload.Text = "PDF업로드";
            this.btnPdfUpload.Click += new System.EventHandler(this._btnPdfUpload_Click);
            // 
            // _btnPDFInsert
            // 
            this.btnPDFInsert.GlobalItem = false;
            this.btnPDFInsert.Image = global::pdfViewer.Properties.Resources.pdf01;
            this.btnPDFInsert.Name = "btnPDFInsert";
            this.btnPDFInsert.Text = "PDF저장";
            this.btnPDFInsert.Click += new System.EventHandler(this._btnPDFInsert_Click);
            // 
            // _btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(214, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 25);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.SymbolColor = System.Drawing.Color.White;
            this.btnDelete.SymbolSize = 13F;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(460, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 24);
            this.btnSearch.Symbol = "";
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Tag = "";
            this.btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.btnPDFoption);
            this.Panel1.Controls.Add(this.cmbGubun);
            this.Panel1.Controls.Add(this.btnSearch);
            this.Panel1.Controls.Add(this.Line1);
            this.Panel1.Controls.Add(this.txtGumsek);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(499, 30);
            this.Panel1.TabIndex = 34;
            // 
            // _btnPDFoption
            // 
            this.btnPDFoption.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPDFoption.BackColor = System.Drawing.Color.Black;
            this.btnPDFoption.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnPDFoption.Location = new System.Drawing.Point(121, -1);
            this.btnPDFoption.Name = "btnPDFoption";
            this.btnPDFoption.Size = new System.Drawing.Size(91, 25);
            this.btnPDFoption.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPDFoption.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPDFopen,
            this.btnPDFclose});
            this.btnPDFoption.TabIndex = 103;
            this.btnPDFoption.Text = "PDF옵션";
            this.btnPDFoption.TextColor = System.Drawing.Color.White;
            // 
            // _btnPDFopen
            // 
            this.btnPDFopen.GlobalItem = false;
            this.btnPDFopen.Image = global::pdfViewer.Properties.Resources.pdf01;
            this.btnPDFopen.Name = "btnPDFopen";
            this.btnPDFopen.Text = "PDF불러오기";
            this.btnPDFopen.Click += new System.EventHandler(this._btnPDFopen_Click);
            // 
            // _btnPDFclose
            // 
            this.btnPDFclose.GlobalItem = false;
            this.btnPDFclose.Name = "btnPDFclose";
            this.btnPDFclose.Symbol = "";
            this.btnPDFclose.SymbolSize = 8.5F;
            this.btnPDFclose.Text = "PDF닫기";
            this.btnPDFclose.Click += new System.EventHandler(this._btnPDFclose_Click);
            // 
            // _cmbGubun
            // 
            this.cmbGubun.FormattingEnabled = true;
            this.cmbGubun.Items.AddRange(new object[] {
            "0 eClick",
            "1 uClick"});
            this.cmbGubun.Location = new System.Drawing.Point(0, 0);
            this.cmbGubun.Name = "cmbGubun";
            this.cmbGubun.Size = new System.Drawing.Size(121, 20);
            this.cmbGubun.TabIndex = 101;
            this.cmbGubun.SelectedIndexChanged += new System.EventHandler(this._cmbGubun_SelectedIndexChanged);
            this.cmbGubun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cmbGubun_KeyPress);
            // 
            // _Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.EndLineCapSize = new System.Drawing.Size(0, 0);
            this.Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.Line1.Location = new System.Drawing.Point(0, 19);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(499, 10);
            this.Line1.TabIndex = 100;
            // 
            // _txtGumsek
            // 
            this.txtGumsek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGumsek.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGumsek.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtGumsek.Location = new System.Drawing.Point(213, 0);
            this.txtGumsek.Multiline = true;
            this.txtGumsek.Name = "txtGumsek";
            this.txtGumsek.Size = new System.Drawing.Size(247, 29);
            this.txtGumsek.TabIndex = 1;
            this.txtGumsek.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtGumsek_KeyDown);
            // 
            // _txtAddr
            // 
            this.txtAddr.BackColor = System.Drawing.Color.White;
            this.txtAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddr.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddr.Enabled = false;
            this.txtAddr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAddr.Location = new System.Drawing.Point(0, 260);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.ReadOnly = true;
            this.txtAddr.Size = new System.Drawing.Size(499, 21);
            this.txtAddr.TabIndex = 35;
            // 
            // _Pnl2
            // 
            this.Pnl2.Controls.Add(this.spr);
            this.Pnl2.Controls.Add(this.btnDown);
            this.Pnl2.Controls.Add(this.btnUp);
            this.Pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl2.Location = new System.Drawing.Point(0, 306);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(499, 308);
            this.Pnl2.TabIndex = 36;
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "fpSpread1, Sheet1, Row 0, Column 0";
            this.spr.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr.Location = new System.Drawing.Point(0, 1);
            this.spr.Name = "spr";
            this.spr.Size = new System.Drawing.Size(470, 308);
            this.spr.TabIndex = 11;
            this.spr.DialogKey += new FarPoint.Win.Spread.DialogKeyEventHandler(this.spr_DialogKey);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            this.spr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spr_KeyDown);
            this.spr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spr_KeyUp);
            this.spr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spr_MouseDown);
            this.spr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spr_MouseUp);
            // 
            // _btnDown
            // 
            this.btnDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.btnDown.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Location = new System.Drawing.Point(469, 152);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(29, 157);
            this.btnDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDown.Symbol = "";
            this.btnDown.SymbolSize = 15F;
            this.btnDown.TabIndex = 10;
            this.btnDown.TextColor = System.Drawing.Color.White;
            this.btnDown.Click += new System.EventHandler(this._btnDown_Click);
            // 
            // _btnUp
            // 
            this.btnUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(77)))));
            this.btnUp.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Location = new System.Drawing.Point(469, 1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(29, 151);
            this.btnUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUp.Symbol = "";
            this.btnUp.SymbolColor = System.Drawing.Color.White;
            this.btnUp.SymbolSize = 15F;
            this.btnUp.TabIndex = 9;
            this.btnUp.Click += new System.EventHandler(this._btnUp_Click);
            // 
            // _btnItemPdfDel
            // 
            this.btnItemPdfDel.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnItemPdfDel.Name = "btnItemPdfDel";
            this.btnItemPdfDel.SubItemsExpandWidth = 10;
            this.btnItemPdfDel.Text = "pdf삭제";
            // 
            // _BtnNodeDel
            // 
            this.BtnNodeDel.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.BtnNodeDel.Name = "BtnNodeDel";
            this.BtnNodeDel.Text = "삭제";
            // 
            // _ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.node수정,
            this.Code수정,
            this.Code삭제,
            this.node삭제});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(127, 92);
            // 
            // _node수정
            // 
            this.node수정.Name = "node수정";
            this.node수정.Size = new System.Drawing.Size(126, 22);
            this.node수정.Text = "이름변경";
            this.node수정.Click += new System.EventHandler(this._node수정_Click);
            // 
            // _Code수정
            // 
            this.Code수정.Name = "Code수정";
            this.Code수정.Size = new System.Drawing.Size(126, 22);
            this.Code수정.Text = "Code수정";
            this.Code수정.Click += new System.EventHandler(this._Code수정_Click);
            // 
            // _Code삭제
            // 
            this.Code삭제.Name = "Code삭제";
            this.Code삭제.Size = new System.Drawing.Size(126, 22);
            this.Code삭제.Text = "Code삭제";
            this.Code삭제.Click += new System.EventHandler(this._Code삭제_Click);
            // 
            // _node삭제
            // 
            this.node삭제.Name = "node삭제";
            this.node삭제.Size = new System.Drawing.Size(126, 22);
            this.node삭제.Text = "삭제";
            this.node삭제.Click += new System.EventHandler(this._node삭제_Click);
            // 
            // _ContextMenuStrip2
            // 
            this.ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Row추가ToolStripMenuItem,
            this.Row제거ToolStripMenuItem});
            this.ContextMenuStrip2.Name = "ContextMenuStrip2";
            this.ContextMenuStrip2.Size = new System.Drawing.Size(119, 48);
            // 
            // _Row추가ToolStripMenuItem
            // 
            this.Row추가ToolStripMenuItem.Name = "Row추가ToolStripMenuItem";
            this.Row추가ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.Row추가ToolStripMenuItem.Text = "row추가";
            this.Row추가ToolStripMenuItem.Click += new System.EventHandler(this._Row추가ToolStripMenuItem_Click);
            // 
            // _Row제거ToolStripMenuItem
            // 
            this.Row제거ToolStripMenuItem.Name = "Row제거ToolStripMenuItem";
            this.Row제거ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.Row제거ToolStripMenuItem.Text = "row제거";
            this.Row제거ToolStripMenuItem.Click += new System.EventHandler(this._Row제거ToolStripMenuItem_Click);
            // 
            // _tv_manager
            // 
            this.tv_manager.Dock = System.Windows.Forms.DockStyle.Top;
            this.tv_manager.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tv_manager.Location = new System.Drawing.Point(0, 30);
            this.tv_manager.Name = "tv_manager";
            this.tv_manager.PathSeparator = "|";
            this.tv_manager.preventExpand = false;
            this.tv_manager.Size = new System.Drawing.Size(499, 230);
            this.tv_manager.TabIndex = 11;
            this.tv_manager.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this._tv_manager_AfterLabelEdit);
            this.tv_manager.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this._tv_manager_AfterCollapse);
            this.tv_manager.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this._tv_manager_AfterExpand);
            this.tv_manager.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this._tv_manager_DrawNode);
            this.tv_manager.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._tv_manager_NodeMouseClick);
            this.tv_manager.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._tv_manager_NodeMouseDoubleClick);
            this.tv_manager.KeyDown += new System.Windows.Forms.KeyEventHandler(this._tv_manager_KeyDown);
            this.tv_manager.KeyUp += new System.Windows.Forms.KeyEventHandler(this._tv_manager_KeyUp);
            this.tv_manager.MouseMove += new System.Windows.Forms.MouseEventHandler(this._tv_manager_MouseMove);
            // 
            // pdfManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.tv_manager);
            this.Controls.Add(this.Panel1);
            this.Name = "pdfManager";
            this.Size = new System.Drawing.Size(499, 614);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DevComponents.DotNetBar.PanelEx pnl;
        private DevComponents.DotNetBar.ButtonX btnFirstNodes;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnInsert;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private Panel Panel1;
        private TextBox txtGumsek;
        private TextBox txtAddr;
        private Panel Pnl2;
        private DevComponents.DotNetBar.Controls.Line Line1;
        private DevComponents.DotNetBar.ButtonX btnUp;
        private DevComponents.DotNetBar.ButtonX btnDown;
        private DevComponents.DotNetBar.ButtonItem btnItemPdfDel;
        private DevComponents.DotNetBar.ButtonItem BtnNodeDel;
        private ContextMenuStrip ContextMenuStrip1;
        private ToolStripMenuItem node삭제;
        private ToolStripMenuItem Code삭제;
        private ToolStripMenuItem node수정;
        private ToolStripMenuItem Code수정;
        internal ToolStripSeparator ToolStripSeparator2;
        private ComboBox cmbGubun;
        public UserTreeView tv_manager;
        private ContextMenuStrip ContextMenuStrip2;
        private ToolStripMenuItem Row추가ToolStripMenuItem;
        private ToolStripMenuItem Row제거ToolStripMenuItem;        
        private CheckBox chkPdf;         
        private DevComponents.DotNetBar.ButtonX btnPDFoption;        
        private DevComponents.DotNetBar.ButtonItem btnPDFopen;
        private DevComponents.DotNetBar.ButtonItem btnPDFclose;
        private DevComponents.DotNetBar.ButtonItem btnPdfUpload;
        private DevComponents.DotNetBar.ButtonItem btnPDFInsert;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;          
            #endregion
        }
}
