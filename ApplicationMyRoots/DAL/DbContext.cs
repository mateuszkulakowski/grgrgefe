﻿using ApplicationMyRoots.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationMyRoots.DAL
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("MyRootsDatabase") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Error> Errors { get; set; }

        public DbSet<FailedLogin> FailedLogins { get; set; }

        public DbSet<UserTree> UserTrees { get; set; }

        public DbSet<UserTreeNode> UserTreeNodes { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<LanguageText> LanguageTexts { get; set; }
    }
}