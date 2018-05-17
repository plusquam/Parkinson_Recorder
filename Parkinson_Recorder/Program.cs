using System;
using System.Windows.Forms;

namespace Parkinson_Recorder
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgramMainWindow());
        }
    }
}
