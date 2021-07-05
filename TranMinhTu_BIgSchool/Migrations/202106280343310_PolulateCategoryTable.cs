namespace TranMinhTu_BIgSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories (Id, Name) values (1, 'development')");
            Sql("insert into Categories (Id, Name) values (2, 'business')");
            Sql("insert into Categories (Id, Name) values (3, 'marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
