using XpenseTracker;
using XpenseTracker.Data;
using XpenseTracker.Models;
using System;
using System.Windows.Forms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
