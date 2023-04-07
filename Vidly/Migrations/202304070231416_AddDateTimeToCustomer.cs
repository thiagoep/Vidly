﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateTime");
        }
    }
}
