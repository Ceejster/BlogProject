using BlogProject.Data;
using BlogProject.Enums;
using BlogProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BlogProject.Services
{
    public class DataService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<BlogUser> _userManager;

        public DataService(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<BlogUser> userManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task ManageDataAsync()
        {
            await _dbContext.Database.MigrateAsync();

            //seeding roles into the system
            await SeedRolesAsync();

            //seed a user into the system
            await SeedUsersAsync();
        }

        private async Task SeedRolesAsync()
        {
            //if there are roles aleady, do nothing
            if (_dbContext.Roles.Any()) return;

            //else create roles
            foreach (var role in Enum.GetNames(typeof(BlogRoles)))
            {
                //role manager to create roles
                await _roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        private async Task SeedUsersAsync()
        {
            //if there are users aleady, do nothing
            if (_dbContext.Users.Any()) return;
            
            //ADMIN USER
            var adminUser = new BlogUser()
            {
                Email = "CJBowman@live.com",
                UserName = "CJ",
                FirstName = "CJ",
                LastName = "Bowman",
                PhoneNumber = "1234567890",
                EmailConfirmed = true
            };
            //using UserManager to create new user defined by asminUser
            await _userManager.CreateAsync(adminUser, "abc&123!");

            //add user to admin role
            await _userManager.AddToRoleAsync(adminUser, BlogRoles.Administrator.ToString());

            //MOD USER
            var moderatorUser = new BlogUser()
            {
                Email = "craigjessie11@gmail.com",
                UserName = "CJ",
                FirstName = "CJ",
                LastName = "Bowman",
                PhoneNumber = "0987654321",
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(moderatorUser, "abc&123!");

            await _userManager.AddToRoleAsync(moderatorUser, BlogRoles.Moderator.ToString());
        }

    }
}
