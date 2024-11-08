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
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }

        int tick_count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick_count < 6)
            {
                tick_count++;
                loading_bar.PerformStep();
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
