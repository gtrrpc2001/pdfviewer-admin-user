
namespace pdfViewer.frm
{
    partial class frmCodeEdit
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
            this.PdfViewer2 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnModi = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // PdfViewer2
            // 
            this.PdfViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PdfViewer2.Location = new System.Drawing.Point(1, 24);
            this.PdfViewer2.Name = "PdfViewer2";
            this.PdfViewer2.Size = new System.Drawing.Size(975, 553);
            this.PdfViewer2.TabIndex = 1;
            this.PdfViewer2.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCode.Location = new System.Drawing.Point(1, 1);
            this.txtCode.Name = "txtCode";
            this.txtCode.PreventEnterBeep = true;
            this.txtCode.Size = new System.Drawing.Size(901, 21);
            this.txtCode.TabIndex = 2;
            // 
            // btnModi
            // 
            this.btnModi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnModi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModi.Location = new System.Drawing.Point(902, 0);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(75, 23);
            this.btnModi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnModi.TabIndex = 3;
            this.btnModi.Text = "수정";
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // frmCodeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 578);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.PdfViewer2);
            this.Name = "frmCodeEdit";
            this.Text = "PDF코드수정";
            this.Load += new System.EventHandler(this.frmCodeEdit_Load);
            this.ResumeLayout(false);

        }
        private DevExpress.XtraPdfViewer.PdfViewer PdfViewer2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        private DevComponents.DotNetBar.ButtonX btnModi;
        #endregion
    }
}