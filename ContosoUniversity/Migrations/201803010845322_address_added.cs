namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "address_Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "address_Email");
        }
    }
}
