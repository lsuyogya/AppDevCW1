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
        //Sort method for weekly report
        private static List<WeeklyReport> SortList(List<WeeklyReport> listParam, string sortType)
        {
            for (int i = 0; i < (listParam.Count - 1); i++) if (sortType == "Earning")
                {
                    Boolean swapFlag = false;
                    for (int j = 0; j < (listParam.Count - 1); j++)
                    {
                        if (listParam[j].earningTotal > listParam[j + 1].earningTotal)
                        {
                            var tempItem = listParam[j];
                            listParam[j] = listParam[j + 1];
                            listParam[j + 1] = tempItem;
                            swapFlag = true;
                        }
                    }
                    if (!swapFlag) { break; }
                }
            for (int i = 0; i < (listParam.Count - 1); i++) if (sortType == "Count")
                {
                    Boolean swapFlag = false;
                    for (int j = 0; j < (listParam.Count - 1); j++)
                    {
                        if (listParam[j].visitorCount > listParam[j + 1].visitorCount)
                        {
                            var tempItem = listParam[j];
                            listParam[j] = listParam[j + 1];
                            listParam[j + 1] = tempItem;
                            swapFlag = true;
                        }
                    }
                    if (!swapFlag) { break; }
                }
            return listParam;
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
        //Register button on register panel
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var path = "../../Properties/XMLs/Credentials.xml";
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
        //Menu button
        private void RegEmployeeBtn_Click(object sender, EventArgs e)
        {
            HideAdminPannels();
            RegisterEmployeePanel.Visible = true;
        }
        //Menu button
        private void ViewReportBtn_Click(object sender, EventArgs e)
        {
            HideAdminPannels();
            ViewReportPanel.Visible = true;

            ChartTypeCB.SelectedItem = "Column";
            ReportBasisCB.SelectedItem = "Earning";
        }
        //Menu button
        private void SetPricesBtn_Click(object sender, EventArgs e)
        {
            HideAdminPannels();
            SetPricesPanel.Visible = true;

            var path = "../../Properties/XMLs/Prices.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var prices = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> pricesList = (List<Prices>)prices;
            PricesDataGrid.DataSource = pricesList;


        }

        //Add button on SetPrices panel
        private void AddBtn_Click(object sender, EventArgs e)
        {
            var path = "../../Properties/XMLs/Prices.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var prices = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> pricesList = (List<Prices>)prices;

            Boolean categoryMissing = string.IsNullOrWhiteSpace(CategoryTF.Text) ? true : false;
            Boolean valueInvalid = double.TryParse(ValueTF.Text, out double value) ? false: true;
            Boolean typeMissing = (TypeCB.SelectedItem == null) ? true : false;
            Boolean categoryExists = false;

            if (categoryMissing || typeMissing)
                MessageBox.Show("Please fill out every text fields.");
            else if (valueInvalid)
                MessageBox.Show("Please fill out a valid value.");
            else if (TypeCB.SelectedItem.ToString() != "BasePrice" && TypeCB.SelectedItem.ToString() != "Duration")
            {
                foreach (var price in pricesList)
                {
                    categoryExists = (price.category == CategoryTF.Text) ? true : false;
                    if (categoryExists) break;
                }
                if (categoryExists)
                    MessageBox.Show("The categogy already exists! Add a new category.");
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
            }
            else if (TypeCB.SelectedItem.ToString() == "BasePrice")
                MessageBox.Show("Cannot add another base prcice! Try adding other types."); 
            else if (TypeCB.SelectedItem.ToString() == "Duration")
                MessageBox.Show("Cannot add another duration! Try adding other types.");
        }

        //Update btn on SetPrices panel
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var path = "../../Properties/XMLs/Prices.xml";
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
                    else if (categoryExists) break;
                }
                if (!categoryExists)
                    MessageBox.Show("The categogy doesn't exist! Enter a category that exists to update it.");

                 else if (!typeMatches) 
                    MessageBox.Show("Please select an appropriate type for the category.");
              
            }
        }

        //Daily Report btn on view report panel
        private void ViewDailyReportBtn_Click(object sender, EventArgs e)
        {
            var dailyRepPath = "../../Properties/XMLs/DailyReport.xml";
            FileStream filestream = new FileStream(dailyRepPath, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<DailyReport>));
            List<DailyReport> dailyReportList = (List<DailyReport>)xmlSerializer.Deserialize(filestream);
            filestream.Close();

            HashSet<string> xBindingCategory = new HashSet<string>();
            foreach (var item in dailyReportList)
                xBindingCategory.Add(item.visitorCategory);

            List<int> yBindingCount = new List<int>();
            foreach (var item in dailyReportList)
                yBindingCount.Add(item.visitorCount);

            ReportChart.Series[0].Points.DataBindXY(xBindingCategory, yBindingCount);
            if (ChartTypeCB.SelectedItem.ToString() == "Pie")
            {
                ReportDataGrid.Visible = false;
                ReportChart.Visible = true;
                ReportChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            else if (ChartTypeCB.SelectedItem.ToString() == "Column")
            {
                ReportDataGrid.Visible = false;
                ReportChart.Visible = true;
                ReportChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            else if (ChartTypeCB.SelectedItem.ToString() == "Grid")
            {
                ReportChart.Visible = false;
                ReportDataGrid.Visible = true;
                ReportDataGrid.DataSource = dailyReportList;
            }
        }

        //Weekly Report btn on view report panel
        private void ViewWeeklyReportBtn_Click(object sender, EventArgs e)
        {
            var weeklyRepPath = "../../Properties/XMLs/WeeklyReport.xml";
            FileStream filestream = new FileStream(weeklyRepPath, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<WeeklyReport>));
            List<WeeklyReport> weeklyReportList = (List<WeeklyReport>)xmlSerializer.Deserialize(filestream);
            filestream.Close();

            List<WeeklyReport> sortedWeeklyReportList = new List<WeeklyReport>();
            if (ReportBasisCB.SelectedItem.ToString() == "Earning")
                sortedWeeklyReportList = SortList(weeklyReportList, "Earning");
            if (ReportBasisCB.SelectedItem.ToString() == "Visitor count")
                sortedWeeklyReportList = SortList(weeklyReportList, "Count");

            List<string> xBindingDay = new List<string>();
            foreach (var item in sortedWeeklyReportList)
                xBindingDay.Add(item.day);

            List<int> yBindingCount = new List<int>();
            foreach (var item in sortedWeeklyReportList) 
                yBindingCount.Add(item.visitorCount);

            List<double> yBindingEarning = new List<double>();
            foreach (var item in sortedWeeklyReportList)
                yBindingEarning.Add(item.earningTotal);

            if (ReportBasisCB.SelectedItem.ToString() == "Visitor count")
                ReportChart.Series[0].Points.DataBindXY(xBindingDay, yBindingCount);
            else if (ReportBasisCB.SelectedItem.ToString() == "Earning")
                ReportChart.Series[0].Points.DataBindXY(xBindingDay, yBindingEarning);

            if (ChartTypeCB.SelectedItem.ToString() == "Pie")
            {
                ReportDataGrid.Visible = false;
                ReportChart.Visible = true;
                ReportChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            else if (ChartTypeCB.SelectedItem.ToString() == "Column")
            {
                ReportDataGrid.Visible = false;
                ReportChart.Visible = true;
                ReportChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            else if (ChartTypeCB.SelectedItem.ToString() == "Grid")
            {
                ReportChart.Visible = false;
                ReportDataGrid.Visible = true;
                ReportDataGrid.DataSource = sortedWeeklyReportList;
            }

            

        }

        //Menu Btn
        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}

