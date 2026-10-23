namespace MyBlazorApp.Models;

public class Manager : User
{
    public override string GetRole()
    {
        return "Manager";
    }
}