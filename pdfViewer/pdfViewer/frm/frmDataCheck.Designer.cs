
using System.Windows.Forms;

namespace pdfViewer.frm
{
    partial class frmDataCheck
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.ButtonCellType buttonCellType3 = new FarPoint.Win.Spread.CellType.ButtonCellType();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "spr, Sheet1, Row 0, Column 0";
            this.spr.Dock = System.Windows.Forms.DockStyle.Top;
            this.spr.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr.Location = new System.Drawing.Point(0, 0);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(878, 483);
            this.spr.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Default;
            this.spr.TabIndex = 0;
            this.spr.TabStripRatio = 0D;
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            this.spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ColumnCount = 5;
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
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "Code";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Border = null;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Locked = false;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "Path";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).Border = null;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).Locked = false;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "Page";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).Border = null;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).Locked = false;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "Error";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).Border = null;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).Locked = false;
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "Button";
            this.spr_Sheet1.ColumnHeader.Cells.Get(0, 4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
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
            this.spr_Sheet1.Columns.Get(0).Label = "Code";
            this.spr_Sheet1.Columns.Get(0).Locked = false;
            this.spr_Sheet1.Columns.Get(0).Tag = "Code";
            this.spr_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Get(0).Width = 200F;
            this.spr_Sheet1.Columns.Get(1).CellType = textCellType8;
            this.spr_Sheet1.Columns.Get(1).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.Columns.Get(1).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.Columns.Get(1).Label = "Path";
            this.spr_Sheet1.Columns.Get(1).Locked = false;
            this.spr_Sheet1.Columns.Get(1).Tag = "Path";
            this.spr_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Get(1).Width = 200F;
            this.spr_Sheet1.Columns.Get(2).Label = "Page";
            this.spr_Sheet1.Columns.Get(2).Tag = "Page";
            this.spr_Sheet1.Columns.Get(2).Width = 50F;
            this.spr_Sheet1.Columns.Get(3).CellType = textCellType9;
            this.spr_Sheet1.Columns.Get(3).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.Columns.Get(3).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.Columns.Get(3).Label = "Error";
            this.spr_Sheet1.Columns.Get(3).Locked = false;
            this.spr_Sheet1.Columns.Get(3).Tag = "Error";
            this.spr_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Get(3).Width = 300F;
            buttonCellType3.ButtonColor = System.Drawing.Color.CornflowerBlue;
            buttonCellType3.ButtonColor2 = System.Drawing.Color.CornflowerBlue;
            buttonCellType3.DarkColor = System.Drawing.SystemColors.ActiveCaption;
            buttonCellType3.Text = "수정";
            this.spr_Sheet1.Columns.Get(4).CellType = buttonCellType3;
            this.spr_Sheet1.Columns.Get(4).Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.spr_Sheet1.Columns.Get(4).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spr_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spr_Sheet1.Columns.Get(4).Label = "Button";
            this.spr_Sheet1.Columns.Get(4).Locked = false;
            this.spr_Sheet1.Columns.Get(4).Tag = "Button";
            this.spr_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spr_Sheet1.Columns.Get(4).Width = 70F;
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
            // bar
            // 
            this.bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar.Location = new System.Drawing.Point(0, 480);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(878, 23);
            this.bar.TabIndex = 1;
            // 
            // frmDataCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 503);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.spr);
            this.Name = "frmDataCheck";
            this.Text = "데이터체크리스트";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDataCheck_FormClosing);
            this.Load += new System.EventHandler(this.frmDataCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        private FarPoint.Win.Spread.FpSpread spr;        
        private FarPoint.Win.Spread.SheetView spr_Sheet1;                
        private ProgressBar bar;
        #endregion
    }
}