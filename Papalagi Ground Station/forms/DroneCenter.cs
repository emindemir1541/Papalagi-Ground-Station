using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papalagi_Ground_Station.forms
{
    public partial class DroneCenter : Form
    {
        public DroneCenter()
        {
            InitializeComponent();
        }

        private void DroneCenter_Load(object sender, EventArgs e)
        {

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

     
    }


}
