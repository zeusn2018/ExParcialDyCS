﻿using FluentMigrator;
using System.Reflection;

namespace EnterprisePatterns.Api.Migrations.MySQL
{
    [Migration(1)]
    public class CustomerTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("1_CustomerTable.sql");
        }

        public override void Down()
        {
        }
    }
}
