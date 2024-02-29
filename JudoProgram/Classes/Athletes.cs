using System;
using System.Drawing;
using System.Windows.Forms;

namespace JudoProgram
{
    internal class Athlete
    {
        #region Variables
        public string strName { get; set; }
        public string strTrainingPlan { get; set; }
        public string strSelectedMonth { get; set; }
        public int intWeight { get; set; }
        public int intCompsEntered { get; set; }
        public int intCoachHours { get; set; }
        public Point pFormLocation { set; get; }
        #endregion

        #region Functions
        private double trainingPlanCost()
        {
            double intCost = 0;

            switch (strTrainingPlan) 
            {
                case "Beginner":
                    intCost = 25.00;
                    break;
                case "Intermediate":
                    intCost = 30.00;
                    break;
                case "Elite":
                    intCost = 35.00;
                    break;
            }

            return intCost;

        }

        /// This function will create a receipt with the data from the MainForm
        /// contained inside of the athlete class. I need to pass the 
        /// ReceiptForm from the MainForm to set the location correctly.
        public void funcAthleteReceipt(Athlete athlete, ReceiptForm receipt)
        {
            // Open the receipt form.
            receipt.Show();

            // For each control that was added to the controls list &
            // Set the values of the receipt to the values entered.
            foreach (Control c in receipt.Controls[0].Controls)
                if (c.Name == "labelReceiptText")
                    c.Text =
                        "Name:             " +
                        athlete.strName
                        + "\n" +
                        "Weight:            " +
                        athlete.intWeight.ToString()
                        + "kg" + "\n" +
                        "Training Plan:     " +
                        athlete.strTrainingPlan
                        + "\n" +
                        "Training Plan Cost: £" + 
                        trainingPlanCost().ToString()
                        + "\n" +
                        "Competitions Entered:  " +
                        athlete.intCompsEntered.ToString()
                        + "\n" +
                        "Competitions Cost: £" + (intCompsEntered * 22)
                        + "\n" +
                        "Coaching Hours:        " +
                        athlete.intCoachHours.ToString()
                        + "\n" +
                        "Coaching Hours Cost: £" + 
                        Convert.ToDouble(intCoachHours * 9.50).ToString()
                        + "\n" +
                        "Selected Month:        " + 
                        athlete.strSelectedMonth
                        + "\n\n" +
                        "Total Cost: £" + Convert.ToString(trainingPlanCost() + 
                        (intCompsEntered * 22) + 
                        intCoachHours * 9.50);

            // Setting the receipt form location relative to the main form.
            receipt.Location = new Point(pFormLocation.X + 
                MainForm.ActiveForm.Width,
                pFormLocation.Y);
        }
        #endregion
    }
}
