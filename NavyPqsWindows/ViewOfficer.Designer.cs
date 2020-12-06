
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
            this.cmbBxSections = new System.Windows.Forms.ComboBox();
            this.btnEditOfficer = new System.Windows.Forms.Button();
            this.tb2B = new System.Windows.Forms.TabControl();
            this.tbPgPqs = new System.Windows.Forms.TabPage();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstBxLineItems = new System.Windows.Forms.CheckedListBox();
            this.tb2B.SuspendLayout();
            this.tbPgPqs.SuspendLayout();
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
            // cmbBxSections
            // 
            this.cmbBxSections.FormattingEnabled = true;
            this.cmbBxSections.Location = new System.Drawing.Point(6, 6);
            this.cmbBxSections.Name = "cmbBxSections";
            this.cmbBxSections.Size = new System.Drawing.Size(555, 24);
            this.cmbBxSections.TabIndex = 2;
            this.cmbBxSections.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // tb2B
            // 
            this.tb2B.Controls.Add(this.tbPgPqs);
            this.tb2B.Location = new System.Drawing.Point(12, 48);
            this.tb2B.Name = "tb2B";
            this.tb2B.SelectedIndex = 0;
            this.tb2B.Size = new System.Drawing.Size(576, 390);
            this.tb2B.TabIndex = 4;
            // 
            // tbPgPqs
            // 
            this.tbPgPqs.Controls.Add(this.lblSave);
            this.tbPgPqs.Controls.Add(this.btnSave);
            this.tbPgPqs.Controls.Add(this.lstBxLineItems);
            this.tbPgPqs.Controls.Add(this.cmbBxSections);
            this.tbPgPqs.Location = new System.Drawing.Point(4, 25);
            this.tbPgPqs.Name = "tbPgPqs";
            this.tbPgPqs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPqs.Size = new System.Drawing.Size(568, 361);
            this.tbPgPqs.TabIndex = 0;
            this.tbPgPqs.Text = "tabPage1";
            this.tbPgPqs.UseVisualStyleBackColor = true;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(112, 324);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(0, 17);
            this.lblSave.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstBxLineItems
            // 
            this.lstBxLineItems.FormattingEnabled = true;
            this.lstBxLineItems.Location = new System.Drawing.Point(6, 36);
            this.lstBxLineItems.Name = "lstBxLineItems";
            this.lstBxLineItems.Size = new System.Drawing.Size(375, 276);
            this.lstBxLineItems.TabIndex = 3;
            this.lstBxLineItems.SelectedIndexChanged += new System.EventHandler(lstBxLineItems_SelectedIndexChanged);
            // 
            // frmViewOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.tb2B);
            this.Controls.Add(this.btnEditOfficer);
            this.Controls.Add(this.lblName);
            this.Name = "frmViewOfficer";
            this.Text = "Officer Details";
            this.tb2B.ResumeLayout(false);
            this.tbPgPqs.ResumeLayout(false);
            this.tbPgPqs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBxSections;
        private System.Windows.Forms.Button btnEditOfficer;
        private System.Windows.Forms.TabControl tb2B;
        private System.Windows.Forms.TabPage tbPgPqs;
        private System.Windows.Forms.CheckedListBox lstBxLineItems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
    }
}