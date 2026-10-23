using MyBlazorApp.Models;
using System.Text.Json;

namespace MyBlazorApp.Services
{
    public class AuthenticationService
    {
        private readonly string _filePath = "Data/users.json";
        public User? CurrentUser { get; private set; }

        public async Task<User?> LoginAsync(string email, string password)
        {
            if (!File.Exists(_filePath)) return null;

            string json = await File.ReadAllTextAsync(_filePath);
            var users = JsonSerializer.Deserialize<List<User>>(json) ?? new();

            CurrentUser = users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            return CurrentUser;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}