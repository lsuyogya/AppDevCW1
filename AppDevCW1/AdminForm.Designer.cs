
namespace AppDevCW1
{
    partial class AdminForm
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
            this.AdminNavPanel = new System.Windows.Forms.Panel();
            this.SetPricesBtn = new System.Windows.Forms.Button();
            this.RegEmployeeBtn = new System.Windows.Forms.Button();
            this.ViewReportBtn = new System.Windows.Forms.Button();
            this.RegisterEmployeePanel = new System.Windows.Forms.Panel();
            this.RegEmployeesLbl = new System.Windows.Forms.Label();
            this.UNameLbl = new System.Windows.Forms.Label();
            this.UNameTF = new System.Windows.Forms.TextBox();
            this.PWordLbl = new System.Windows.Forms.Label();
            this.PWordTF = new System.Windows.Forms.TextBox();
            this.ConfirmPWordLbl = new System.Windows.Forms.Label();
            this.ConfirmPWordTF = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SetPricesPanel = new System.Windows.Forms.Panel();
            this.SetPricesLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.CategoryTF = new System.Windows.Forms.TextBox();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.ValueTF = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.PricesDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewReportPanel = new System.Windows.Forms.Panel();
            this.ViewReportLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.AdminNavPanel.SuspendLayout();
            this.RegisterEmployeePanel.SuspendLayout();
            this.SetPricesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricesDataGrid)).BeginInit();
            this.ViewReportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminNavPanel
            // 
            this.AdminNavPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.AdminNavPanel.Controls.Add(this.SetPricesBtn);
            this.AdminNavPanel.Controls.Add(this.RegEmployeeBtn);
            this.AdminNavPanel.Controls.Add(this.ViewReportBtn);
            this.AdminNavPanel.Location = new System.Drawing.Point(1, 0);
            this.AdminNavPanel.Name = "AdminNavPanel";
            this.AdminNavPanel.Size = new System.Drawing.Size(798, 68);
            this.AdminNavPanel.TabIndex = 0;
            // 
            // SetPricesBtn
            // 
            this.SetPricesBtn.Location = new System.Drawing.Point(38, 23);
            this.SetPricesBtn.Name = "SetPricesBtn";
            this.SetPricesBtn.Size = new System.Drawing.Size(75, 23);
            this.SetPricesBtn.TabIndex = 0;
            this.SetPricesBtn.Text = "Set Prices";
            this.SetPricesBtn.UseVisualStyleBackColor = true;
            this.SetPricesBtn.Click += new System.EventHandler(this.SetPricesBtn_Click);
            // 
            // RegEmployeeBtn
            // 
            this.RegEmployeeBtn.Location = new System.Drawing.Point(344, 23);
            this.RegEmployeeBtn.Name = "RegEmployeeBtn";
            this.RegEmployeeBtn.Size = new System.Drawing.Size(110, 23);
            this.RegEmployeeBtn.TabIndex = 0;
            this.RegEmployeeBtn.Text = "Register Employee";
            this.RegEmployeeBtn.UseVisualStyleBackColor = true;
            this.RegEmployeeBtn.Click += new System.EventHandler(this.RegEmployeeBtn_Click);
            // 
            // ViewReportBtn
            // 
            this.ViewReportBtn.Location = new System.Drawing.Point(696, 23);
            this.ViewReportBtn.Name = "ViewReportBtn";
            this.ViewReportBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewReportBtn.TabIndex = 0;
            this.ViewReportBtn.Text = "View Report";
            this.ViewReportBtn.UseVisualStyleBackColor = true;
            this.ViewReportBtn.Click += new System.EventHandler(this.ViewReportBtn_Click);
            // 
            // RegisterEmployeePanel
            // 
            this.RegisterEmployeePanel.Controls.Add(this.RegEmployeesLbl);
            this.RegisterEmployeePanel.Controls.Add(this.UNameLbl);
            this.RegisterEmployeePanel.Controls.Add(this.UNameTF);
            this.RegisterEmployeePanel.Controls.Add(this.PWordLbl);
            this.RegisterEmployeePanel.Controls.Add(this.PWordTF);
            this.RegisterEmployeePanel.Controls.Add(this.ConfirmPWordLbl);
            this.RegisterEmployeePanel.Controls.Add(this.ConfirmPWordTF);
            this.RegisterEmployeePanel.Controls.Add(this.RegisterBtn);
            this.RegisterEmployeePanel.Location = new System.Drawing.Point(247, 127);
            this.RegisterEmployeePanel.Name = "RegisterEmployeePanel";
            this.RegisterEmployeePanel.Size = new System.Drawing.Size(319, 275);
            this.RegisterEmployeePanel.TabIndex = 2;
            this.RegisterEmployeePanel.Visible = false;
            // 
            // RegEmployeesLbl
            // 
            this.RegEmployeesLbl.AutoSize = true;
            this.RegEmployeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEmployeesLbl.Location = new System.Drawing.Point(36, 10);
            this.RegEmployeesLbl.Name = "RegEmployeesLbl";
            this.RegEmployeesLbl.Size = new System.Drawing.Size(260, 31);
            this.RegEmployeesLbl.TabIndex = 3;
            this.RegEmployeesLbl.Text = "Register Employee";
            // 
            // UNameLbl
            // 
            this.UNameLbl.AutoSize = true;
            this.UNameLbl.Location = new System.Drawing.Point(53, 105);
            this.UNameLbl.Name = "UNameLbl";
            this.UNameLbl.Size = new System.Drawing.Size(55, 13);
            this.UNameLbl.TabIndex = 0;
            this.UNameLbl.Text = "Username";
            // 
            // UNameTF
            // 
            this.UNameTF.Location = new System.Drawing.Point(114, 102);
            this.UNameTF.Name = "UNameTF";
            this.UNameTF.Size = new System.Drawing.Size(182, 20);
            this.UNameTF.TabIndex = 1;
            // 
            // PWordLbl
            // 
            this.PWordLbl.AutoSize = true;
            this.PWordLbl.Location = new System.Drawing.Point(52, 135);
            this.PWordLbl.Name = "PWordLbl";
            this.PWordLbl.Size = new System.Drawing.Size(53, 13);
            this.PWordLbl.TabIndex = 0;
            this.PWordLbl.Text = "Password";
            // 
            // PWordTF
            // 
            this.PWordTF.Location = new System.Drawing.Point(114, 133);
            this.PWordTF.Name = "PWordTF";
            this.PWordTF.PasswordChar = '*';
            this.PWordTF.Size = new System.Drawing.Size(182, 20);
            this.PWordTF.TabIndex = 1;
            // 
            // ConfirmPWordLbl
            // 
            this.ConfirmPWordLbl.AutoSize = true;
            this.ConfirmPWordLbl.Location = new System.Drawing.Point(14, 166);
            this.ConfirmPWordLbl.Name = "ConfirmPWordLbl";
            this.ConfirmPWordLbl.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPWordLbl.TabIndex = 2;
            this.ConfirmPWordLbl.Text = "Confirm Password";
            // 
            // ConfirmPWordTF
            // 
            this.ConfirmPWordTF.Location = new System.Drawing.Point(114, 163);
            this.ConfirmPWordTF.Name = "ConfirmPWordTF";
            this.ConfirmPWordTF.PasswordChar = '*';
            this.ConfirmPWordTF.Size = new System.Drawing.Size(182, 20);
            this.ConfirmPWordTF.TabIndex = 1;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(114, 226);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(111, 23);
            this.RegisterBtn.TabIndex = 0;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // SetPricesPanel
            // 
            this.SetPricesPanel.Controls.Add(this.SetPricesLbl);
            this.SetPricesPanel.Controls.Add(this.CategoryLbl);
            this.SetPricesPanel.Controls.Add(this.CategoryTF);
            this.SetPricesPanel.Controls.Add(this.ValueLbl);
            this.SetPricesPanel.Controls.Add(this.ValueTF);
            this.SetPricesPanel.Controls.Add(this.TypeLbl);
            this.SetPricesPanel.Controls.Add(this.TypeCB);
            this.SetPricesPanel.Controls.Add(this.AddBtn);
            this.SetPricesPanel.Controls.Add(this.UpdateBtn);
            this.SetPricesPanel.Controls.Add(this.PricesDataGrid);
            this.SetPricesPanel.Location = new System.Drawing.Point(39, 127);
            this.SetPricesPanel.Name = "SetPricesPanel";
            this.SetPricesPanel.Size = new System.Drawing.Size(733, 275);
            this.SetPricesPanel.TabIndex = 3;
            this.SetPricesPanel.Visible = false;
            // 
            // SetPricesLbl
            // 
            this.SetPricesLbl.AutoSize = true;
            this.SetPricesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPricesLbl.Location = new System.Drawing.Point(92, 10);
            this.SetPricesLbl.Name = "SetPricesLbl";
            this.SetPricesLbl.Size = new System.Drawing.Size(148, 31);
            this.SetPricesLbl.TabIndex = 3;
            this.SetPricesLbl.Text = "Set Prices";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(22, 57);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(49, 13);
            this.CategoryLbl.TabIndex = 0;
            this.CategoryLbl.Text = "Category";
            // 
            // CategoryTF
            // 
            this.CategoryTF.Location = new System.Drawing.Point(87, 54);
            this.CategoryTF.Name = "CategoryTF";
            this.CategoryTF.Size = new System.Drawing.Size(153, 20);
            this.CategoryTF.TabIndex = 4;
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(22, 92);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(34, 13);
            this.ValueLbl.TabIndex = 0;
            this.ValueLbl.Text = "Value";
            // 
            // ValueTF
            // 
            this.ValueTF.Location = new System.Drawing.Point(87, 89);
            this.ValueTF.Name = "ValueTF";
            this.ValueTF.Size = new System.Drawing.Size(153, 20);
            this.ValueTF.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(25, 226);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(221, 226);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // PricesDataGrid
            // 
            this.PricesDataGrid.AllowUserToAddRows = false;
            this.PricesDataGrid.AllowUserToDeleteRows = false;
            this.PricesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PricesDataGrid.Location = new System.Drawing.Point(459, 10);
            this.PricesDataGrid.Name = "PricesDataGrid";
            this.PricesDataGrid.ReadOnly = true;
            this.PricesDataGrid.Size = new System.Drawing.Size(271, 261);
            this.PricesDataGrid.TabIndex = 6;
            // 
            // ViewReportPanel
            // 
            this.ViewReportPanel.Controls.Add(this.ViewReportLbl);
            this.ViewReportPanel.Location = new System.Drawing.Point(39, 124);
            this.ViewReportPanel.Name = "ViewReportPanel";
            this.ViewReportPanel.Size = new System.Drawing.Size(727, 275);
            this.ViewReportPanel.TabIndex = 3;
            this.ViewReportPanel.Visible = false;
            // 
            // ViewReportLbl
            // 
            this.ViewReportLbl.AutoSize = true;
            this.ViewReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReportLbl.Location = new System.Drawing.Point(280, 1);
            this.ViewReportLbl.Name = "ViewReportLbl";
            this.ViewReportLbl.Size = new System.Drawing.Size(173, 31);
            this.ViewReportLbl.TabIndex = 3;
            this.ViewReportLbl.Text = "View Report";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(22, 122);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(31, 13);
            this.TypeLbl.TabIndex = 0;
            this.TypeLbl.Text = "Type";
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "BasePrice",
            "TicketType",
            "Day",
            "Duration"});
            this.TypeCB.Location = new System.Drawing.Point(87, 122);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(153, 21);
            this.TypeCB.TabIndex = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetPricesPanel);
            this.Controls.Add(this.AdminNavPanel);
            this.Controls.Add(this.RegisterEmployeePanel);
            this.Controls.Add(this.ViewReportPanel);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.AdminNavPanel.ResumeLayout(false);
            this.RegisterEmployeePanel.ResumeLayout(false);
            this.RegisterEmployeePanel.PerformLayout();
            this.SetPricesPanel.ResumeLayout(false);
            this.SetPricesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricesDataGrid)).EndInit();
            this.ViewReportPanel.ResumeLayout(false);
            this.ViewReportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminNavPanel;
        private System.Windows.Forms.Button ViewReportBtn;
        private System.Windows.Forms.Button RegEmployeeBtn;
        private System.Windows.Forms.Button SetPricesBtn;
        private System.Windows.Forms.Panel RegisterEmployeePanel;
        private System.Windows.Forms.Label ConfirmPWordLbl;
        private System.Windows.Forms.TextBox ConfirmPWordTF;
        private System.Windows.Forms.TextBox PWordTF;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox UNameTF;
        private System.Windows.Forms.Label UNameLbl;
        private System.Windows.Forms.Label PWordLbl;
        private System.Windows.Forms.Label RegEmployeesLbl;
        private System.Windows.Forms.Panel SetPricesPanel;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label SetPricesLbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.TextBox ValueTF;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox CategoryTF;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel ViewReportPanel;
        private System.Windows.Forms.Label ViewReportLbl;
        private System.Windows.Forms.DataGridView PricesDataGrid;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.ComboBox TypeCB;
    }
}