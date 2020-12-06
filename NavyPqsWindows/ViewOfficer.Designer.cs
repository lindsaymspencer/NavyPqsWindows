
namespace NavyPqsWindows
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
            this.tb2B = new System.Windows.Forms.TabPage();
            this.lblSave2A = new System.Windows.Forms.Label();
            this.lblSave2B = new System.Windows.Forms.Label();
            this.btnSave2A = new System.Windows.Forms.Button();
            this.btnSave2B = new System.Windows.Forms.Button();
            this.lstBxLineItems2A = new System.Windows.Forms.CheckedListBox();
            this.lstBxLineItems2B = new System.Windows.Forms.CheckedListBox();
            this.tbCntrl.SuspendLayout();
            this.tb2A.SuspendLayout();
            this.tb2B.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Fill";
            // 
            // cmbBxSections2A
            // 
            this.cmbBxSections2A.FormattingEnabled = true;
            this.cmbBxSections2A.Location = new System.Drawing.Point(6, 6);
            this.cmbBxSections2A.Name = "cmbBxSections2A";
            this.cmbBxSections2A.Size = new System.Drawing.Size(555, 24);
            this.cmbBxSections2A.TabIndex = 2;
            this.cmbBxSections2A.SelectedIndexChanged += new System.EventHandler(this.cmbBxSections2A_SelectedIndexChanged);
            // 
            // btnEditOfficer
            // 
            this.btnEditOfficer.Location = new System.Drawing.Point(439, 12);
            this.btnEditOfficer.Name = "btnEditOfficer";
            this.btnEditOfficer.Size = new System.Drawing.Size(138, 30);
            this.btnEditOfficer.TabIndex = 3;
            this.btnEditOfficer.Text = "Edit Details";
            this.btnEditOfficer.UseVisualStyleBackColor = true;
            this.btnEditOfficer.Click += new System.EventHandler(this.btnEditOfficer_Click);
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tb2A);
            this.tbCntrl.Controls.Add(this.tb2B);
            this.tbCntrl.Location = new System.Drawing.Point(12, 48);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(576, 390);
            this.tbCntrl.TabIndex = 4;
            this.tbCntrl.Tag = "";
            // 
            // tb2A
            // 
            this.tb2A.Controls.Add(this.lblSave2A);
            this.tb2A.Controls.Add(this.btnSave2A);
            this.tb2A.Controls.Add(this.lstBxLineItems2A);
            this.tb2A.Controls.Add(this.cmbBxSections2A);
            this.tb2A.Location = new System.Drawing.Point(4, 25);
            this.tb2A.Name = "tb2A";
            this.tb2A.Padding = new System.Windows.Forms.Padding(3);
            this.tb2A.Size = new System.Drawing.Size(568, 361);
            this.tb2A.TabIndex = 0;
            this.tb2A.Text = "tb2B";
            this.tb2A.UseVisualStyleBackColor = true;
            // 
            // lblSave2A
            // 
            this.lblSave2A.AutoSize = true;
            this.lblSave2A.Location = new System.Drawing.Point(112, 324);
            this.lblSave2A.Name = "lblSave2A";
            this.lblSave2A.Size = new System.Drawing.Size(0, 17);
            this.lblSave2A.TabIndex = 6;
            // 
            // btnSave2A
            // 
            this.btnSave2A.Location = new System.Drawing.Point(6, 318);
            this.btnSave2A.Name = "btnSave2A";
            this.btnSave2A.Size = new System.Drawing.Size(85, 29);
            this.btnSave2A.TabIndex = 5;
            this.btnSave2A.Text = "Save";
            this.btnSave2A.UseVisualStyleBackColor = true;
            this.btnSave2A.Click += new System.EventHandler(this.btnSave2A_Click);
            // 
            // lstBxLineItems2A
            // 
            this.lstBxLineItems2A.FormattingEnabled = true;
            this.lstBxLineItems2A.Location = new System.Drawing.Point(6, 36);
            this.lstBxLineItems2A.Name = "lstBxLineItems2A";
            this.lstBxLineItems2A.Size = new System.Drawing.Size(375, 276);
            this.lstBxLineItems2A.TabIndex = 3;
            this.lstBxLineItems2A.SelectedIndexChanged += new System.EventHandler(this.lstBxLineItems2A_SelectedIndexChanged);
            // 
            // tb2B
            // 
            this.tb2B.Controls.Add(this.lblSave2B);
            this.tb2B.Controls.Add(this.btnSave2B);
            this.tb2B.Controls.Add(this.lstBxLineItems2B);
            this.tb2B.Controls.Add(this.cmbBxSections2B);
            this.tb2B.Location = new System.Drawing.Point(4, 25);
            this.tb2B.Name = "tb2B";
            this.tb2B.Padding = new System.Windows.Forms.Padding(3);
            this.tb2B.Size = new System.Drawing.Size(568, 361);
            this.tb2B.TabIndex = 1;
            this.tb2B.Text = "tb2B";
            this.tb2B.UseVisualStyleBackColor = true;
            // 
            // btnSave2B
            // 
            this.btnSave2B.Location = new System.Drawing.Point(7, 322);
            this.btnSave2B.Name = "btnSave2B";
            this.btnSave2B.Size = new System.Drawing.Size(85, 29);
            this.btnSave2B.TabIndex = 8;
            this.btnSave2B.Text = "Save";
            this.btnSave2B.UseVisualStyleBackColor = true;
            this.btnSave2B.Click += new System.EventHandler(this.btnSave2B_Click);
            // 
            // lstBxLineItems2B
            // 
            this.lstBxLineItems2B.FormattingEnabled = true;
            this.lstBxLineItems2B.Location = new System.Drawing.Point(7, 40);
            this.lstBxLineItems2B.Name = "lstBxLineItems2B";
            this.lstBxLineItems2B.Size = new System.Drawing.Size(375, 276);
            this.lstBxLineItems2B.TabIndex = 7;
            this.lstBxLineItems2B.SelectedIndexChanged += new System.EventHandler(this.lstBxLineItems2B_SelectedIndexChanged);

            // 
            // cmbBxSections2B
            // 
            this.cmbBxSections2B.FormattingEnabled = true;
            this.cmbBxSections2B.Location = new System.Drawing.Point(7, 10);
            this.cmbBxSections2B.Name = "cmbBxSections2B";
            this.cmbBxSections2B.Size = new System.Drawing.Size(555, 24);
            this.cmbBxSections2B.TabIndex = 6;
            this.cmbBxSections2B.SelectedIndexChanged += new System.EventHandler(this.cmbBxSections2B_SelectedIndexChanged);

            // 
            // lblSave2B
            // 
            this.lblSave2B.AutoSize = true;
            this.lblSave2B.Location = new System.Drawing.Point(110, 322);
            this.lblSave2B.Name = "lblSave2B";
            this.lblSave2B.Size = new System.Drawing.Size(0, 17);
            this.lblSave2B.TabIndex = 9;
            // 
            // frmViewOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
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
        private System.Windows.Forms.Label lblSave2A;
        private System.Windows.Forms.TabPage tb2B;
        private System.Windows.Forms.Button btnSave2B;
        private System.Windows.Forms.CheckedListBox lstBxLineItems2B;
        private System.Windows.Forms.ComboBox cmbBxSections2B;
        private System.Windows.Forms.Label lblSave2B;
    }
}