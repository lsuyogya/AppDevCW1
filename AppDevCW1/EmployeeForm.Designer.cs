
namespace AppDevCW1
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EmployeeNavPannel = new System.Windows.Forms.Panel();
            this.CustomerCheckinBtn = new System.Windows.Forms.Button();
            this.CustomerCheckoutBtn = new System.Windows.Forms.Button();
            this.GenReportBtn = new System.Windows.Forms.Button();
            this.ViewReportBtn = new System.Windows.Forms.Button();
            this.CheckinPanel = new System.Windows.Forms.Panel();
            this.TicketInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.CheckinBtn = new System.Windows.Forms.Button();
            this.DayLbl = new System.Windows.Forms.Label();
            this.DayCB = new System.Windows.Forms.ComboBox();
            this.TicketTypeCB = new System.Windows.Forms.ComboBox();
            this.TicketType = new System.Windows.Forms.Label();
            this.CheckinLbl = new System.Windows.Forms.Label();
            this.CheckoutPanel = new System.Windows.Forms.Panel();
            this.TicketInfoDataGrid2 = new System.Windows.Forms.DataGridView();
            this.CheckoutLbl = new System.Windows.Forms.Label();
            this.TicketNo = new System.Windows.Forms.Label();
            this.TicketNoTF = new System.Windows.Forms.TextBox();
            this.CheckPriceBtn = new System.Windows.Forms.Button();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.GenReportPanel = new System.Windows.Forms.Panel();
            this.GenReportLbl = new System.Windows.Forms.Label();
            this.GenDailyReportBtn = new System.Windows.Forms.Button();
            this.GenWeeklyReportBtn = new System.Windows.Forms.Button();
            this.ViewReportPanel = new System.Windows.Forms.Panel();
            this.ReportBasisLbl = new System.Windows.Forms.Label();
            this.ReportBasisCB = new System.Windows.Forms.ComboBox();
            this.ReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ViewReportLbl = new System.Windows.Forms.Label();
            this.ViewDailyReportBtn = new System.Windows.Forms.Button();
            this.ViewWeeklyReportBtn = new System.Windows.Forms.Button();
            this.ChartTypeCB = new System.Windows.Forms.ComboBox();
            this.ChartTypeLbl = new System.Windows.Forms.Label();
            this.dailyReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeNavPannel.SuspendLayout();
            this.CheckinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoDataGrid)).BeginInit();
            this.CheckoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoDataGrid2)).BeginInit();
            this.GenReportPanel.SuspendLayout();
            this.ViewReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNavPannel
            // 
            this.EmployeeNavPannel.BackColor = System.Drawing.SystemColors.Highlight;
            this.EmployeeNavPannel.Controls.Add(this.CustomerCheckinBtn);
            this.EmployeeNavPannel.Controls.Add(this.CustomerCheckoutBtn);
            this.EmployeeNavPannel.Controls.Add(this.GenReportBtn);
            this.EmployeeNavPannel.Controls.Add(this.ViewReportBtn);
            this.EmployeeNavPannel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeNavPannel.Name = "EmployeeNavPannel";
            this.EmployeeNavPannel.Size = new System.Drawing.Size(801, 67);
            this.EmployeeNavPannel.TabIndex = 0;
            // 
            // CustomerCheckinBtn
            // 
            this.CustomerCheckinBtn.Location = new System.Drawing.Point(28, 22);
            this.CustomerCheckinBtn.Name = "CustomerCheckinBtn";
            this.CustomerCheckinBtn.Size = new System.Drawing.Size(111, 23);
            this.CustomerCheckinBtn.TabIndex = 0;
            this.CustomerCheckinBtn.Text = "Customer Checkin";
            this.CustomerCheckinBtn.UseVisualStyleBackColor = true;
            this.CustomerCheckinBtn.Click += new System.EventHandler(this.CustomerCheckinBtn_Click);
            // 
            // CustomerCheckoutBtn
            // 
            this.CustomerCheckoutBtn.Location = new System.Drawing.Point(247, 22);
            this.CustomerCheckoutBtn.Name = "CustomerCheckoutBtn";
            this.CustomerCheckoutBtn.Size = new System.Drawing.Size(111, 23);
            this.CustomerCheckoutBtn.TabIndex = 0;
            this.CustomerCheckoutBtn.Text = "Customer Checkout";
            this.CustomerCheckoutBtn.UseVisualStyleBackColor = true;
            this.CustomerCheckoutBtn.Click += new System.EventHandler(this.CustomerCheckoutBtn_Click);
            // 
            // GenReportBtn
            // 
            this.GenReportBtn.Location = new System.Drawing.Point(452, 22);
            this.GenReportBtn.Name = "GenReportBtn";
            this.GenReportBtn.Size = new System.Drawing.Size(111, 23);
            this.GenReportBtn.TabIndex = 0;
            this.GenReportBtn.Text = "Generate Report";
            this.GenReportBtn.UseVisualStyleBackColor = true;
            this.GenReportBtn.Click += new System.EventHandler(this.GenReportBtn_Click);
            // 
            // ViewReportBtn
            // 
            this.ViewReportBtn.Location = new System.Drawing.Point(659, 22);
            this.ViewReportBtn.Name = "ViewReportBtn";
            this.ViewReportBtn.Size = new System.Drawing.Size(111, 23);
            this.ViewReportBtn.TabIndex = 0;
            this.ViewReportBtn.Text = "View Report";
            this.ViewReportBtn.UseVisualStyleBackColor = true;
            this.ViewReportBtn.Click += new System.EventHandler(this.ViewReportBtn_Click);
            // 
            // CheckinPanel
            // 
            this.CheckinPanel.Controls.Add(this.TicketInfoDataGrid);
            this.CheckinPanel.Controls.Add(this.CheckinBtn);
            this.CheckinPanel.Controls.Add(this.DayLbl);
            this.CheckinPanel.Controls.Add(this.DayCB);
            this.CheckinPanel.Controls.Add(this.TicketTypeCB);
            this.CheckinPanel.Controls.Add(this.TicketType);
            this.CheckinPanel.Controls.Add(this.CheckinLbl);
            this.CheckinPanel.Location = new System.Drawing.Point(12, 83);
            this.CheckinPanel.Name = "CheckinPanel";
            this.CheckinPanel.Size = new System.Drawing.Size(776, 355);
            this.CheckinPanel.TabIndex = 1;
            this.CheckinPanel.Visible = false;
            // 
            // TicketInfoDataGrid
            // 
            this.TicketInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketInfoDataGrid.Location = new System.Drawing.Point(9, 170);
            this.TicketInfoDataGrid.Name = "TicketInfoDataGrid";
            this.TicketInfoDataGrid.Size = new System.Drawing.Size(755, 182);
            this.TicketInfoDataGrid.TabIndex = 6;
            // 
            // CheckinBtn
            // 
            this.CheckinBtn.Location = new System.Drawing.Point(348, 128);
            this.CheckinBtn.Name = "CheckinBtn";
            this.CheckinBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckinBtn.TabIndex = 5;
            this.CheckinBtn.Text = "Checkin";
            this.CheckinBtn.UseVisualStyleBackColor = true;
            this.CheckinBtn.Click += new System.EventHandler(this.CheckinBtn_Click);
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.Location = new System.Drawing.Point(271, 90);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(26, 13);
            this.DayLbl.TabIndex = 4;
            this.DayLbl.Text = "Day";
            // 
            // DayCB
            // 
            this.DayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayCB.FormattingEnabled = true;
            this.DayCB.Location = new System.Drawing.Point(303, 87);
            this.DayCB.Name = "DayCB";
            this.DayCB.Size = new System.Drawing.Size(173, 21);
            this.DayCB.TabIndex = 3;
            // 
            // TicketTypeCB
            // 
            this.TicketTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketTypeCB.FormattingEnabled = true;
            this.TicketTypeCB.Location = new System.Drawing.Point(303, 56);
            this.TicketTypeCB.Name = "TicketTypeCB";
            this.TicketTypeCB.Size = new System.Drawing.Size(173, 21);
            this.TicketTypeCB.TabIndex = 3;
            // 
            // TicketType
            // 
            this.TicketType.AutoSize = true;
            this.TicketType.Location = new System.Drawing.Point(233, 59);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(64, 13);
            this.TicketType.TabIndex = 2;
            this.TicketType.Text = "Ticket Type";
            // 
            // CheckinLbl
            // 
            this.CheckinLbl.AutoSize = true;
            this.CheckinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckinLbl.Location = new System.Drawing.Point(319, 6);
            this.CheckinLbl.Name = "CheckinLbl";
            this.CheckinLbl.Size = new System.Drawing.Size(120, 31);
            this.CheckinLbl.TabIndex = 1;
            this.CheckinLbl.Text = "Checkin";
            // 
            // CheckoutPanel
            // 
            this.CheckoutPanel.Controls.Add(this.TicketInfoDataGrid2);
            this.CheckoutPanel.Controls.Add(this.CheckoutLbl);
            this.CheckoutPanel.Controls.Add(this.TicketNo);
            this.CheckoutPanel.Controls.Add(this.TicketNoTF);
            this.CheckoutPanel.Controls.Add(this.CheckPriceBtn);
            this.CheckoutPanel.Controls.Add(this.CheckoutBtn);
            this.CheckoutPanel.Location = new System.Drawing.Point(12, 83);
            this.CheckoutPanel.Name = "CheckoutPanel";
            this.CheckoutPanel.Size = new System.Drawing.Size(776, 352);
            this.CheckoutPanel.TabIndex = 2;
            this.CheckoutPanel.Visible = false;
            // 
            // TicketInfoDataGrid2
            // 
            this.TicketInfoDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketInfoDataGrid2.Location = new System.Drawing.Point(9, 144);
            this.TicketInfoDataGrid2.Name = "TicketInfoDataGrid2";
            this.TicketInfoDataGrid2.Size = new System.Drawing.Size(755, 205);
            this.TicketInfoDataGrid2.TabIndex = 4;
            // 
            // CheckoutLbl
            // 
            this.CheckoutLbl.AutoSize = true;
            this.CheckoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutLbl.Location = new System.Drawing.Point(338, 6);
            this.CheckoutLbl.Name = "CheckoutLbl";
            this.CheckoutLbl.Size = new System.Drawing.Size(138, 31);
            this.CheckoutLbl.TabIndex = 0;
            this.CheckoutLbl.Text = "Checkout";
            // 
            // TicketNo
            // 
            this.TicketNo.AutoSize = true;
            this.TicketNo.Location = new System.Drawing.Point(259, 65);
            this.TicketNo.Name = "TicketNo";
            this.TicketNo.Size = new System.Drawing.Size(51, 13);
            this.TicketNo.TabIndex = 1;
            this.TicketNo.Text = "TicketNo";
            // 
            // TicketNoTF
            // 
            this.TicketNoTF.Location = new System.Drawing.Point(325, 61);
            this.TicketNoTF.Name = "TicketNoTF";
            this.TicketNoTF.Size = new System.Drawing.Size(187, 20);
            this.TicketNoTF.TabIndex = 2;
            // 
            // CheckPriceBtn
            // 
            this.CheckPriceBtn.Location = new System.Drawing.Point(262, 106);
            this.CheckPriceBtn.Name = "CheckPriceBtn";
            this.CheckPriceBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckPriceBtn.TabIndex = 3;
            this.CheckPriceBtn.Text = "Check Price";
            this.CheckPriceBtn.UseVisualStyleBackColor = true;
            this.CheckPriceBtn.Click += new System.EventHandler(this.CheckPriceBtn_Click);
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(411, 106);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckoutBtn.TabIndex = 3;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // GenReportPanel
            // 
            this.GenReportPanel.Controls.Add(this.GenReportLbl);
            this.GenReportPanel.Controls.Add(this.GenDailyReportBtn);
            this.GenReportPanel.Controls.Add(this.GenWeeklyReportBtn);
            this.GenReportPanel.Location = new System.Drawing.Point(15, 80);
            this.GenReportPanel.Name = "GenReportPanel";
            this.GenReportPanel.Size = new System.Drawing.Size(776, 352);
            this.GenReportPanel.TabIndex = 5;
            this.GenReportPanel.Visible = false;
            // 
            // GenReportLbl
            // 
            this.GenReportLbl.AutoSize = true;
            this.GenReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenReportLbl.Location = new System.Drawing.Point(294, 3);
            this.GenReportLbl.Name = "GenReportLbl";
            this.GenReportLbl.Size = new System.Drawing.Size(231, 31);
            this.GenReportLbl.TabIndex = 0;
            this.GenReportLbl.Text = "Generate Report";
            // 
            // GenDailyReportBtn
            // 
            this.GenDailyReportBtn.Location = new System.Drawing.Point(165, 117);
            this.GenDailyReportBtn.Name = "GenDailyReportBtn";
            this.GenDailyReportBtn.Size = new System.Drawing.Size(174, 93);
            this.GenDailyReportBtn.TabIndex = 3;
            this.GenDailyReportBtn.Text = "Daily Report";
            this.GenDailyReportBtn.UseVisualStyleBackColor = true;
            this.GenDailyReportBtn.Click += new System.EventHandler(this.GenDailyReportBtn_Click);
            // 
            // GenWeeklyReportBtn
            // 
            this.GenWeeklyReportBtn.Location = new System.Drawing.Point(472, 117);
            this.GenWeeklyReportBtn.Name = "GenWeeklyReportBtn";
            this.GenWeeklyReportBtn.Size = new System.Drawing.Size(173, 93);
            this.GenWeeklyReportBtn.TabIndex = 4;
            this.GenWeeklyReportBtn.Text = "Weekly Report";
            this.GenWeeklyReportBtn.UseVisualStyleBackColor = true;
            this.GenWeeklyReportBtn.Click += new System.EventHandler(this.GenWeeklyReportBtn_Click);
            // 
            // ViewReportPanel
            // 
            this.ViewReportPanel.Controls.Add(this.ReportBasisLbl);
            this.ViewReportPanel.Controls.Add(this.ReportBasisCB);
            this.ViewReportPanel.Controls.Add(this.ChartTypeLbl);
            this.ViewReportPanel.Controls.Add(this.ChartTypeCB);
            this.ViewReportPanel.Controls.Add(this.ReportChart);
            this.ViewReportPanel.Controls.Add(this.ViewReportLbl);
            this.ViewReportPanel.Controls.Add(this.ViewDailyReportBtn);
            this.ViewReportPanel.Controls.Add(this.ViewWeeklyReportBtn);
            this.ViewReportPanel.Location = new System.Drawing.Point(12, 83);
            this.ViewReportPanel.Name = "ViewReportPanel";
            this.ViewReportPanel.Size = new System.Drawing.Size(776, 352);
            this.ViewReportPanel.TabIndex = 6;
            this.ViewReportPanel.Visible = false;
            // 
            // ReportBasisLbl
            // 
            this.ReportBasisLbl.AutoSize = true;
            this.ReportBasisLbl.Location = new System.Drawing.Point(457, 309);
            this.ReportBasisLbl.Name = "ReportBasisLbl";
            this.ReportBasisLbl.Size = new System.Drawing.Size(106, 13);
            this.ReportBasisLbl.TabIndex = 7;
            this.ReportBasisLbl.Text = "Weekly Report Basis";
            // 
            // ReportBasisCB
            // 
            this.ReportBasisCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportBasisCB.FormattingEnabled = true;
            this.ReportBasisCB.Items.AddRange(new object[] {
            "Visitor count",
            "Earning"});
            this.ReportBasisCB.Location = new System.Drawing.Point(459, 323);
            this.ReportBasisCB.Name = "ReportBasisCB";
            this.ReportBasisCB.Size = new System.Drawing.Size(121, 21);
            this.ReportBasisCB.TabIndex = 6;
            // 
            // ReportChart
            // 
            this.ReportChart.BackColor = System.Drawing.Color.Transparent;
            this.ReportChart.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea2.Name = "ChartArea1";
            this.ReportChart.ChartAreas.Add(chartArea2);
            this.ReportChart.Location = new System.Drawing.Point(143, 34);
            this.ReportChart.Name = "ReportChart";
            this.ReportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.ReportChart.Series.Add(series2);
            this.ReportChart.Size = new System.Drawing.Size(630, 261);
            this.ReportChart.TabIndex = 5;
            this.ReportChart.Text = "ReportChart";
            // 
            // ViewReportLbl
            // 
            this.ViewReportLbl.AutoSize = true;
            this.ViewReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReportLbl.Location = new System.Drawing.Point(313, 0);
            this.ViewReportLbl.Name = "ViewReportLbl";
            this.ViewReportLbl.Size = new System.Drawing.Size(173, 31);
            this.ViewReportLbl.TabIndex = 0;
            this.ViewReportLbl.Text = "View Report";
            // 
            // ViewDailyReportBtn
            // 
            this.ViewDailyReportBtn.Location = new System.Drawing.Point(16, 301);
            this.ViewDailyReportBtn.Name = "ViewDailyReportBtn";
            this.ViewDailyReportBtn.Size = new System.Drawing.Size(174, 48);
            this.ViewDailyReportBtn.TabIndex = 3;
            this.ViewDailyReportBtn.Text = "Daily Report";
            this.ViewDailyReportBtn.UseVisualStyleBackColor = true;
            this.ViewDailyReportBtn.Click += new System.EventHandler(this.ViewDailyReportBtn_Click);
            // 
            // ViewWeeklyReportBtn
            // 
            this.ViewWeeklyReportBtn.Location = new System.Drawing.Point(585, 301);
            this.ViewWeeklyReportBtn.Name = "ViewWeeklyReportBtn";
            this.ViewWeeklyReportBtn.Size = new System.Drawing.Size(173, 48);
            this.ViewWeeklyReportBtn.TabIndex = 4;
            this.ViewWeeklyReportBtn.Text = "Weekly Report";
            this.ViewWeeklyReportBtn.UseVisualStyleBackColor = true;
            this.ViewWeeklyReportBtn.Click += new System.EventHandler(this.ViewWeeklyReportBtn_Click);
            // 
            // ChartTypeCB
            // 
            this.ChartTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartTypeCB.FormattingEnabled = true;
            this.ChartTypeCB.Items.AddRange(new object[] {
            "Column",
            "Pie"});
            this.ChartTypeCB.Location = new System.Drawing.Point(16, 60);
            this.ChartTypeCB.Name = "ChartTypeCB";
            this.ChartTypeCB.Size = new System.Drawing.Size(121, 21);
            this.ChartTypeCB.TabIndex = 6;
            // 
            // ChartTypeLbl
            // 
            this.ChartTypeLbl.AutoSize = true;
            this.ChartTypeLbl.Location = new System.Drawing.Point(18, 44);
            this.ChartTypeLbl.Name = "ChartTypeLbl";
            this.ChartTypeLbl.Size = new System.Drawing.Size(56, 13);
            this.ChartTypeLbl.TabIndex = 7;
            this.ChartTypeLbl.Text = "ChartType";
            // 
            // dailyReportBindingSource
            // 
            this.dailyReportBindingSource.DataSource = typeof(AppDevCW1.DailyReport);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewReportPanel);
            this.Controls.Add(this.CheckoutPanel);
            this.Controls.Add(this.GenReportPanel);
            this.Controls.Add(this.EmployeeNavPannel);
            this.Controls.Add(this.CheckinPanel);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.EmployeeNavPannel.ResumeLayout(false);
            this.CheckinPanel.ResumeLayout(false);
            this.CheckinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoDataGrid)).EndInit();
            this.CheckoutPanel.ResumeLayout(false);
            this.CheckoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketInfoDataGrid2)).EndInit();
            this.GenReportPanel.ResumeLayout(false);
            this.GenReportPanel.PerformLayout();
            this.ViewReportPanel.ResumeLayout(false);
            this.ViewReportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeeNavPannel;
        private System.Windows.Forms.Button CustomerCheckinBtn;
        private System.Windows.Forms.Button CustomerCheckoutBtn;
        private System.Windows.Forms.Button ViewReportBtn;
        private System.Windows.Forms.Button GenReportBtn;
        private System.Windows.Forms.Panel CheckinPanel;
        private System.Windows.Forms.Label TicketType;
        private System.Windows.Forms.Label CheckinLbl;
        private System.Windows.Forms.Label DayLbl;
        private System.Windows.Forms.ComboBox TicketTypeCB;
        private System.Windows.Forms.ComboBox DayCB;
        private System.Windows.Forms.Button CheckinBtn;
        private System.Windows.Forms.DataGridView TicketInfoDataGrid;
        private System.Windows.Forms.Panel CheckoutPanel;
        private System.Windows.Forms.Label TicketNo;
        private System.Windows.Forms.Label CheckoutLbl;
        private System.Windows.Forms.TextBox TicketNoTF;
        private System.Windows.Forms.Button CheckPriceBtn;
        private System.Windows.Forms.Button CheckoutBtn;
        private System.Windows.Forms.DataGridView TicketInfoDataGrid2;
        private System.Windows.Forms.Panel GenReportPanel;
        private System.Windows.Forms.Label GenReportLbl;
        private System.Windows.Forms.Button GenDailyReportBtn;
        private System.Windows.Forms.Button GenWeeklyReportBtn;
        private System.Windows.Forms.Panel ViewReportPanel;
        private System.Windows.Forms.Label ViewReportLbl;
        private System.Windows.Forms.Button ViewDailyReportBtn;
        private System.Windows.Forms.Button ViewWeeklyReportBtn;
        private System.Windows.Forms.BindingSource dailyReportBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReportChart;
        private System.Windows.Forms.Label ReportBasisLbl;
        private System.Windows.Forms.ComboBox ReportBasisCB;
        private System.Windows.Forms.Label ChartTypeLbl;
        private System.Windows.Forms.ComboBox ChartTypeCB;
    }
}