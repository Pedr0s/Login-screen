using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Login;

namespace Login
{
    public class LoginContext : DbContext
    {
        public LoginContext() : base()
        {

        }

        public DbSet<LoginDetail> LoginDetails { get; set; }
    }
}
