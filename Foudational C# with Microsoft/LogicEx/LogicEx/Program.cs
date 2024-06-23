string permission = "Admin|Manager";
int level = 56;


if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20) // need to change the permission zzz
{
    Console.WriteLine("Contact Admin for acess");
}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}
