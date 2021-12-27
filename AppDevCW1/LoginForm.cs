using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AppDevCW1
{
    public partial class LoginForm : Form
    {
        XmlSerializer xmlSerializer;
        List<LoginCredentials> credList;
        public LoginForm()
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
                if (frm.Name != "LoginForm") //Checking if a form other than LoginForm is open
                {
                    otherFormIsOpen = true;
                }
            }
            if (!otherFormIsOpen) Application.Exit(); //Closing the app if no forms are open
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var path = "../../Properties/XMLs/Credentials.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<LoginCredentials>));
            var cred = xmlSerializer.Deserialize(filestream);
            credList = (List<LoginCredentials>)cred;
            filestream.Close();
            Boolean credMatched = false;
            foreach (var item in credList)
            {
                if (item.UName == UNameTF.Text && item.PWord == PWordTF.Text)
                {
                    credMatched = true;

                    if (item.AccType == "Admin")
                    {
                        AdminForm admin = new AdminForm();
                        admin.Show();
                        this.Close();
                        break;
                    }
                    else /*if (item.AccType == "Employee")*/
                    {
                        EmployeeForm employee = new EmployeeForm();
                        employee.Show();
                        this.Close();
                        break;
                    }

                }
            }
            if (!credMatched)
            {
                MessageBox.Show("Invalid Credentials! Try again");
            }
        }
    }
}
