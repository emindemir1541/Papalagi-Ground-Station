using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Papalagi_Ground_Station.forms;
using Papalagi_Ground_Station.data.server;

namespace Papalagi_Ground_Station
{
    public partial class Menu : Form
    {
        private const string GROUND_STATION = "Ground Station";



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect, int nWidthEllipse,int nHeightEllipse);

        DroneCenter formDroneCenter = new DroneCenter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Tracking formTracking = new Tracking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        HttpServerPage httpServerForm = new HttpServerPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Form activeForm = new Form();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Console.WriteLine("deneme");
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            activeForm = null;
            navPanel.Visible = false;


        }



        private void btnDroneCenter_Click(object sender, EventArgs e)
        {
            getFormToPanel(formDroneCenter);
            pushButtonAction(btnDroneCenter);

        }
        private void btnTracking_Click(object sender, EventArgs e)
        {
            getFormToPanel(formTracking);
            pushButtonAction(btnTracking);

        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            pushButtonAction(btnSettings);
        }
        private void btnDroneCenter_Leave(object sender, EventArgs e)
        {
            leaveButtonAction(btnDroneCenter);
        }
        private void btnTracking_Leave(object sender, EventArgs e)
        {
            leaveButtonAction(btnTracking);
        }
        private void btnSettings_Leave(object sender, EventArgs e)
        {
            leaveButtonAction(btnSettings);
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            pushButtonAction();
        }


        private void pushButtonAction(Button button = null)
        {
            if(button == null)
            {
                if(activeForm != null)
                activeForm.Hide();

                navPanel.Visible = false;
                setTitle();
            }
            else {
            navPanel.Visible = true;
            navPanel.Height = button.Height;
            navPanel.Top = button.Top;
            navPanel.Left = button.Left;
            navPanel.ForeColor = Color.FromArgb(91, 161, 153);
            setTitle(button);
            }
        }
        private void leaveButtonAction(Button button)
        {
            button.ForeColor = Color.FromArgb(129, 143, 140);
        }

        private void setTitle(Button button = null)
        {
            if (button == null)
            {
                lblTitle.Text = GROUND_STATION;
            }
            else
            {
                lblTitle.Text = button.Text;

            }
        }


        private void getFormToPanel(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;

            if (activeForm != null)
            {
                activeForm.Hide();
            }
            this.pnlFormSpace.Controls.Add(form);
            form.Show();
            activeForm = form;
        }



        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


            #region Form Hareket
        bool tutus;
        int fareX, fareY;
        private void pnlUp_MouseDown(object sender, MouseEventArgs e)
        {

            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }
        private void pnlUp_MouseMove(object sender, MouseEventArgs e)
        {

            if (tutus)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getFormToPanel(httpServerForm);
        }

        private void pnlUp_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }
        #endregion
    }
}
