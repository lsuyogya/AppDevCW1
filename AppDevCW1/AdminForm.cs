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
    public partial class AdminForm : Form
    {
        XmlSerializer xmlSerializer;
        public AdminForm()
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
                if (frm.Name != "AdminForm") //Checking if a form other than LoginForm is open
                {
                    otherFormIsOpen = true;
                }
            }
            if (!otherFormIsOpen) Application.Exit(); //Closing the app if no forms are open
        }

        private void HideAdminPannels()
        {
            RegisterEmployeePanel.Visible = false;
            SetPricesPanel.Visible = false;
            ViewReportPanel.Visible = false;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var path = "XMLs/Credentials.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<LoginCredentials>));
            var cred = xmlSerializer.Deserialize(filestream);
            List<LoginCredentials> credentialList = (List<LoginCredentials>)cred;
            filestream.Close();
            Boolean userExists = false;
            Boolean hasEmptyCreds = false;
            Boolean PassMatch = true;

            if (string.IsNullOrWhiteSpace(UNameTF.Text) || string.IsNullOrWhiteSpace(PWordTF.Text) || string.IsNullOrWhiteSpace(ConfirmPWordTF.Text))
            {
                hasEmptyCreds = true;
                MessageBox.Show("Please enter Username, Password and Confirm Passwrord.");
            } else if (PWordTF.Text != ConfirmPWordTF.Text)
            {
                PassMatch = false;
                MessageBox.Show("The password and ConfirmPassword Do not match. Try again.");
            }
            foreach (var item in credentialList) if (!hasEmptyCreds && PassMatch) //Doesnt run loop if text fields are empty, or if password confirmation doesnt match
                {
                    if (item.UName == UNameTF.Text)
                    {
                        userExists = true;
                        MessageBox.Show("The employee has already been registered!");
                        break;
                    }
                }
            if (!userExists && !hasEmptyCreds && PassMatch)
            {

                filestream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                LoginCredentials credential = new LoginCredentials();
                credential.UName = UNameTF.Text;
                credential.PWord = PWordTF.Text;
                credential.AccType = "Employee";
                credentialList.Add(credential);
                xmlSerializer = new XmlSerializer(typeof(List<LoginCredentials>));
                xmlSerializer.Serialize(filestream, credentialList);
                filestream.Close();
                MessageBox.Show("Employee registered successfully!");
            }

        }

        private void RegEmployeeBtn_Click(object sender, EventArgs e)
        {
            HideAdminPannels();
            RegisterEmployeePanel.Visible = true;
        }

        private void ViewReportBtn_Click(object sender, EventArgs e)
        {
            HideAdminPannels();
            ViewReportPanel.Visible = true;
        }

        private void SetPricesBtn_Click(object sender, EventArgs e)
        {
            HideAdminPannels();
            SetPricesPanel.Visible = true;

            var path = "XMLs/Prices.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var prices = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> pricesList = (List<Prices>)prices;
            PricesDataGrid.DataSource = pricesList;


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var path = "XMLs/Prices.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var prices = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> pricesList = (List<Prices>)prices;

            Boolean categoryMissing = string.IsNullOrWhiteSpace(CategoryTF.Text) ? true : false;
            Boolean valueMissing = string.IsNullOrWhiteSpace(ValueTF.Text) ? true : false;
            Boolean typeMissing = (TypeCB.SelectedItem == null) ? true : false;
            Boolean categoryExists = false;
            if (categoryMissing || valueMissing || typeMissing)
            {
                MessageBox.Show("Please fill out every text fields.");
            }
            if (!categoryMissing && !valueMissing && !typeMissing && TypeCB.SelectedItem.ToString() != "BasePrice")
            {
                foreach (var price in pricesList)
                {
                    categoryExists = (price.category == CategoryTF.Text) ? true : false;
                    if (categoryExists) break;
                }
                if (categoryExists)
                {
                    MessageBox.Show("The categogy already exists! Add a new category.");
                }
                else 
                {
                    Prices price = new Prices();
                    price.category = CategoryTF.Text;
                    price.value = double.Parse(ValueTF.Text);
                    price.type = TypeCB.SelectedItem.ToString();
                    pricesList.Add(price);
                    filestream = new FileStream(path, FileMode.Truncate, FileAccess.Write);
                    xmlSerializer.Serialize(filestream, pricesList);
                    filestream.Close();
                    MessageBox.Show("The categogy has been successfully added.");
                    PricesDataGrid.DataSource = pricesList;
                }
            }else if (!typeMissing && TypeCB.SelectedItem.ToString() == "BasePrice")
            {
                MessageBox.Show("Cannot add another Base prcice! Try adding other types.");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var path = "XMLs/Prices.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var prices = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> pricesList = (List<Prices>)prices;

            Boolean categoryMissing = string.IsNullOrWhiteSpace(CategoryTF.Text) ? true : false;
            Boolean valueMissing = string.IsNullOrWhiteSpace(ValueTF.Text) ? true : false;
            Boolean typeMissing = (TypeCB.SelectedItem == null) ? true : false;
            Boolean categoryExists = false;
            Boolean typeMatches = false;
            if (categoryMissing || valueMissing || typeMissing)
            {
                MessageBox.Show("Please fill out every text fields.");
            }
            if (!categoryMissing && !valueMissing && !typeMissing)
            {
                foreach (var price in pricesList)
                {
                    categoryExists = (price.category == CategoryTF.Text ) ? true: false;
                    typeMatches = (price.type == TypeCB.Text.ToString()) ? true: false;
                    if (categoryExists && typeMatches)
                    {
                        price.value = double.Parse(ValueTF.Text);
                        filestream = new FileStream(path, FileMode.Truncate, FileAccess.Write);
                        xmlSerializer.Serialize(filestream, pricesList);
                        filestream.Close();
                        MessageBox.Show("The categogy has been successfully updated.");
                        PricesDataGrid.DataSource = pricesList;
                        break;
                    }    
                }
                if (!categoryExists)
                {
                    MessageBox.Show("The categogy doesn't exist! Enter a category that exists to update it.");
                }
            }
        }
    }
}
