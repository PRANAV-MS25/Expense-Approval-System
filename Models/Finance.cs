namespace MyBlazorApp.Models;

public class Finance : User
{
    public override string GetRole()
    {
        return "Finance";
    }
}