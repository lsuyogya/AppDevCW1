
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
            this.EmployeeNavPannel = new System.Windows.Forms.Panel();
            this.CheckinBtn = new System.Windows.Forms.Button();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.ViewReportBtn = new System.Windows.Forms.Button();
            this.GenReportBtn = new System.Windows.Forms.Button();
            this.CheckinPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckinLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeNavPannel.SuspendLayout();
            this.CheckinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeNavPannel
            // 
            this.EmployeeNavPannel.BackColor = System.Drawing.SystemColors.Highlight;
            this.EmployeeNavPannel.Controls.Add(this.CheckinBtn);
            this.EmployeeNavPannel.Controls.Add(this.CheckoutBtn);
            this.EmployeeNavPannel.Controls.Add(this.GenReportBtn);
            this.EmployeeNavPannel.Controls.Add(this.ViewReportBtn);
            this.EmployeeNavPannel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeNavPannel.Name = "EmployeeNavPannel";
            this.EmployeeNavPannel.Size = new System.Drawing.Size(801, 67);
            this.EmployeeNavPannel.TabIndex = 0;
            // 
            // CheckinBtn
            // 
            this.CheckinBtn.Location = new System.Drawing.Point(28, 22);
            this.CheckinBtn.Name = "CheckinBtn";
            this.CheckinBtn.Size = new System.Drawing.Size(111, 23);
            this.CheckinBtn.TabIndex = 0;
            this.CheckinBtn.Text = "Customer Checkin";
            this.CheckinBtn.UseVisualStyleBackColor = true;
            this.CheckinBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(247, 22);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(111, 23);
            this.CheckoutBtn.TabIndex = 0;
            this.CheckoutBtn.Text = "Customer Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewReportBtn
            // 
            this.ViewReportBtn.Location = new System.Drawing.Point(659, 22);
            this.ViewReportBtn.Name = "ViewReportBtn";
            this.ViewReportBtn.Size = new System.Drawing.Size(111, 23);
            this.ViewReportBtn.TabIndex = 0;
            this.ViewReportBtn.Text = "View Report";
            this.ViewReportBtn.UseVisualStyleBackColor = true;
            this.ViewReportBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenReportBtn
            // 
            this.GenReportBtn.Location = new System.Drawing.Point(452, 22);
            this.GenReportBtn.Name = "GenReportBtn";
            this.GenReportBtn.Size = new System.Drawing.Size(111, 23);
            this.GenReportBtn.TabIndex = 0;
            this.GenReportBtn.Text = "Generate Report";
            this.GenReportBtn.UseVisualStyleBackColor = true;
            this.GenReportBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckinPanel
            // 
            this.CheckinPanel.Controls.Add(this.label1);
            this.CheckinPanel.Controls.Add(this.CheckinLbl);
            this.CheckinPanel.Controls.Add(this.textBox1);
            this.CheckinPanel.Location = new System.Drawing.Point(12, 83);
            this.CheckinPanel.Name = "CheckinPanel";
            this.CheckinPanel.Size = new System.Drawing.Size(620, 355);
            this.CheckinPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            // 
            // CheckinLbl
            // 
            this.CheckinLbl.AutoSize = true;
            this.CheckinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckinLbl.Location = new System.Drawing.Point(269, 12);
            this.CheckinLbl.Name = "CheckinLbl";
            this.CheckinLbl.Size = new System.Drawing.Size(120, 31);
            this.CheckinLbl.TabIndex = 1;
            this.CheckinLbl.Text = "Checkin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckinPanel);
            this.Controls.Add(this.EmployeeNavPannel);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.EmployeeNavPannel.ResumeLayout(false);
            this.CheckinPanel.ResumeLayout(false);
            this.CheckinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeeNavPannel;
        private System.Windows.Forms.Button CheckinBtn;
        private System.Windows.Forms.Button CheckoutBtn;
        private System.Windows.Forms.Button ViewReportBtn;
        private System.Windows.Forms.Button GenReportBtn;
        private System.Windows.Forms.Panel CheckinPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CheckinLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}