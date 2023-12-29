namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_product : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
        }
    }
}
