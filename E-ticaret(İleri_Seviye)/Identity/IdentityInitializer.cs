using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_ticaret_İleri_Seviye_.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {

            if( !context.Roles.Any(i=>i.Name == "Admin") )
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "Admin",Description = "Manager Role"};
                manager.Create(role);
            }
            if( !context.Roles.Any(i => i.Name == "User") )
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "User" , Description = "Manager Role" };
                manager.Create(role);
            }
            if( !context.Users.Any(i => i.Name == "Emre") )
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() 
                {
                    Name = "Emre",
                    Surname = "ÇİÇEK",
                    UserName = "emreciicek",
                    Email = "1907burem@gmail.com",
                    
                };
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id , "Admin");
                manager.AddToRole(user.Id , "User");
            }
            if( !context.Users.Any(i => i.Name == "Yunus") )
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser()
                {
                    Name = "Yunus" ,
                    Surname = "ÇİÇEK" ,
                    UserName = "ynscck" ,
                    Email = "aveb@outlook.com" ,

                };
                manager.Create(user , "1234567");
                manager.AddToRole(user.Id , "User");
            }


            base.Seed(context);
        }
    }
}