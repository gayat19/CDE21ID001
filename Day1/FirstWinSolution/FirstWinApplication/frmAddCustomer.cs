using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FirstWinApplication
{
    public partial class frmAddCustomer : Form
    {
        string strData = "";
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtFName.Text);
            
            if (rdbMale.Checked == true)
                strData += "Mr." + " ";
            else
                strData += "Miss." + " ";
            strData += txtFName.Text + " ";
            strData += txtLName.Text + " ";
            strData += "nad you are from "+cmbCity.Text + " ";
            timProgress.Enabled = true;
            
       
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void timProgress_Tick(object sender, EventArgs e)
        {
            if (pbShowData.Value < 100)
                pbShowData.PerformStep();
           else
                lblDisplay.Text = strData;
        }
    }
}
