namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gpa_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Gpa", c => c.Decimal(precision: 3, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Gpa");
        }
    }
}
