using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new SplashForm() );
            // Application.Run(new CategoryForm());
            // Application.Run(new ProductForm());
            //Application.Run(new SellerForm());
           // Application.Run(new Form1());
            //Application.Run(new SellingForm());
        }
    }
}
