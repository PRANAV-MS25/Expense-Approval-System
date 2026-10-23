namespace MyBlazorApp.Models
{
    public enum ExpenseStatus
    {
        AutoApproved,
        PendingManagerApproval,
        PendingFinanceApproval,
        Approved,
        Rejected
    }

    public class Expense
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 8);
        public required string EmployeeName { get; set; }
        public decimal Amount { get; set; }
        public required string Description { get; set; }
        public ExpenseStatus Status { get; set; }
        public DateTime SubmissionDate { get; set; } = DateTime.Now;
        public string ApproverNotes { get; set; } = "Pending Review";
    }
}