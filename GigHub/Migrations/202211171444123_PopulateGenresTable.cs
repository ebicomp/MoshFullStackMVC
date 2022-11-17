namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("delete from genres");
            Sql("Set identity_insert Genres on");
            Sql("Insert into Genres(Id,Name) Values (1, 'Jazz')");
            Sql("Insert into Genres(Id,Name) Values (2, 'Blue')");
            Sql("Insert into Genres(Id,Name) Values (3, 'Rock')");
            Sql("Insert into Genres(Id,Name) Values (4, 'Country')");

        }

        public override void Down()
        {
            Sql("Delete from Genre where Id in (1,2,3,4)");
        }
    }
}
