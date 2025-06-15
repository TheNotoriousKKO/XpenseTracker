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
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated(); // creates DB and tables if missing
        }

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
