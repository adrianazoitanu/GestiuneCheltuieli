using System;
using System.Collections;
using NivelAccesDate;
using Librarie;
using System.Windows.Forms;


namespace GestiuneCheltuieli
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interfata());

            }

       
       
        
    }
}
