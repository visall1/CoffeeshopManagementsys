using EntityCoffeeShop.Model;
using EntityCoffeeShop.Table;
using Microsoft.EntityFrameworkCore;

public static class DbSeeder
{
    public static async Task SeedAdminAsync(CoffeeShopContext context)
    {
        if (await context.Users.AnyAsync(u => u.Username == "admin"))
            return;

        var adminUser = new User
        {
            Username = "admin",
            Password = BCrypt.Net.BCrypt.HashPassword("Admin123"),
            role = Role.Admin,
            Profile = new UserProfile
            {
                FullName = "System Admin",
                Email = "admin@coffee.com",
                PhoneNumber = "1234567890",
                Address ="Phnom penh",
                BirthDate = new DateTime(2000, 1, 1)
            }
          
        };

        context.Users.Add(adminUser);
        await context.SaveChangesAsync();
        
    }
}
