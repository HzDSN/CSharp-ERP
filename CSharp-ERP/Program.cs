﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_ERP
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginWindow());
            LoginWindow login = new LoginWindow();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form2());
            }
        }
    }
}
