namespace JudoProgram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.flowLayoutTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.controlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboMonthSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTrainingPlans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowMainPage = new System.Windows.Forms.FlowLayoutPanel();
            this.numWeightKg = new System.Windows.Forms.NumericUpDown();
            this.numComps = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxCoaching = new System.Windows.Forms.CheckBox();
            this.numCoachHrs = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWeightClass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.flowLayoutTitle.SuspendLayout();
            this.controlItems.SuspendLayout();
            this.flowMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoachHrs)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.LightCoral;
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.flowLayoutTitle);
            this.titlePanel.Controls.Add(this.controlItems);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(253, 25);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleMouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleMouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleMouseUp);
            // 
            // flowLayoutTitle
            // 
            this.flowLayoutTitle.Controls.Add(this.label1);
            this.flowLayoutTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutTitle.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutTitle.Name = "flowLayoutTitle";
            this.flowLayoutTitle.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.flowLayoutTitle.Size = new System.Drawing.Size(134, 23);
            this.flowLayoutTitle.TabIndex = 0;
            this.flowLayoutTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleMouseDown);
            this.flowLayoutTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleMouseMove);
            this.flowLayoutTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "North Sussex Judo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlItems
            // 
            this.controlItems.Controls.Add(this.btnMinimise);
            this.controlItems.Controls.Add(this.btnClose);
            this.controlItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlItems.Location = new System.Drawing.Point(137, 0);
            this.controlItems.Name = "controlItems";
            this.controlItems.Size = new System.Drawing.Size(114, 23);
            this.controlItems.TabIndex = 1;
            this.controlItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleMouseDown);
            this.controlItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleMouseMove);
            this.controlItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleMouseUp);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Location = new System.Drawing.Point(3, 3);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(49, 20);
            this.btnMinimise.TabIndex = 10;
            this.btnMinimise.Text = "-";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            this.btnMinimise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleMouseDown);
            this.btnMinimise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleMouseMove);
            this.btnMinimise.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleMouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(58, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 20);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboMonthSelect
            // 
            this.comboMonthSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.comboMonthSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboMonthSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMonthSelect.FormattingEnabled = true;
            this.comboMonthSelect.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboMonthSelect.Location = new System.Drawing.Point(131, 169);
            this.comboMonthSelect.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboMonthSelect.Name = "comboMonthSelect";
            this.comboMonthSelect.Size = new System.Drawing.Size(100, 21);
            this.comboMonthSelect.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Select Month";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Coaching Hours";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Competitions Entered";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Weight (kg)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboTrainingPlans
            // 
            this.comboTrainingPlans.AutoCompleteCustomSource.AddRange(new string[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.comboTrainingPlans.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboTrainingPlans.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTrainingPlans.FormattingEnabled = true;
            this.comboTrainingPlans.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.comboTrainingPlans.Location = new System.Drawing.Point(18, 169);
            this.comboTrainingPlans.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboTrainingPlans.Name = "comboTrainingPlans";
            this.comboTrainingPlans.Size = new System.Drawing.Size(100, 21);
            this.comboTrainingPlans.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Training Plan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(18, 110);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxLastName.MaxLength = 125;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(18, 51);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxFirstName.MaxLength = 125;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowMainPage
            // 
            this.flowMainPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowMainPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMainPage.Controls.Add(this.label2);
            this.flowMainPage.Controls.Add(this.textBoxFirstName);
            this.flowMainPage.Controls.Add(this.label3);
            this.flowMainPage.Controls.Add(this.textBoxLastName);
            this.flowMainPage.Controls.Add(this.label4);
            this.flowMainPage.Controls.Add(this.comboTrainingPlans);
            this.flowMainPage.Controls.Add(this.label5);
            this.flowMainPage.Controls.Add(this.numWeightKg);
            this.flowMainPage.Controls.Add(this.label6);
            this.flowMainPage.Controls.Add(this.numComps);
            this.flowMainPage.Controls.Add(this.label11);
            this.flowMainPage.Controls.Add(this.checkBoxCoaching);
            this.flowMainPage.Controls.Add(this.label7);
            this.flowMainPage.Controls.Add(this.numCoachHrs);
            this.flowMainPage.Controls.Add(this.label8);
            this.flowMainPage.Controls.Add(this.comboMonthSelect);
            this.flowMainPage.Controls.Add(this.label9);
            this.flowMainPage.Controls.Add(this.textBoxWeightClass);
            this.flowMainPage.Controls.Add(this.label10);
            this.flowMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMainPage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMainPage.Location = new System.Drawing.Point(0, 25);
            this.flowMainPage.Name = "flowMainPage";
            this.flowMainPage.Padding = new System.Windows.Forms.Padding(15);
            this.flowMainPage.Size = new System.Drawing.Size(253, 329);
            this.flowMainPage.TabIndex = 1;
            // 
            // numWeightKg
            // 
            this.numWeightKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWeightKg.Location = new System.Drawing.Point(18, 229);
            this.numWeightKg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numWeightKg.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numWeightKg.Name = "numWeightKg";
            this.numWeightKg.Size = new System.Drawing.Size(100, 20);
            this.numWeightKg.TabIndex = 21;
            this.numWeightKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numWeightKg.ValueChanged += new System.EventHandler(this.funcCalcWeight);
            // 
            // numComps
            // 
            this.numComps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numComps.Location = new System.Drawing.Point(18, 288);
            this.numComps.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numComps.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numComps.Name = "numComps";
            this.numComps.Size = new System.Drawing.Size(100, 20);
            this.numComps.TabIndex = 22;
            this.numComps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(131, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Coaching Hours";
            // 
            // checkBoxCoaching
            // 
            this.checkBoxCoaching.Location = new System.Drawing.Point(131, 51);
            this.checkBoxCoaching.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.checkBoxCoaching.Name = "checkBoxCoaching";
            this.checkBoxCoaching.Size = new System.Drawing.Size(100, 20);
            this.checkBoxCoaching.TabIndex = 0;
            this.checkBoxCoaching.Text = "Yes/No";
            this.checkBoxCoaching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCoaching.UseVisualStyleBackColor = true;
            this.checkBoxCoaching.CheckStateChanged += new System.EventHandler(this.funcOnCoachingChecked);
            // 
            // numCoachHrs
            // 
            this.numCoachHrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCoachHrs.Enabled = false;
            this.numCoachHrs.Location = new System.Drawing.Point(131, 110);
            this.numCoachHrs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numCoachHrs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCoachHrs.Name = "numCoachHrs";
            this.numCoachHrs.Size = new System.Drawing.Size(100, 20);
            this.numCoachHrs.TabIndex = 23;
            this.numCoachHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Weight Class";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWeightClass
            // 
            this.textBoxWeightClass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxWeightClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWeightClass.Enabled = false;
            this.textBoxWeightClass.Location = new System.Drawing.Point(131, 229);
            this.textBoxWeightClass.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxWeightClass.Name = "textBoxWeightClass";
            this.textBoxWeightClass.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightClass.TabIndex = 19;
            this.textBoxWeightClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(131, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Weight (kg)";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnClear);
            this.flowLayoutPanel2.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 354);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(253, 31);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 3, 90, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.funcClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirm.Location = new System.Drawing.Point(171, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.funcConfirm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 385);
            this.Controls.Add(this.flowMainPage);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "North Sussex Judo";
            this.Load += new System.EventHandler(this.funcOnFormLoad);
            this.titlePanel.ResumeLayout(false);
            this.flowLayoutTitle.ResumeLayout(false);
            this.flowLayoutTitle.PerformLayout();
            this.controlItems.ResumeLayout(false);
            this.flowMainPage.ResumeLayout(false);
            this.flowMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoachHrs)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel controlItems;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboMonthSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTrainingPlans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowMainPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWeightClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.NumericUpDown numWeightKg;
        private System.Windows.Forms.NumericUpDown numComps;
        private System.Windows.Forms.NumericUpDown numCoachHrs;
        private System.Windows.Forms.CheckBox checkBoxCoaching;
    }
}