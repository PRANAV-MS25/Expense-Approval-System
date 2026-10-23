using System.Text.Json;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
     public class ExpenseApprovalService
     {
         private readonly string _filePath = "expenses.json";
         private List<Expense> _expenses = new();

         public ExpenseApprovalService()
         {
             LoadFromJson();
         }

         public List<Expense> GetAllExpenses() => _expenses;

         public void SubmitExpense(Expense expense)
         {
             if (expense.Amount < 5000m)
             {
                 expense.Status = ExpenseStatus.AutoApproved;
                 expense.ApproverNotes = "Auto-Approved (< ₹5,000)";
             }
             else if (expense.Amount >= 5000m && expense.Amount <= 25000m)
             {
                 expense.Status = ExpenseStatus.PendingManagerApproval;
                 expense.ApproverNotes = "Awaiting Manager Approval (₹5,000 - ₹25,000)";
             }
             else
             {
                 expense.Status = ExpenseStatus.PendingFinanceApproval;
                 expense.ApproverNotes = "Awaiting Finance Approval (> ₹25,000)";
             }

             _expenses.Add(expense);
             SaveToJson();
         }

         public void ProcessApproval(string id, string role, bool isApproved, string comments)
         {
             var expense = _expenses.FirstOrDefault(e => e.Id == id);
             if (expense == null) return;

             if (!isApproved)
             {
                 expense.Status = ExpenseStatus.Rejected;
                 expense.ApproverNotes = $"Rejected by {role}: {comments}";
             }
             else if (expense.Status == ExpenseStatus.PendingManagerApproval && role == "Manager")
             {
                 expense.Status = ExpenseStatus.Approved;
                 expense.ApproverNotes = $"Approved by Manager: {comments}";
             }
             else if (expense.Status == ExpenseStatus.PendingFinanceApproval && role == "Finance")
             {
                 expense.Status = ExpenseStatus.Approved;
                 expense.ApproverNotes = $"Approved by Finance: {comments}";
             }

             SaveToJson();
         }

         private void SaveToJson()
         {
             var options = new JsonSerializerOptions { WriteIndented = true };
             File.WriteAllText(_filePath, JsonSerializer.Serialize(_expenses, options));
         }

         private void LoadFromJson()
         {
             if (File.Exists(_filePath))
             {
                 var json = File.ReadAllText(_filePath);
                 _expenses = JsonSerializer.Deserialize<List<Expense>>(json) ?? new();
             }
         }
     }
}