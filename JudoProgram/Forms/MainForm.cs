using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JudoProgram
{
    public partial class MainForm : Form
    {
        // variables that are required for the athlete to enter data.
        
        static Athlete athlete = new Athlete();
        static Validation validation = new Validation();
        static ReceiptForm receipt = new ReceiptForm();
        public List<Control> formControls = new List<Control>();

        public MainForm()
        {
            InitializeComponent();
        }

        /* To acheive the styling I wanted, I used a panel for the titlebar,
         * I created a custom movement .cs file which contains the code needed
         * to move the form around.
         */
        #region Custom Form Movement Functionality
        static CustomFormMovement CFM = new CustomFormMovement();

        private void titleMouseDown(object sender, MouseEventArgs e)
        {
            CFM.MouseDown(sender, e);
        }

        private void titleMouseUp(object sender, MouseEventArgs e)
        {
            CFM.MouseUp(sender, e);
        }

        private void titleMouseMove(object sender, MouseEventArgs e)
        {
            CFM.MouseMove(sender, e, this);
            receipt.funcMoveForm(sender, e, this);
            
        }
        #endregion

        /* Control buttons for the titlebar,
         * close form, minimise form.
         */
        #region Control Buttons Functionality
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Functions
        private void funcOnFormLoad(object sender, EventArgs e)
        {
            // Setting default value of Training Plans combo box.
            comboTrainingPlans.SelectedItem = null;
            comboTrainingPlans.SelectedText = "--Select--";

            // Setting default value of Month selection combo box.
            comboMonthSelect.SelectedItem = null;
            comboMonthSelect.SelectedText = "--Select--";

            // foreach to add controls to a list.
            foreach (Control c in flowMainPage.Controls)
            {
                /* Check the type of control and add too list,
                 * we don't need to add textBox4.
                 */
                if (c is TextBox && c.Name != "textBox4") 
                    formControls.Add(c);
                if (c is ComboBox) 
                    formControls.Add(c);
                if (c is NumericUpDown) 
                    formControls.Add(c);
            }
        }

        // When the user clicks on the clear button.
        private void funcClear_Click(object sender, EventArgs e)
        {
            // Clear all of the control items in the form.
            for (int i = 0; i < formControls.Count; i++)
            {
                checkBoxCoaching.Checked = false;

                if (formControls[i] is ComboBox)
                    formControls[i].Text = "--Select--";
                else if (formControls[i] is NumericUpDown)
                    formControls[i].Text = "0";
                else
                    formControls[i].Text = "";
            }
        }

        // When the user clicks on the confirm button.
        private void funcConfirm_Click(object sender, EventArgs e)
        {
            athlete.pFormLocation = this.Location;

            /* Gathering the text from each of the control items */
            string[] strListArr = { "","","","","","","","" };
            for(int i = 0; i < formControls.Count; i++) 
            {
                strListArr[i] += formControls[i].Text;
            }

            // Set the athlete data relative to the data entered.
            athlete.strName = strListArr[0] + " " + strListArr[1];
            athlete.strTrainingPlan = strListArr[2];
            athlete.strSelectedMonth = strListArr[6];

            // Converting the string values to an int value.
            athlete.intWeight = Convert.ToInt32(strListArr[3]);
            athlete.intCompsEntered = Convert.ToInt32(strListArr[4]);
            athlete.intCoachHours = Convert.ToInt32(strListArr[5]);

            // Validation
            if(validation.funcValidatedControls(formControls, checkBoxCoaching)
                == true)
                if (!receipt.IsDisposed) {
                    athlete.funcAthleteReceipt(athlete, receipt);
                }
                else { 
                    receipt = new ReceiptForm();
                    athlete.funcAthleteReceipt(athlete, receipt);
                }
        }

        // When the checkbox is checked, set the coaching hours to enabled.
        private void funcOnCoachingChecked(object sender, EventArgs e)
        {
            if (checkBoxCoaching.Checked == true)
            {
                numCoachHrs.Enabled = true;
            }
            else
            {
                numCoachHrs.Enabled = false;
            }
        }

        private void funcCalcWeight(object sender, EventArgs e)
        {
            NumericUpDown numWeight = numWeightKg;
            TextBox weightClass = textBoxWeightClass;

            int numWeightValue = Convert.ToInt32(numWeight.Value);

            // Switch case to switch through different values.
            switch (numWeightValue)
            {
                case int _ when(numWeightValue <= 66):
                    weightClass.Text = "Flyweight";
                    break;
                case int _ when (numWeightValue <= 73):
                    weightClass.Text = "Lightweight";
                    break;
                case int _ when(numWeightValue <= 81):
                    weightClass.Text = "Light-Middleweight";
                    break;
                case int _ when (numWeightValue <= 90):
                    weightClass.Text = "Middleweight";
                    break;
                case int _ when(numWeightValue <=100):
                    weightClass.Text = "Light-Heavyweight";
                    break;
                case int _ when (numWeightValue > 100):
                    MessageBox.Show("100 over");
                    break;
            }
        }
        #endregion

    }
}
