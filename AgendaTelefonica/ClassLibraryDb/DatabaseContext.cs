using System;
using System.Collections.Generic;
using System.Text;
using AgendaTelefonica.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;


namespace ClassLibraryDb
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }

        private readonly string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;

            //Database.EnsureDeleted();
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Filename={_databasePath}");
        }
    }
}
