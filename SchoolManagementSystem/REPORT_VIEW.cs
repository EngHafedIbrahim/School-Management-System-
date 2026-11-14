using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UtilityLib;

namespace SchoolManagementSystem
{
    public partial class REPORT_VIEW : Form
    {
        public REPORT_VIEW()
        {
            InitializeComponent();
        }

        private void REPORT_VIEW_Load(object sender, EventArgs e)
        {
            string d = "HASH_001";

            // MessageBox.Show(d.GetHashCode().ToString());
            
           string hash = clsSecurity.ComputeHash("Hafed");
            int hashCode = hash.GetHashCode();
            //MessageBox.Show($"Hash code for '{hash}': {hashCode}");
        }
    }
}
