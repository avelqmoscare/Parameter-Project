using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParameterProject
{
    public partial class frmParameter : Form
    {
        public frmParameter()
        {
            InitializeComponent();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            object a = txtFirstValue.Text;
            object b = txtSecondValue.Text;

            if (rbnValueParameter.Checked == true)
            {
                ValueParameter(a, b);
            }
            else if (rbnRefParameter.Checked == true)
            {
                RefParameter(ref a, ref b);
            }
            else if (rbnOutParameter.Checked == true)
            {
                OutParameter(a, out b);
            }
            else
            {
                MessageBox.Show("Please select first a type of parameter.");
                return;
            }
            MessageBox.Show("First Value is now:" + a + Environment.NewLine + "Second Value is now:" + b);

        }
        private void ValueParameter(object a, object b)
        {
            object tempStorage;
            tempStorage = a;
            a = b;
            a = tempStorage;
        }
        private void RefParameter(ref object a,ref object b)
        {

            object tempStorage;
            tempStorage = a;
            a = b;
            a = tempStorage;
        }
        private void OutParameter(object a, out object b)
        {

            object tempStorage;
            tempStorage = a;
            b = a;
            a = tempStorage;
        }
    }

}
