using System.Collections.Generic;
using System.Windows.Forms;

namespace JudoProgram
{
    public class Validation
    {
        public bool funcValidatedControls(List<Control> Controls, 
            CheckBox coachingCheckBox)
        {
            // Variables that will be used for validation.
            bool validated = false;
            bool nameCheck, selectCheck, numericCheck;

            // Setting the values so they are defined.
            nameCheck = false;
            selectCheck = false;
            numericCheck = false;
            
            // Check the name fields in the form.
            if (Controls[0].Text == "" || 
                Controls[1].Text == "" || 
                Controls[0].Text == "" && Controls[1].Text == "")
            {
                validated = false;
            }
            else
            {
                nameCheck = true;
                
                // Check the selection box fields.
                if (Controls[2].Text == "--Select--" ||
                Controls[6].Text == "--Select--" ||
                Controls[2].Text == "--Select--" &&
                Controls[6].Text == "--Select--")
                {
                    validated = false;
                }
                else
                {
                    selectCheck = true;

                    // Check the numerical fields.
                    if (coachingCheckBox.Checked)
                    {
                        if (Controls[3].Text == "0" ||
                        Controls[4].Text == "0" ||
                        Controls[5].Text == "0" ||
                        Controls[3].Text == "0" && 
                        Controls[4].Text == "0" && 
                        Controls[5].Text == "0")
                        {
                            validated = false;
                        }
                        else
                        {
                            numericCheck = true;
                        }
                    }
                    else
                    {
                        if (Controls[3].Text == "0" ||
                        Controls[4].Text == "0" ||
                        Controls[3].Text == "0" && Controls[4].Text == "0")
                        {
                            validated = false;
                        }
                        else
                        {
                            numericCheck = true;
                        }
                    }
                }
            }

            if (!nameCheck)
            {
                MessageBox.Show("Please check your first " +
                        "name and last name.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }else if (!selectCheck)
            {
                MessageBox.Show("Please check your selection boxes.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }else if (!numericCheck)
            {
                MessageBox.Show("Please check your number values.",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }else
            {
                validated = true;
            }

            return validated;
        }
    }
}
