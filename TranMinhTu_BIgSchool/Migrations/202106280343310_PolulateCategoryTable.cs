namespace TranMinhTu_BIgSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into categories (ID, NAME) values (1, 'development')");
            Sql("insert into categories (ID, NAME) values (2, 'business')");
            Sql("insert into categories (ID, NAME) values (3, 'marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
