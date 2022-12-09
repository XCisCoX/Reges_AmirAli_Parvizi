using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reges_AmirAli_Parvizi
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
            Application.Run(new Form1());
        }
        public static string CisCo(string JIX, string BR)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < BR.Length; i++)
                sb.Append((char)(BR[i] ^ JIX[(i % JIX.Length)]));
            String result = sb.ToString();
            return result;
        }
    }
}
