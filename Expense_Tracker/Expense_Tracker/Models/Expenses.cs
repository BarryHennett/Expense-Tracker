using SQLite;
namespace Expense_Tracker.Models
{
    [Table("Expenses")]
    public class Expenses
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
