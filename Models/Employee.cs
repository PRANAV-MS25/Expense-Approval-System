namespace MyBlazorApp.Models;

public class Employee : User
{
    public override string GetRole()
    {
        return "Employee";
    }
}