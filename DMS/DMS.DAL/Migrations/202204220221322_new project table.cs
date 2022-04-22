namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newprojecttable : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"Create table test(
                id int primary key identity(1,1),
                name varchar(50) NOT NULL,
                address nvarchar(69) NOT NULL,
                Contact nvarchar(15) NOT NULL,
                )"
                );
        }
        
        public override void Down()
        {
        }
    }
}
