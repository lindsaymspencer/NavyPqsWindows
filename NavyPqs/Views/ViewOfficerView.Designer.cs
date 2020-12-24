
namespace NavyPqs.Views
{
    partial class frmViewOfficer
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
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBxSections2A = new System.Windows.Forms.ComboBox();
            this.cmbBxSections2B = new System.Windows.Forms.ComboBox();
            this.btnEditOfficer = new System.Windows.Forms.Button();
            this.tbCntrl = new System.Windows.Forms.TabControl();
            this.tb2A = new System.Windows.Forms.TabPage();
            this.btn2aSelectAll = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lbl2aMessage = new System.Windows.Forms.Label();
            this.btnSave2A = new System.Windows.Forms.Button();
            this.lstBxLineItems2A = new System.Windows.Forms.CheckedListBox();
            this.tb2B = new System.Windows.Forms.TabPage();
            this.lblSave2B = new System.Windows.Forms.Label();
            this.btnSave2B = new System.Windows.Forms.Button();
            this.lstBxLineItems2B = new System.Windows.Forms.CheckedListBox();
            this.btn2BSelectAll = new System.Windows.Forms.Button();
            this.tbCntrl.SuspendLayout();
            this.tb2A.SuspendLayout();
            this.tb2B.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Fill";
            // 
            // cmbBxSections2A
            // 
            this.cmbBxSections2A.FormattingEnabled = true;
            this.cmbBxSections2A.Location = new System.Drawing.Point(6, 8);
            this.cmbBxSections2A.Name = "cmbBxSections2A";
            this.cmbBxSections2A.Size = new System.Drawing.Size(624, 28);
            this.cmbBxSections2A.TabIndex = 2;
            this.cmbBxSections2A.SelectedIndexChanged += new System.EventHandler(this.cmbBxSections2A_SelectedIndexChanged);
            // 
            // cmbBxSections2B
            // 
            this.cmbBxSections2B.FormattingEnabled = true;
            this.cmbBxSections2B.Location = new System.Drawing.Point(8, 12);
            this.cmbBxSections2B.Name = "cmbBxSections2B";
            this.cmbBxSections2B.Size = new System.Drawing.Size(624, 28);
            this.cmbBxSections2B.TabIndex = 6;
            this.cmbBxSections2B.SelectedIndexChanged += new System.EventHandler(this.cmbBxSections2B_SelectedIndexChanged);
            // 
            // btnEditOfficer
            // 
            this.btnEditOfficer.Location = new System.Drawing.Point(494, 15);
            this.btnEditOfficer.Name = "btnEditOfficer";
            this.btnEditOfficer.Size = new System.Drawing.Size(156, 37);
            this.btnEditOfficer.TabIndex = 3;
            this.btnEditOfficer.Text = "Edit Details";
            this.btnEditOfficer.UseVisualStyleBackColor = true;
            this.btnEditOfficer.Click += new System.EventHandler(this.btnEditOfficer_Click);
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tb2A);
            this.tbCntrl.Controls.Add(this.tb2B);
            this.tbCntrl.Location = new System.Drawing.Point(14, 60);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(648, 488);
            this.tbCntrl.TabIndex = 4;
            this.tbCntrl.Tag = "";
            // 
            // tb2A
            // 
            this.tb2A.Controls.Add(this.btn2aSelectAll);
            this.tb2A.Controls.Add(this.btnConvert);
            this.tb2A.Controls.Add(this.lbl2aMessage);
            this.tb2A.Controls.Add(this.btnSave2A);
            this.tb2A.Controls.Add(this.lstBxLineItems2A);
            this.tb2A.Controls.Add(this.cmbBxSections2A);
            this.tb2A.Location = new System.Drawing.Point(4, 29);
            this.tb2A.Name = "tb2A";
            this.tb2A.Padding = new System.Windows.Forms.Padding(3);
            this.tb2A.Size = new System.Drawing.Size(640, 455);
            this.tb2A.TabIndex = 0;
            this.tb2A.Text = "tb2B";
            this.tb2A.UseVisualStyleBackColor = true;
            // 
            // btn2aSelectAll
            // 
            this.btn2aSelectAll.Location = new System.Drawing.Point(457, 59);
            this.btn2aSelectAll.Name = "btn2aSelectAll";
            this.btn2aSelectAll.Size = new System.Drawing.Size(103, 41);
            this.btn2aSelectAll.TabIndex = 7;
            this.btn2aSelectAll.Text = "Select All";
            this.btn2aSelectAll.UseVisualStyleBackColor = true;
            this.btn2aSelectAll.Click += new System.EventHandler(this.btn2aSelectAll_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(108, 397);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(156, 37);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert to 2B";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lbl2aMessage
            // 
            this.lbl2aMessage.AutoSize = true;
            this.lbl2aMessage.Location = new System.Drawing.Point(270, 405);
            this.lbl2aMessage.Name = "lbl2aMessage";
            this.lbl2aMessage.Size = new System.Drawing.Size(0, 20);
            this.lbl2aMessage.TabIndex = 6;
            // 
            // btnSave2A
            // 
            this.btnSave2A.Location = new System.Drawing.Point(6, 397);
            this.btnSave2A.Name = "btnSave2A";
            this.btnSave2A.Size = new System.Drawing.Size(96, 37);
            this.btnSave2A.TabIndex = 5;
            this.btnSave2A.Text = "Save";
            this.btnSave2A.UseVisualStyleBackColor = true;
            this.btnSave2A.Click += new System.EventHandler(this.btnSave2A_Click);
            // 
            // lstBxLineItems2A
            // 
            this.lstBxLineItems2A.FormattingEnabled = true;
            this.lstBxLineItems2A.Location = new System.Drawing.Point(6, 45);
            this.lstBxLineItems2A.Name = "lstBxLineItems2A";
            this.lstBxLineItems2A.Size = new System.Drawing.Size(421, 326);
            this.lstBxLineItems2A.TabIndex = 3;
            this.lstBxLineItems2A.SelectedIndexChanged += new System.EventHandler(this.lstBxLineItems2A_SelectedIndexChanged);
            // 
            // tb2B
            // 
            this.tb2B.Controls.Add(this.btn2BSelectAll);
            this.tb2B.Controls.Add(this.lblSave2B);
            this.tb2B.Controls.Add(this.btnSave2B);
            this.tb2B.Controls.Add(this.lstBxLineItems2B);
            this.tb2B.Controls.Add(this.cmbBxSections2B);
            this.tb2B.Location = new System.Drawing.Point(4, 29);
            this.tb2B.Name = "tb2B";
            this.tb2B.Padding = new System.Windows.Forms.Padding(3);
            this.tb2B.Size = new System.Drawing.Size(640, 455);
            this.tb2B.TabIndex = 1;
            this.tb2B.Text = "tb2B";
            this.tb2B.UseVisualStyleBackColor = true;
            // 
            // lblSave2B
            // 
            this.lblSave2B.AutoSize = true;
            this.lblSave2B.Location = new System.Drawing.Point(123, 403);
            this.lblSave2B.Name = "lblSave2B";
            this.lblSave2B.Size = new System.Drawing.Size(0, 20);
            this.lblSave2B.TabIndex = 9;
            // 
            // btnSave2B
            // 
            this.btnSave2B.Location = new System.Drawing.Point(8, 403);
            this.btnSave2B.Name = "btnSave2B";
            this.btnSave2B.Size = new System.Drawing.Size(96, 37);
            this.btnSave2B.TabIndex = 8;
            this.btnSave2B.Text = "Save";
            this.btnSave2B.UseVisualStyleBackColor = true;
            this.btnSave2B.Click += new System.EventHandler(this.btnSave2B_Click);
            // 
            // lstBxLineItems2B
            // 
            this.lstBxLineItems2B.FormattingEnabled = true;
            this.lstBxLineItems2B.Location = new System.Drawing.Point(8, 49);
            this.lstBxLineItems2B.Name = "lstBxLineItems2B";
            this.lstBxLineItems2B.Size = new System.Drawing.Size(421, 326);
            this.lstBxLineItems2B.TabIndex = 7;
            this.lstBxLineItems2B.SelectedIndexChanged += new System.EventHandler(this.lstBxLineItems2B_SelectedIndexChanged);
            // 
            // btn2BSelectAll
            // 
            this.btn2BSelectAll.Location = new System.Drawing.Point(448, 64);
            this.btn2BSelectAll.Name = "btn2BSelectAll";
            this.btn2BSelectAll.Size = new System.Drawing.Size(103, 41);
            this.btn2BSelectAll.TabIndex = 10;
            this.btn2BSelectAll.Text = "Select All";
            this.btn2BSelectAll.UseVisualStyleBackColor = true;
            this.btn2BSelectAll.Click += new System.EventHandler(this.btn2BSelectAll_Click);
            // 
            // frmViewOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 563);
            this.Controls.Add(this.tbCntrl);
            this.Controls.Add(this.btnEditOfficer);
            this.Controls.Add(this.lblName);
            this.Name = "frmViewOfficer";
            this.Text = "Officer Details";
            this.tbCntrl.ResumeLayout(false);
            this.tb2A.ResumeLayout(false);
            this.tb2A.PerformLayout();
            this.tb2B.ResumeLayout(false);
            this.tb2B.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBxSections2A;
        private System.Windows.Forms.Button btnEditOfficer;
        private System.Windows.Forms.TabControl tbCntrl;
        private System.Windows.Forms.TabPage tb2A;
        private System.Windows.Forms.CheckedListBox lstBxLineItems2A;
        private System.Windows.Forms.Button btnSave2A;
        private System.Windows.Forms.Label lbl2aMessage;
        private System.Windows.Forms.TabPage tb2B;
        private System.Windows.Forms.Button btnSave2B;
        private System.Windows.Forms.CheckedListBox lstBxLineItems2B;
        private System.Windows.Forms.ComboBox cmbBxSections2B;
        private System.Windows.Forms.Label lblSave2B;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btn2aSelectAll;
        private System.Windows.Forms.Button btn2BSelectAll;
    }
}