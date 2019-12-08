using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tech_Meetups_Final_Project.Models;

[assembly: HostingStartup(typeof(Tech_Meetups_Final_Project.Areas.Identity.IdentityHostingStartup))]
namespace Tech_Meetups_Final_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Tech_Meetups_IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Tech_Meetups_IdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Tech_Meetups_IdentityContext>();
            });
        }
    }
}