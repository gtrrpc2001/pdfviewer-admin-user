
using System.Windows.Forms;

namespace pdfViewer.frm
{
    partial class frmUpload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtVersion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0";
            this.spr.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.spr.Location = new System.Drawing.Point(1, 26);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(593, 91);
            this.spr.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Default;
            this.spr.TabIndex = 0;
            this.spr.TabStripRatio = 0D;
            this.spr.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            this.spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ColumnCount = 2;
            this.spr_Sheet1.RowCount = 2;
            this.spr_Sheet1.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Default;
            this.spr_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnFooter.Columns.Default.Width = 72F;
            this.spr_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.ColumnFooter.DefaultStyle.Locked = false;
            this.spr_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced";
            this.spr_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnFooter.Rows.Get(0).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnFooter.Rows.Get(0).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnFooter.Rows.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnFooter.Rows.Get(0).Locked = false;
            this.spr_Sheet1.ColumnFooter.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.ColumnFooterSheetCornerStyle.Locked = false;
            this.spr_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced";
            this.spr_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).Border = null;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).Locked = false;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "Name";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Border = null;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Locked = false;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "Path";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Locked = false;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced";
            this.spr_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.Rows.Get(0).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Rows.Get(0).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Rows.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Rows.Get(0).Locked = false;
            this.spr_Sheet1.ColumnHeader.Rows.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Default.Width = 72F;
            this.spr_Sheet1.Columns.Get(0).CellType = textCellType7;
            this.spr_Sheet1.Columns.Get(0).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.Columns.Get(0).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.Columns.Get(0).Label = "Name";
            this.spr_Sheet1.Columns.Get(0).Locked = false;
            this.spr_Sheet1.Columns.Get(0).Tag = "Name";
            this.spr_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Get(0).Width = 150F;
            this.spr_Sheet1.Columns.Get(1).CellType = textCellType8;
            this.spr_Sheet1.Columns.Get(1).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.Columns.Get(1).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.Columns.Get(1).Label = "Path";
            this.spr_Sheet1.Columns.Get(1).Locked = false;
            this.spr_Sheet1.Columns.Get(1).Tag = "Path";
            this.spr_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Get(1).Width = 400F;
            this.spr_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.DefaultStyle.Locked = false;
            this.spr_Sheet1.DefaultStyle.Parent = "DataAreaDefault";
            this.spr_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.FilterBar.DefaultStyle.Locked = false;
            this.spr_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced";
            this.spr_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.FilterBarHeaderStyle.Locked = false;
            this.spr_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced";
            this.spr_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.RowHeader.DefaultStyle.Locked = false;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced";
            this.spr_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.Rows.Default.Height = 22F;
            this.spr_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty;
            this.spr_Sheet1.SheetCornerStyle.Locked = false;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerDefaultEnhanced";
            this.spr_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(2, 4);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(39, 18);
            this.LabelX1.TabIndex = 2;
            this.LabelX1.Text = "버젼 :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.txtVersion);
            this.Panel1.Controls.Add(this.LabelX1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(594, 26);
            this.Panel1.TabIndex = 3;
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVersion.Border.Class = "TextBoxBorder";
            this.txtVersion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVersion.DisabledBackColor = System.Drawing.Color.White;
            this.txtVersion.ForeColor = System.Drawing.Color.Black;
            this.txtVersion.Location = new System.Drawing.Point(40, 2);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.PreventEnterBeep = true;
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(137, 21);
            this.txtVersion.TabIndex = 3;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpen.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnOpen.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnOpen.Appearance.Options.UseBackColor = true;
            this.btnOpen.Appearance.Options.UseBorderColor = true;
            this.btnOpen.Appearance.Options.UseFont = true;
            this.btnOpen.Appearance.Options.UseForeColor = true;
            this.btnOpen.Location = new System.Drawing.Point(178, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(102, 24);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "File불러오기";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReset.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnReset.Appearance.Options.UseBackColor = true;
            this.btnReset.Appearance.Options.UseBorderColor = true;
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Appearance.Options.UseForeColor = true;
            this.btnReset.Location = new System.Drawing.Point(281, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 24);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "리셋";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpload.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnUpload.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnUpload.Appearance.Options.UseBackColor = true;
            this.btnUpload.Appearance.Options.UseBorderColor = true;
            this.btnUpload.Appearance.Options.UseFont = true;
            this.btnUpload.Appearance.Options.UseForeColor = true;
            this.btnUpload.Location = new System.Drawing.Point(384, 1);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(102, 24);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "PDF업로드";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseBorderColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Location = new System.Drawing.Point(487, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "PDF저장";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 112);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUpload";
            this.Text = "매뉴얼업데이트";
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private FarPoint.Win.Spread.FpSpread spr;       
        private DevComponents.DotNetBar.LabelX LabelX1;        
        private Panel Panel1;        
        private DevComponents.DotNetBar.Controls.TextBoxX txtVersion;        
        private OpenFileDialog OpenFileDialog1;      
        private FarPoint.Win.Spread.SheetView spr_Sheet1;        
        private DevExpress.XtraEditors.SimpleButton btnOpen;        
        private DevExpress.XtraEditors.SimpleButton btnReset;        
        private DevExpress.XtraEditors.SimpleButton btnUpload;        
        private DevExpress.XtraEditors.SimpleButton btnSave;       

        #endregion
    }
}