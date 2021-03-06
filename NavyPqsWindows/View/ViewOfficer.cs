﻿using System;
using System.Windows.Forms;
using NavyPqsWindows.Models;
using NavyPqsWindows.Services;

namespace NavyPqsWindows
{
    public partial class frmViewOfficer : Form
    {
        private Officer officer;

        private int selectedSection2A = 0;

        private int selectedSection2B = 0;

        public frmViewOfficer(Officer officer)
        {
            this.officer = officer;
            InitializeComponent();
            RefreshData();
            lstBxLineItems2A.CheckOnClick = true;
            lstBxLineItems2B.CheckOnClick = true;

            foreach (var section in officer.TwoAlpha.Sections)
            {
                tbCntrl.TabPages[0].Text = "2A";
                cmbBxSections2A.Items.Add(section.Number + " " + section.Name);
            }

            foreach (var section in officer.TwoBravo.Sections)
            {
                tbCntrl.TabPages[1].Text = "2B";
                cmbBxSections2B.Items.Add(section.Number + " " + section.Name);
            }

            cmbBxSections2A.SelectedIndex = 0;
            cmbBxSections2B.SelectedIndex = 0;
        }

        private void btnEditOfficer_Click(object sender, EventArgs e)
        {
            var form = new frmEditOfficer(officer);
            form.ShowDialog();
            form.Close();
            RefreshData();
        }

        private void cmbBxSections2A_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl2aMessage.Text = "";
            Section section = officer.TwoAlpha.Sections[cmbBxSections2A.SelectedIndex];
            selectedSection2A = cmbBxSections2A.SelectedIndex;
            lstBxLineItems2A.Items.Clear();

            for (int i = 0; i < section.LineItem.Length; i++)
            {
                lstBxLineItems2A.Items.Add(section.LineItem[i], section.Signed[i]);
            }
        }

        private void cmbBxSections2B_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSave2B.Text = "";
            Section section = officer.TwoBravo.Sections[cmbBxSections2B.SelectedIndex];
            selectedSection2B = cmbBxSections2B.SelectedIndex;
            lstBxLineItems2B.Items.Clear();

            for (int i = 0; i < section.LineItem.Length; i++)
            {
                lstBxLineItems2B.Items.Add(section.LineItem[i], section.Signed[i]);
            }
        }

        private void lstBxLineItems2A_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl2aMessage.Text = "";
        }

        private void lstBxLineItems2B_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSave2B.Text = "";
        }

        private void btnSave2A_Click(object sender, EventArgs e)
        {
            Save2A();

           lbl2aMessage.Text = "Save Successful!";
        }

        private void Save2A()
        {
            var x = lstBxLineItems2A.CheckedIndices;
            for (int i = 0; i < officer.TwoAlpha.Sections[selectedSection2A].Signed.Length; i++)
            {
                if (x.Contains(i))
                {
                    officer.TwoAlpha.Sections[selectedSection2A].Signed[i] = true;
                }
                else
                {
                    officer.TwoAlpha.Sections[selectedSection2A].Signed[i] = false;

                }
            }
        }

        private void btnSave2B_Click(object sender, EventArgs e)
        {
            var x = lstBxLineItems2B.CheckedIndices;
            for (int i = 0; i < officer.TwoBravo.Sections[selectedSection2B].Signed.Length; i++)
            {
                if (x.Contains(i))
                {
                    officer.TwoBravo.Sections[selectedSection2B].Signed[i] = true;
                }
                else
                {
                    officer.TwoBravo.Sections[selectedSection2B].Signed[i] = false;

                }
            }

            lblSave2B.Text = "Save Successful!";
        }

        private void RefreshData()
        {
            lblName.Text = officer.Rank + " " + officer.FirstName + " " + officer.LastName;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Save2A();
            var report =  ConvertPqs.Convert(officer.TwoAlpha, officer.TwoBravo, new CwoPqs2Ato2B());
            // TODO: Fix this
            RefreshData();

            lbl2aMessage.Text = "Conversion Successful! Please close officer.";
            // Hack

            string folderName = FileHelper.GetDirectory();
            PdfWriter.Write(report.ToString(), System.IO.Path.Combine(folderName, officer.LastName + "Conversion.pdf"));
            Close();
        }

        private void btn2aSelectAll_Click(object sender, EventArgs e)
        {
            Section section = officer.TwoAlpha.Sections[cmbBxSections2A.SelectedIndex];
            lstBxLineItems2A.Items.Clear();

            for (int i = 0; i < section.LineItem.Length; i++)
            {
                lstBxLineItems2A.Items.Add(section.LineItem[i], true);
            }
        }

        private void btn2BSelectAll_Click(object sender, EventArgs e)
        {
            Section section = officer.TwoBravo.Sections[cmbBxSections2B.SelectedIndex];
            lstBxLineItems2B.Items.Clear();

            for (int i = 0; i < section.LineItem.Length; i++)
            {
                lstBxLineItems2B.Items.Add(section.LineItem[i], true);
            }
        }
    }
}
