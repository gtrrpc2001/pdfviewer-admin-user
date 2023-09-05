
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace pdfViewer.frm
{
    partial class frmServer
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.BTN = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtSer = new System.Windows.Forms.TextBox();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.txtDBName);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.BTN);
            this.Panel1.Controls.Add(this.txtport);
            this.Panel1.Controls.Add(this.txtp);
            this.Panel1.Controls.Add(this.txtU);
            this.Panel1.Controls.Add(this.txtSer);
            this.Panel1.Controls.Add(this.TreeView1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(198, 166);
            this.Panel1.TabIndex = 0;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(69, 86);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(120, 21);
            this.txtDBName.TabIndex = 12;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label5.Location = new System.Drawing.Point(-1, 89);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 12);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "DBName :";
            // 
            // BTN
            // 
            this.BTN.BackColor = System.Drawing.Color.OldLace;
            this.BTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BTN.Location = new System.Drawing.Point(0, 143);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(198, 23);
            this.BTN.TabIndex = 5;
            this.BTN.Text = "연결";
            this.BTN.UseVisualStyleBackColor = false;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(69, 115);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(120, 21);
            this.txtport.TabIndex = 4;
            this.txtport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtport_KeyDown);
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(69, 58);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(120, 21);
            this.txtp.TabIndex = 3;
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(69, 30);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(120, 21);
            this.txtU.TabIndex = 2;
            // 
            // txtSer
            // 
            this.txtSer.Location = new System.Drawing.Point(69, 1);
            this.txtSer.Name = "txtSer";
            this.txtSer.Size = new System.Drawing.Size(120, 21);
            this.txtSer.TabIndex = 1;
            // 
            // TreeView1
            // 
            this.TreeView1.Location = new System.Drawing.Point(91, 245);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(8, 8);
            this.TreeView1.TabIndex = 4;
            this.TreeView1.Visible = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label4.Location = new System.Drawing.Point(19, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 12);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "PORT :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label3.Location = new System.Drawing.Point(26, 61);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 12);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "PWD :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label2.Location = new System.Drawing.Point(33, 34);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 12);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "UID :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.Location = new System.Drawing.Point(28, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 12);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "서버 :";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 166);
            this.Controls.Add(this.Panel1);
            this.Name = "frmServer";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel Panel1;       
        private Label Label4;       
        private Label Label3;       
        private Label Label2;       
        private Label Label1;        
        private TreeView TreeView1;      
        private TextBox txtport;        
        private TextBox txtp;       
        private TextBox txtU;       
        private TextBox txtSer;        
        private Button BTN;        
        private TextBox txtDBName;        
        private Label Label5;        
        #endregion
    }
}