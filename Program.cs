using XpenseTracker;
using XpenseTracker.Data;
using XpenseTracker.Models;

ApplicationConfiguration.Initialize();

// TEMP: insert test data if DB is empty
// using (var db = new AppDbContext())
// {
//     if (!db.Expenses.Any())
//     {
//         db.Expenses.Add(new Expense
//         {
//             Category = "Food",
//             Description = "Lunch",
//             Amount = 20.00m,
//             Date = DateTime.Today
//         });
//         db.SaveChanges();
//     }
// }

Application.Run(new MainForm()); // ← you’ll replace Form1 next
