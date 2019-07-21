using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomIdentity.Data {

    public class ApplicationDbContext : IdentityDbContext<CustomUserTable, CustomRoleTable, int> {

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);
            builder.ApplyConfiguration (new IdentityMigration ());
            builder.ApplyConfiguration (new RoleMigration ());

            //Change my AspNetRoles to Role
           

        }

    }

}