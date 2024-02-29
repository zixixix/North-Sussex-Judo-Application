using System.Drawing;
using System.Windows.Forms;

namespace JudoProgram
{
    public class CustomFormMovement
    {
        #region Variables
        public bool mouseDown = false;
        public Point mouseLocation = new Point();
        #endregion

        #region Functions and Movement
        public void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseLocation = e.Location;
        }

        public void MouseMove(object sender, MouseEventArgs e, Form form)
        {
            if (mouseDown)
            {
                form.Location = new Point((e.X + form.Location.X) - mouseLocation.X, (e.Y + form.Location.Y) - mouseLocation.Y);
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

    }
}
