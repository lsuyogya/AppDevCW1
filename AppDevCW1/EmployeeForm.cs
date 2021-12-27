using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AppDevCW1
{
    public partial class EmployeeForm : Form
    {
        XmlSerializer xmlSerializer;
        public EmployeeForm()
        {

            InitializeComponent();
            this.FormClosing += AppCloseOnFormClose;
        }

        //Method to check which week number a date lies in.
        private static int GetWeekNumber(DateTime dateParam)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            int weekNum = culture.Calendar.GetWeekOfYear(dateParam, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
            return weekNum;
        }
        
        private static List<DailyReport> SortList(List<DailyReport> listParam)
        {
            //foreach (var outerLoopItem in listParam)
            //{
            //    foreach (var innerLoopItem in listParam)
            //    {
            //        if (innerLoopItem.visitorCount < outerLoopItem.visitorCount)
            //        {
            //            var tempItem = outerLoopItem;
            //            outerLoopItem = innerLoopItem;
            //            innerLoopItem = tempItem; 

            //        }
            //    }
            //}
            for (int i = 0; i < (listParam.Count - 1); i++)
            {
                Boolean swapFlag = false;
                for (int j = 0; j < (listParam.Count - 1); j++)
                {
                    if (listParam[j].visitorCount > listParam[j+1].visitorCount )
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
                if (frm.Name != "EmployeeForm") //Checking if a form other than EmployeeForm is open
                {
                    otherFormIsOpen = true;
                }
            }
            if (!otherFormIsOpen) Application.Exit(); //Closing the app if no forms are open
        }

        private void HideEmployeePanels()
        {
            CheckinPanel.Visible = false;
            CheckoutPanel.Visible = false;
            GenReportPanel.Visible = false;
            ViewReportPanel.Visible = false;
        }
        private void CustomerCheckinBtn_Click(object sender, EventArgs e)
        {
            HideEmployeePanels();
            CheckinPanel.Visible = true;

            var path = "../../Properties/XMLs/Prices.xml";
            var path2 = "../../Properties/XMLs/Tickets.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var prices = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            filestream = new FileStream(path2, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            var tickets = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> priceList = (List<Prices>)prices;
            List<Tickets> ticketList = (List<Tickets>)tickets;

            //Breaking down the list into suitable groups to feed in the combo boxes
            List<Prices> ticketTypeList = new List<Prices>();
            List<Prices> daysList = new List<Prices>();
            foreach (var price in priceList)
            {
                if (price.type == "TicketType")
                {
                    Prices newPrice = new Prices();
                    newPrice.category = price.category;
                    newPrice.type = price.type;
                    newPrice.value = price.value;
                    ticketTypeList.Add(newPrice);
                }
            }

            foreach (var price in priceList)
            {
                if (price.type == "Day")
                {
                    Prices newPrice = new Prices();
                    newPrice.category = price.category;
                    newPrice.type = price.type;
                    newPrice.value = price.value;
                    daysList.Add(newPrice);
                }
            }
            TicketTypeCB.DataSource = ticketTypeList;
            TicketTypeCB.DisplayMember = "category";
            TicketTypeCB.ValueMember = "category";

            DayCB.DataSource = daysList;
            DayCB.DisplayMember = "category";
            DayCB.ValueMember = "category";

            TicketInfoDataGrid.DataSource = ticketList;
        }
        private void CheckinBtn_Click(object sender, EventArgs e)
        {
            var type = TicketTypeCB.SelectedValue;
            var day = DayCB.SelectedValue;
            var countIsInt = int.TryParse(CountTF.Text.ToString(), out int count) ? true : false;
            if (type!=null && day != null && countIsInt)
            {
                var path = "../../Properties/XMLs/Tickets.xml";
                FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
                xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
                var ticketDetails = xmlSerializer.Deserialize(filestream);
                List<Tickets> ticketList = (List<Tickets>)ticketDetails;
                filestream.Close();

                var ticketCount = ticketList.Count;
                var lastTicketNo = (ticketCount == 0) ? 0 : ticketList[ticketCount - 1].ticketNo;

                filestream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                Tickets checkInDetails = new Tickets();
                checkInDetails.ticketNo = (lastTicketNo + 1);
                checkInDetails.type = type.ToString();
                checkInDetails.day = day.ToString();
                checkInDetails.count = count;
                checkInDetails.sysInDate = DateTime.Now;
                checkInDetails.sysOutDate = new DateTime();
                checkInDetails.hasPaid = false;
                checkInDetails.totalPrice = 0;
                ticketList.Add(checkInDetails);
                xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
                xmlSerializer.Serialize(filestream, ticketList);
                filestream.Close();
                MessageBox.Show("Customer checked in!");
                TicketInfoDataGrid.DataSource = ticketList;
            }else if (!countIsInt)
            {
                MessageBox.Show("Please enter a valid integer count.");
            }
        }

        private void CustomerCheckoutBtn_Click(object sender, EventArgs e)
        {
            HideEmployeePanels();
            CheckoutPanel.Visible = true;

            var path = "../../Properties/XMLs/Tickets.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            var ticketDetails = xmlSerializer.Deserialize(filestream);
            List<Tickets> ticketList = (List<Tickets>)ticketDetails;
            filestream.Close();
            TicketInfoDataGrid2.DataSource = ticketList;

        }

        private void CheckPriceBtn_Click(object sender, EventArgs e)
        {
            var path = "../../Properties/XMLs/Tickets.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            var ticketDetails = xmlSerializer.Deserialize(filestream);
            List<Tickets> ticketList = (List<Tickets>)ticketDetails;
            filestream.Close();
            Boolean ticketMatches = true;
            Boolean hasCheckedOut = false;
            double ticketPrice = 0;

            //Validations for text field
            Boolean invalidTicketNo = int.TryParse(TicketNoTF.Text, out int ticketNo) ? false : true;

            foreach (var ticket in ticketList)
            {
                if (!invalidTicketNo && ticket.ticketNo == ticketNo && !ticket.hasPaid)
                {
                    ticketMatches = true;
                    ticket.totalPrice = 1;
                    ticket.sysOutDate = DateTime.Now;
                    var timeDiff= Math.Ceiling((ticket.sysOutDate - ticket.sysInDate).TotalHours);
                    string duration = "";
                    switch (timeDiff)
                    {
                        case 1:
                            duration = "OneHr";
                            break;

                        case 2:
                            duration = "TwoHr";
                            break;

                        case 3:
                            duration = "ThreeHr";
                            break;

                        case 4:
                            duration = "FourHr";
                            break;

                        case double n when (n > 4):
                            duration = "WholeDay";
                            break;

                        default:
                            MessageBox.Show("Time calculation went wrong!!!");
                            break;
                    }

                    
                    var path1 = "../../Properties/XMLs/Prices.xml";
                    FileStream filestream1 = new FileStream(path1, FileMode.Open, FileAccess.Read);
                    xmlSerializer = new XmlSerializer(typeof(List<Prices>));
                    var priceDetails = xmlSerializer.Deserialize(filestream1);
                    List<Prices> priceList = (List<Prices>)priceDetails;
                    filestream.Close();
                    

                    foreach (var price in priceList)
                        if (price.category == ticket.type || price.category == duration || price.category == ticket.day || price.category == "BasePrice")
                        {
                            ticket.totalPrice= price.value * ticket.totalPrice;
                        }
                    MessageBox.Show("The total price is" + ticket.totalPrice +"\n Please press Checkout Button to confirm payment.");
                    break;

                }
                else if (!invalidTicketNo && ticket.ticketNo == ticketNo && ticket.hasPaid)
                {
                    hasCheckedOut = true;
                    ticketPrice = ticket.totalPrice;
                }
                else if (!invalidTicketNo && ticket.ticketNo != ticketNo)
                {
                    ticketMatches = false;
                }
            }

            if (hasCheckedOut) MessageBox.Show("Selected ticket has already been checked out. \nPrice: " + ticketPrice);
            else if (!ticketMatches) MessageBox.Show("Entered ticket no does not exist! \nTry another ticket number.");
            else if (invalidTicketNo) MessageBox.Show("Please enter a valid ticket number.");


            filestream = new FileStream(path, FileMode.Truncate, FileAccess.Write);
            Tickets checkInDetails = new Tickets();
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            xmlSerializer.Serialize(filestream, ticketList);
            filestream.Close();
            TicketInfoDataGrid2.DataSource = ticketList;
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            var path = "../../Properties/XMLs/Tickets.xml";
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            var ticketDetails = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Tickets> ticketList = (List<Tickets>)ticketDetails;
            Boolean isValidInteger = int.TryParse(TicketNoTF.Text.ToString(), out int ticketNo) ? true : false;
            Boolean successFlag = false;
            Boolean priceEmptyFlag = true;

            foreach (var ticket in ticketList) if ( isValidInteger && ticket.ticketNo == ticketNo && !ticket.hasPaid && ticket.totalPrice!=0)
                {
                    ticket.hasPaid = true;
                    successFlag = true;
                    priceEmptyFlag = false;
                    break;
                }
            if (!isValidInteger)
                MessageBox.Show("Please enter a valid integer.");
            else if (successFlag) 
                MessageBox.Show("Customer Checkout successful!");
            else if (priceEmptyFlag)
                MessageBox.Show("Please check the price first.");
            else
                MessageBox.Show("Customer already checkedout.");

            filestream = new FileStream(path, FileMode.Truncate, FileAccess.Write);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            xmlSerializer.Serialize(filestream, ticketList);
            filestream.Close();

            TicketInfoDataGrid2.DataSource = ticketList;

        }

        private void GenReportBtn_Click(object sender, EventArgs e)
        {
            HideEmployeePanels();
            GenReportPanel.Visible = true;
        }
        private void GenDailyReportBtn_Click(object sender, EventArgs e)
        {
            var pricePath = "../../Properties/XMLs/Prices.xml";
            var ticketPath = "../../Properties/XMLs/Tickets.xml";
            var dailyReportPath = "../../Properties/XMLs/DailyReport.xml";

            FileStream filestream = new FileStream(pricePath, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var priceDetails = xmlSerializer.Deserialize(filestream);
            List<Prices> priceList = (List<Prices>)priceDetails;
            filestream.Close();

            filestream = new FileStream(ticketPath, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            var ticketDetails = xmlSerializer.Deserialize(filestream);
            List<Tickets> ticketList = (List<Tickets>)ticketDetails;
            filestream.Close();

            List<DailyReport> dailyReportList = new List<DailyReport>();

            var groupTicketsCategory = ticketList.GroupBy(x => x.type);
            foreach (var group in groupTicketsCategory) 
            {
                DailyReport dailyReportDetail = new DailyReport();
                foreach(var ticket in group) 
                {
                    dailyReportDetail.visitorCategory = ticket.type;
                    if (ticket.hasPaid && ticket.sysOutDate.ToString("d") == DateTime.Now.ToString("d"))
                        dailyReportDetail.visitorCount += ticket.count;
                }
                dailyReportList.Add(dailyReportDetail);
            }

            var sortedDailyReportList = SortList(dailyReportList); 

            filestream = new FileStream(dailyReportPath, FileMode.Truncate, FileAccess.Write);
            xmlSerializer = new XmlSerializer(typeof(List<DailyReport>));
            xmlSerializer.Serialize(filestream, sortedDailyReportList);
            filestream.Close();
            MessageBox.Show("Daily report generated! \nPress View Report button to view the report");
        }

        private void GenWeeklyReportBtn_Click(object sender, EventArgs e)
        {
            var pricePath = "../../Properties/XMLs/Prices.xml";
            var ticketPath = "../../Properties/XMLs/Tickets.xml";
            var weeklyReportPath = "../../Properties/XMLs/WeeklyReport.xml";

            FileStream filestream = new FileStream(pricePath, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Prices>));
            var priceDetails = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Prices> priceList = (List<Prices>)priceDetails;

            filestream = new FileStream(ticketPath, FileMode.Open, FileAccess.Read);
            xmlSerializer = new XmlSerializer(typeof(List<Tickets>));
            var ticketDetails = xmlSerializer.Deserialize(filestream);
            filestream.Close();
            List<Tickets> ticketList = (List<Tickets>)ticketDetails;

            List<WeeklyReport> weeklyReportList = new List<WeeklyReport>();

            var groupTicketsCategory = ticketList.GroupBy(Tickets => Tickets.sysOutDate.ToString("dddd"));
            foreach (var group in groupTicketsCategory)
            {
                WeeklyReport weeklyReportDetail = new WeeklyReport();
                Boolean addFlag = false;
                foreach (var ticket in group) 
                {
                    //Check if the ticket has been checkedout and check if the ticket lies in the current week
                    if (ticket.hasPaid && (GetWeekNumber(ticket.sysOutDate) == GetWeekNumber(DateTime.Now))) 
                    {
                        weeklyReportDetail.day = ticket.sysOutDate.ToString("dddd");
                        weeklyReportDetail.visitorCount += ticket.count;
                        weeklyReportDetail.earningTotal += ticket.totalPrice;
                        addFlag = true;
                    }
                }
                if (addFlag) weeklyReportList.Add(weeklyReportDetail);
            }

            var sortedWeeklyReportList = SortList(weeklyReportList, "Earning");

            filestream = new FileStream(weeklyReportPath, FileMode.Truncate, FileAccess.Write);
            xmlSerializer = new XmlSerializer(typeof(List<WeeklyReport>));
            xmlSerializer.Serialize(filestream, sortedWeeklyReportList);
            filestream.Close();
            MessageBox.Show("Weekly report generated! \nPress View Report button to view the report");
        }

        private void ViewReportBtn_Click(object sender, EventArgs e)
        {
            HideEmployeePanels();
            ViewReportPanel.Visible = true;

            ChartTypeCB.SelectedItem = "Column";
            ReportBasisCB.SelectedItem = "Earning";
        }

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
    }
}
