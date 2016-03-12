using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleATLComLib;

namespace SimpleATLcomTest1
{
    public partial class Form1 : Form
    {
        private SimpleCom objSimpleObj;
        private int _totalMarks = 0;

        public Form1()
        {
            InitializeComponent();
            objSimpleObj = new SimpleCom();
            objSimpleObj.TotalMarks += objSimpleObj_TotalMarks;
        }

        void objSimpleObj_TotalMarks(int a_lTotalMarks)
        {
            string txtMsg = string.Format(" {0} got  {1} Marks", txtName.Text, _totalMarks);
            MessageBox.Show(txtMsg);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objSimpleObj.AtlMarks = int.Parse(txtATLMarks.Text);
            objSimpleObj.ComMarks = int.Parse(txtComMarks.Text);

            bool fireEvent = chkFireEvent.Checked;
            _totalMarks = objSimpleObj.Calculate(fireEvent);

            txtResultName.Text = txtName.Text;
            txtMarks.Text = _totalMarks.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInvokeDLG_Click(object sender, EventArgs e)
        {
            SimpleATLComLib.SimpleATLDLGController simpleCTRLDLG = new SimpleATLDLGController();
            simpleCTRLDLG.InvokeDialog3();
        }
    }
}
