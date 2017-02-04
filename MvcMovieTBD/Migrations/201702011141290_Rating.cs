namespace MvcMovieTBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
            AddColumn("dbo.Movies", "ImDBUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ImDBUrl");
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
