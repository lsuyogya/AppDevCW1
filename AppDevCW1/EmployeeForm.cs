using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevCW1
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            this.FormClosing += AppCloseOnFormClose;
        }
        private void AppCloseOnFormClose(object sender, FormClosingEventArgs e)
        {

            FormCollection fc = Application.OpenForms; //Imported All open forms
            Boolean otherFormIsOpen = false;

            foreach (Form frm in fc)
            {
                if (frm.Name != "EmployeeForm") //Checking if a form other than EmployeeForm is open
                {
                    otherFormIsOpen = true;
                }
            }
            if (!otherFormIsOpen) Application.Exit(); //Closing the app if no forms are open
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
