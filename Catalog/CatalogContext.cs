﻿using Kaenx.DataContext.Local;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kaenx.DataContext.Catalog
{
    public class CatalogContext : DbContext
    {
        public DbSet<DeviceViewModel> Devices { get; set; }
        public DbSet<ApplicationViewModel> Applications { get; set; }
        public DbSet<CatalogViewModel> Sections { get; set; }

        public DbSet<AppComObject> AppComObjects { get; set; }
        public DbSet<AppParameter> AppParameters { get; set; }
        public DbSet<AppAdditional> AppAdditionals { get; set; }
        public DbSet<AppSegmentViewModel> AppSegments { get; set; }
        public DbSet<AppParameterTypeViewModel> AppParameterTypes { get; set; }
        public DbSet<AppParameterTypeEnumViewModel> AppParameterTypeEnums { get; set; }
        public DbSet<Hardware2AppModel> Hardware2App { get; set; }

        private bool generatePath;
        private LocalConnectionCatalog _conn;

        public CatalogContext()
        {
            _conn = new LocalConnectionCatalog() { DbHostname = "Catalog.db", Type = LocalConnectionCatalog.DbConnectionType.SqlLite };
            generatePath = false;
        }

        public CatalogContext(LocalConnectionCatalog conn = null, bool _generatePath = false)
        {
            generatePath = _generatePath;
            if (conn == null)
                _conn = new LocalConnectionCatalog() { DbHostname = "Catalog.db", Type = LocalConnectionCatalog.DbConnectionType.SqlLite };
            else
                _conn = conn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            switch (_conn.Type)
            {
                case LocalConnectionCatalog.DbConnectionType.SqlLite:
                    string file;
                    if (generatePath)
                        file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _conn.DbHostname);
                    else
                        file = _conn.DbHostname;
                    optionsBuilder.UseSqlite($"Data Source={file}");
                    break;

                case LocalConnectionCatalog.DbConnectionType.MySQL:
                    optionsBuilder.UseMySql($"Server={_conn.DbHostname};Database={_conn.DbName};Uid={_conn.DbUsername};Pwd={_conn.DbPassword};");
                    break;

                case LocalConnectionCatalog.DbConnectionType.Memory:
                    optionsBuilder.UseSqlite("DataSource=file::memory:?cache=shared");
                    break;
            }
        }
    }
}
