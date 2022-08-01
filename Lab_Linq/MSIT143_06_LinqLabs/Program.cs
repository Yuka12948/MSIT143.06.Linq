using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT143_06_LinqLabs
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frm_LinqHW01());
            Application.Run(new frm_LinqHW02());
            Application.Run(new frm_LinqHW03());
            Application.Run(new frm_LinqHW04());
        }
    }
}
