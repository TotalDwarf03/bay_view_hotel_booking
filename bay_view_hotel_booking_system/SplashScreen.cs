using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bay_view_hotel_booking_system
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        int TickCount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TickCount < 6)
            {
                TickCount++;
                ProgressBar.PerformStep();
            }
            else
            {
                this.Close();
            }
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            SQLController controller = new SQLController();
            controller.InitialiseDatabase();
        }
    }
}
