using System;
using System.Windows.Forms;
using NavyPqsWindows.Models;

namespace NavyPqsWindows
{
    public partial class frmViewOfficer : Form
    {
        private Officer officer;

        private int selectedSection = 0;

        public frmViewOfficer(Officer officer)
        {
            this.officer = officer;
            InitializeComponent();
            RefreshData();
            lstBxLineItems.CheckOnClick = true;

            foreach (var section in officer.TwoBravo.Sections)
            {
                tb2B.TabPages[0].Text = "2B";
                cmbBxSections.Items.Add(section.Number + " " + section.Name);
            }

            cmbBxSections.SelectedIndex = 0;
        }

        private void btnEditOfficer_Click(object sender, EventArgs e)
        {
            var form = new frmEditOfficer(officer);
            form.ShowDialog();
            form.Close();
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSave.Text = "";
            Section section = officer.TwoBravo.Sections[cmbBxSections.SelectedIndex];
            selectedSection = cmbBxSections.SelectedIndex;
            lstBxLineItems.Items.Clear();

            for (int i = 0; i < section.LineItem.Length; i++)
            {
                lstBxLineItems.Items.Add(section.LineItem[i], section.Signed[i]);
            }
        }

        private void lstBxLineItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSave.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           var x = lstBxLineItems.CheckedIndices;
           for(int i = 0; i < officer.TwoBravo.Sections[selectedSection].Signed.Length; i++)
           {
               if (x.Contains(i))
               {
                   officer.TwoBravo.Sections[selectedSection].Signed[i] = true;
               }
               else
               {
                   officer.TwoBravo.Sections[selectedSection].Signed[i] = false;

               }
           }

           lblSave.Text = "Save Successful!";
        }

        private void RefreshData()
        {
            lblName.Text = officer.Rank + " " + officer.FirstName + " " + officer.LastName;
        }
    }
}
