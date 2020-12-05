
namespace NavyPqsWindows
{
    partial class FrmCwoApp
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lstOfficers = new System.Windows.Forms.ListView();
            this.btnNewOfficer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOfficers
            // 
            this.lstOfficers.HideSelection = false;
            this.lstOfficers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstOfficers.Location = new System.Drawing.Point(12, 100);
            this.lstOfficers.Name = "lstOfficers";
            this.lstOfficers.Size = new System.Drawing.Size(776, 338);
            this.lstOfficers.TabIndex = 0;
            this.lstOfficers.UseCompatibleStateImageBehavior = false;
            this.lstOfficers.View = System.Windows.Forms.View.Details;
            // 
            // btnNewOfficer
            // 
            this.btnNewOfficer.Location = new System.Drawing.Point(13, 13);
            this.btnNewOfficer.Name = "btnNewOfficer";
            this.btnNewOfficer.Size = new System.Drawing.Size(152, 33);
            this.btnNewOfficer.TabIndex = 1;
            this.btnNewOfficer.Text = "Create New Officer";
            this.btnNewOfficer.UseVisualStyleBackColor = true;
            this.btnNewOfficer.Click += new System.EventHandler(this.btnNewOfficer_Click);
            // 
            // FrmCwoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewOfficer);
            this.Controls.Add(this.lstOfficers);
            this.Name = "FrmCwoApp";
            this.Text = "CWO PQS App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOfficers;
        private System.Windows.Forms.Button btnNewOfficer;
    }
}

