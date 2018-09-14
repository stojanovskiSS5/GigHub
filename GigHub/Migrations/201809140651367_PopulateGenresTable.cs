namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) Values (1,'Jazz')");
            Sql("INSERT INTO Genres (Id,Name) Values (2,'Pop')");
            Sql("INSERT INTO Genres (Id,Name) Values (3,'Rock')");
            Sql("INSERT INTO Genres (Id,Name) Values (4,'Rap')");
            Sql("INSERT INTO Genres (Id,Name) Values (5,'House')");
            Sql("INSERT INTO Genres (Id,Name) Values (6,'Trance')");
            Sql("INSERT INTO Genres (Id,Name) Values (7,'Blues')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE id in (1,2,3,4,5,6,7)");
        }
    }
}
