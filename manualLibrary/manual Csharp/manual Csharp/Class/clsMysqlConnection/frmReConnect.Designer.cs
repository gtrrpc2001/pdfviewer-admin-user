
namespace manual_Csharp.Class.clsMysqlConnection
{
  partial class frmReConnect
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReConnect));
      this.lblText = new System.Windows.Forms.Label();
      this.btnExit = new DevExpress.XtraEditors.SimpleButton();
      this.symbolBox2 = new DevComponents.DotNetBar.Controls.SymbolBox();
      this.Line3 = new DevComponents.DotNetBar.Controls.Line();
      this.Line1 = new DevComponents.DotNetBar.Controls.Line();
      this.Line4 = new DevComponents.DotNetBar.Controls.Line();
      this.Line2 = new DevComponents.DotNetBar.Controls.Line();
      this.SuspendLayout();
      // 
      // lblText
      // 
      this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblText.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
      this.lblText.ForeColor = System.Drawing.Color.Black;
      this.lblText.Location = new System.Drawing.Point(0, 0);
      this.lblText.Name = "lblText";
      this.lblText.Size = new System.Drawing.Size(538, 89);
      this.lblText.TabIndex = 1;
      this.lblText.Text = "\r\n\r\n             서버 연결이 불안정해 재연결을 시도합니다.";
      // 
      // btnExit
      // 
      this.btnExit.Appearance.Font = new System.Drawing.Font("굴림", 9F);
      this.btnExit.Appearance.ForeColor = System.Drawing.Color.Crimson;
      this.btnExit.Appearance.Options.UseFont = true;
      this.btnExit.Appearance.Options.UseForeColor = true;
      this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
      this.btnExit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.btnExit.Location = new System.Drawing.Point(497, 9);
      this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
      this.btnExit.Name = "btnExit";
      this.btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
      this.btnExit.Size = new System.Drawing.Size(31, 23);
      this.btnExit.TabIndex = 2;
      this.btnExit.TabStop = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // symbolBox2
      // 
      // 
      // 
      // 
      this.symbolBox2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.symbolBox2.Location = new System.Drawing.Point(-6, 29);
      this.symbolBox2.Name = "symbolBox2";
      this.symbolBox2.Size = new System.Drawing.Size(75, 41);
      this.symbolBox2.Symbol = "";
      this.symbolBox2.SymbolSize = 25F;
      this.symbolBox2.TabIndex = 5;
      this.symbolBox2.Text = "symbolBox2";
      // 
      // Line3
      // 
      this.Line3.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line3.Location = new System.Drawing.Point(0, 6);
      this.Line3.Name = "Line3";
      this.Line3.Size = new System.Drawing.Size(10, 76);
      this.Line3.TabIndex = 6;
      this.Line3.Text = "Line1";
      this.Line3.Thickness = 10;
      this.Line3.VerticalLine = true;
      // 
      // Line1
      // 
      this.Line1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line1.Location = new System.Drawing.Point(0, 0);
      this.Line1.Name = "Line1";
      this.Line1.Size = new System.Drawing.Size(538, 7);
      this.Line1.TabIndex = 7;
      this.Line1.Text = "Line1";
      this.Line1.Thickness = 10;
      // 
      // Line4
      // 
      this.Line4.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line4.Location = new System.Drawing.Point(531, 2);
      this.Line4.Name = "Line4";
      this.Line4.Size = new System.Drawing.Size(10, 80);
      this.Line4.TabIndex = 8;
      this.Line4.Text = "Line1";
      this.Line4.Thickness = 10;
      this.Line4.VerticalLine = true;
      // 
      // Line2
      // 
      this.Line2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.Line2.Location = new System.Drawing.Point(0, 82);
      this.Line2.Name = "Line2";
      this.Line2.Size = new System.Drawing.Size(538, 7);
      this.Line2.TabIndex = 9;
      this.Line2.Text = "Line1";
      this.Line2.Thickness = 10;
      // 
      // frmReConnect
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(538, 89);
      this.Controls.Add(this.Line2);
      this.Controls.Add(this.Line4);
      this.Controls.Add(this.Line1);
      this.Controls.Add(this.Line3);
      this.Controls.Add(this.symbolBox2);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.lblText);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmReConnect";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmReConnect";
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Label lblText;
    internal DevExpress.XtraEditors.SimpleButton btnExit;
    internal DevComponents.DotNetBar.Controls.SymbolBox symbolBox2;
    internal DevComponents.DotNetBar.Controls.Line Line3;
    internal DevComponents.DotNetBar.Controls.Line Line1;
    internal DevComponents.DotNetBar.Controls.Line Line4;
    internal DevComponents.DotNetBar.Controls.Line Line2;
  }
}