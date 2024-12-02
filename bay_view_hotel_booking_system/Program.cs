using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace bay_view_hotel_booking_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SplashScreen());
            //Application.Run(new login());

            Environment.SetEnvironmentVariable("USER_EMAIL", "admin@bayview.com");

            Application.Run(new BookingAvailability());
        }
    }
}
