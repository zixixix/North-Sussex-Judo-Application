
namespace JudoProgram
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelReceiptText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "== Receipt ==";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnClose);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 354);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(253, 31);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 3, 90, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.funBtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelReceiptText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 312);
            this.panel2.TabIndex = 25;
            // 
            // labelReceiptText
            // 
            this.labelReceiptText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelReceiptText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReceiptText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiptText.Location = new System.Drawing.Point(0, 0);
            this.labelReceiptText.Name = "labelReceiptText";
            this.labelReceiptText.Padding = new System.Windows.Forms.Padding(3);
            this.labelReceiptText.Size = new System.Drawing.Size(251, 310);
            this.labelReceiptText.TabIndex = 24;
            this.labelReceiptText.Text = "{ReceiptText}";
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 385);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiptForm";
            this.ShowInTaskbar = false;
            this.Text = "ReceiptForm";
            this.Deactivate += new System.EventHandler(this.funcOnFocusLoss);
            this.Load += new System.EventHandler(this.funcOnFormLoad);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelReceiptText;
    }
}