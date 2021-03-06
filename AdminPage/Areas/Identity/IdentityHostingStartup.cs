﻿using System;
using AdminPage.Areas.Identity.Data;
using AdminPage.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AdminPage.Areas.Identity.IdentityHostingStartup))]
namespace AdminPage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AdminPageContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AdminPageContextConnection")));

                services.AddDefaultIdentity<AdminPageUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AdminPageContext>();
            });
        }
    }
}