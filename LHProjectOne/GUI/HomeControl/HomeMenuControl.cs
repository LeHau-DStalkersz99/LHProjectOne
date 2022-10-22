using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LHProjectOne.GUI.HomeControl
{
    public partial class HomeMenuControl : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public HomeMenuControl()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnHomeControlMenu.Controls.Add(leftBorderBtn);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
           this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParam, int lParam);

        /*---------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------START FUNCTION IN CLASS-----------------------------------------*/
        /*---------------------------------------------------------------------------------------------------------*/
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(172, 123, 241);
            public static Color color1 = Color.FromArgb(249, 118, 176);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);
            public static Color color5 = Color.FromArgb(24, 161, 251);
        }

        private void activateButton(Object senderBtn , Color color)
        {
            if(senderBtn != null)
            {
                //disable button before change 
                disableButton();

                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void disableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;

            //icon current child form
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblHomeTitleChildForm.Text = "Home";
        }

        //call child form to panel home screen desktop
        private void openChildFrom(Form childForm )
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnScreenHomeDesktop.Controls.Add(childForm);
            pnScreenHomeDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHomeTitleChildForm.Text = childForm.Text;
        }

        private void closeChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        /*---------------------------------------------------------------------------------------------------------*/
        /*-----------------------------------------END FUNCTION IN CLASS-----------------------------------------*/
        /*---------------------------------------------------------------------------------------------------------*/


        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color0);
            openChildFrom(new FormDashboard());
        }

        private void iconButtonPersonal_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color1);
            openChildFrom(new FormPersonal());
        }

        private void iconButtonSalary_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildFrom(new FormSalary());
        }

        private void iconButtonRevenueExpenditure_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
            openChildFrom(new FormRevenueExpenditure());
        }

        private void iconButtonNote_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
            openChildFrom(new FormNote());
        }

        private void iconButtonOther_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color5);
        }

        private void picBoxButtonLogo_Click(object sender, EventArgs e)
        {
            //closeChildForm();
            //reset();
            Application.Exit();
            
        }

        private void pnHomeControlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
