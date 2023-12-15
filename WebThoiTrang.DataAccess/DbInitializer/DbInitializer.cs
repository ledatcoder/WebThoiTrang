using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebThoiTrang.DataAccess.Data;
using WebThoiTrang.Models;
using WebThoiTrang.Utility;

namespace WebThoiTrang.DataAccess.DbInitializer
{
	public class DbInitializer : IDbInitializer
	{

		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _db;

		public DbInitializer(
			UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			ApplicationDbContext db)
		{
			_roleManager = roleManager;
			_userManager = userManager;
			_db = db;
		}


		public void Initialize()
		{


			//migrations if they are not applied
			try
			{
				if (_db.Database.GetPendingMigrations().Count() > 0)
				{
					_db.Database.Migrate();
				}
			}
			catch (Exception ex) { }



			//create roles if they are not created
			if (!_roleManager.RoleExistsAsync(SD.Role_Customer).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).GetAwaiter().GetResult();


				//if roles are not created, then we will create admin user as well
				_userManager.CreateAsync(new ApplicationUser
				{
					UserName = "datthichlaptrinh@gmail.com",
					Email = "datthichlaptrinh@gmail.com",
					Name = "Le Thanh Dat",
					PhoneNumber = "0898477946",
					StreetAddress = "3/2 Cần Thơ",
					State = "IL",
					PostalCode = "23422",
					City = "Cần Thơ"
				}, "Pa$$w0rd").GetAwaiter().GetResult();


				ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "datthichlaptrinh@gmail.com");
				_userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();

			}

			return;
		}
	}
}
